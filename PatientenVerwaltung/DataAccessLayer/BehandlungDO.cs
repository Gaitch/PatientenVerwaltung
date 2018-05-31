using PatientenVerwaltung.PatientenKartei.AbrechnungsObjekte;
using PatientenVerwaltung.PatientenKartei.BehandlungsObjekte;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientenVerwaltung.DataAccessLayer
{
    public class BehandlungDO : BaseDataObject
    {
        public BehandlungDO(string connectionString) : base(connectionString)
        {
        }

        public override bool DeactivateObject<T>(T obj)
        {
            throw new NotImplementedException();
        }

        public Behandlung GetBehandlung(int id)
        {
            using (SqlConnection connection = base.GetSqlConnection())
            {
                connection.Open();
                var cmd = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM treatment WHERE id = @val"
                };
                cmd.Parameters.Add(new SqlParameter("@val", id));
                cmd.Prepare();
                SqlDataReader reader = cmd.ExecuteReader();

                Behandlung b = new Behandlung(reader.GetInt32(0), reader.GetDateTime(1));


                return b;
            }
        }

        private void InsertVerordnungenToBehandlung(Behandlung behandlung)
        {
            using (SqlConnection connection = base.GetSqlConnection())
            {
                connection.Open();
                var cmd = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM prescription, recpie WHERE prescription.treatment_id = @val"
                };
                cmd.Parameters.Add(new SqlParameter("@val", behandlung.GetId()));
                cmd.Prepare();
                SqlDataReader reader = cmd.ExecuteReader();
            }
        }

        public List<Behandlung> GetBehandlungenFromCard(int cardID)
        {
            List<Behandlung> bList = new List<Behandlung>();
            using (SqlConnection connection = base.GetSqlConnection())
            {
                connection.Open();
                var cmd = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM treatment WHERE patientcard_id = @val"
                };
                cmd.Parameters.Add(new SqlParameter("@val", cardID));
                cmd.Prepare();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        bList.Add(this.GetBehandlung(reader.GetInt32(0)));
                    }
                }

                reader.Close();
            }

            return bList;
        }

        public List<Behandlung> GetBehandlungenFromQuartal(Quartal quartal)
        {
            using (SqlConnection connection = base.GetSqlConnection())
            {
                connection.Open();
                string dateStart, dateEnd;
                dateStart = quartal.GetVonDate().ToString();
                dateEnd = quartal.GetVonDate().ToString();
                var cmd = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM treatment WHERE date_of_treatment BETWEEN @dStart AND @dEnd"
                };
                cmd.Parameters.Add(new SqlParameter("@dStart", dateStart));
                cmd.Parameters.Add(new SqlParameter("@dEnd", dateEnd));
                cmd.Prepare();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    //
                }
            }
        }

        public override bool UpdateInsertObject<T>(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
