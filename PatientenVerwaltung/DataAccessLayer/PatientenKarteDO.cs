using PatientenVerwaltung.PatientenKartei.BehandlungsObjekte;
using PatientenVerwaltung.PatientenKartei.PatientenObjekte;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientenVerwaltung.DataAccessLayer
{
    public class PatientenKarteDO : BaseDataObject
    {
        public PatientenKarteDO(string connectionString) : base(connectionString)
        {

        }

        public PatientenKarte GetPatientenKarte(int id)
        {
            using (SqlConnection connection = base.GetSqlConnection())
            {
                connection.Open();
                var cmd = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM patient_card WHERE patient_id = @val"
                };
                cmd.Parameters.Add(new SqlParameter("@val", id));
                cmd.Prepare();
                SqlDataReader reader = cmd.ExecuteReader();

                return null;
            }
        }

        public List<PatientenKarte> GetAllPatientenKarten()
        {
            List<PatientenKarte> pkList = new List<PatientenKarte>();
            using (SqlConnection connection = base.GetSqlConnection())
            {
                connection.Open();
                var cmd = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM patient_card"
                };
                cmd.Prepare();
                SqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        PatientenKarte pk = new PatientenKarte(reader.GetInt32(0), this.GetPatient(reader.GetInt32(1)));
                        this.InsertBehandlungenToCard(pk);
                        pkList.Add(pk);
                    }
                }
            }

            return pkList;
        }

        private Patient GetPatient(int id)
        {
            PatientDO pDO = new PatientDO(base.connectionString);
            return pDO.GetPatient(id);
        }

        private void InsertBehandlungenToCard(PatientenKarte card)
        {
            BehandlungDO bDO = new BehandlungDO(base.connectionString);
            List<Behandlung> bList = new List<Behandlung>();

            foreach (Behandlung b in bDO.GetBehandlungenFromCard(card.GetId()))
            {
                card.AddBehandlung(b);
            }
        }

        public override bool UpdateInsertObject<T>(T obj)
        {
            PatientenKarte pk = obj as PatientenKarte;
            int success = 0;

            using (SqlConnection connection = base.GetSqlConnection())
            {
                connection.Open();

                var cmd = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "IF NOT EXISTS (SELECT 1 FROM patient_card WITH(NOLOCK) WHERE id = @val"
                    + "BEGIN INSERT INTO patient_card (patient_id) VALUES (@patID) END"
                    + "ELSE BEGIN UPDATE patient_card SET patient_id = @patID WHERE id = @val END"
                };

                cmd.Parameters.Add(new SqlParameter("@val", pk.GetId()));
                cmd.Parameters.Add(new SqlParameter("@patID", pk.GetPatient().id));
                cmd.Prepare();
                success = cmd.ExecuteNonQuery();
            }

            return success == 1;
        }

        public override bool DeactivateObject<T>(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
