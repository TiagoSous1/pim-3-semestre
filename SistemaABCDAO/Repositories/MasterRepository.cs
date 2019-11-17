using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace SistemaABCDAO.Repositories
{
    public abstract class MasterRepository : Repository
    {
        protected List<SqlParameter> parameters;
        protected int ExecuteNonQuery(string transacSql)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = transacSql;
                    command.CommandType = CommandType.Text;

                    foreach (SqlParameter item in parameters)
                    {
                        command.Parameters.Add(item);
                    }

                    int result = command.ExecuteNonQuery();
                    parameters.Clear();
                    return result;
                }
            }
        }

        protected DataTable ExecuteRead(string transacSql)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = transacSql;
                        command.CommandType = CommandType.Text;
                        //command.CommandTimeout = 0; 
                        if (parameters != null)
                        {
                            foreach (SqlParameter item in parameters)
                            {
                                command.Parameters.Add(item);
                            }
                        }

                        SqlDataReader reader = command.ExecuteReader();
                        using (var table = new DataTable())
                        {
                            table.Load(reader);
                            reader.Dispose();
                            return table;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
