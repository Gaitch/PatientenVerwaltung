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
                    CommandText = "SELECT * FROM patient_card WHERE id = @val"
                };
                cmd.Parameters.Add(new SqlParameter("@val", id));
                cmd.Prepare();
                SqlDataReader reader = cmd.ExecuteReader();

                return null;
            }
        }  
    }
}
