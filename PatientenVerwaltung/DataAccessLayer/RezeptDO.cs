using PatientenVerwaltung.PatientenKartei.BehandlungsObjekte;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientenVerwaltung.DataAccessLayer
{
    public class RezeptDO : BaseDataObject
    {
        protected RezeptDO(string connectionString) : base(connectionString)
        {
        }

        public Rezept GetRezept(int id)
        {
            using (SqlConnection connection = base.GetSqlConnection())
            {
                connection.Open();
                var cmd = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM recipe WHERE id = @val"
                };
                cmd.Parameters.Add(new SqlParameter("@val", id));
                cmd.Prepare();
                SqlDataReader reader = cmd.ExecuteReader();

                return null;
            }
        }
    }
}
