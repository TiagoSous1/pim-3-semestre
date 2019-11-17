using System.Configuration;
using System.Data.SqlClient;

namespace SistemaABCDAO.Repositories
{
    public abstract class Repository
    {
        //stringConnection
        private readonly string connectionString;

        public Repository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["stringConnection"].ToString();
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
