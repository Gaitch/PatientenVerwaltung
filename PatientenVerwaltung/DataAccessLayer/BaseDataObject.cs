using PatientenVerwaltung.PatientenKartei;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientenVerwaltung.DataAccessLayer
{
    public abstract class BaseDataObject
    {
        protected string connectionString;

        protected BaseDataObject(string connectionString)
        {
            this.connectionString = connectionString;
        }

        protected SqlConnection GetSqlConnection()
        {
            return this.GetSqlConnection(this.connectionString);
        }

        protected SqlConnection GetSqlConnection(string connectionString, string dataSource = "", string initialCatalog = "", string userID = "", string password = "")
        {
            var builder = new SqlConnectionStringBuilder(connectionString);

            var connection = new SqlConnection(builder.ConnectionString);

            return connection;
        }

        public abstract bool UpdateInsertObject<T>(T obj);

        public abstract bool DeactivateObject<T>(T obj);
    }
}
