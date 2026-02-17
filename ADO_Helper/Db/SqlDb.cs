using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Helper.Db
{
    public class SqlDb
    {
        private readonly string _connectionString;

        public SqlDb(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException (
                    "Connection string cannot be null or empty",
                    nameof(connectionString)
                    );

            _connectionString = connectionString;
        }

        public int ExecuteNonQuery(string Query, CommandType commandType = CommandType.Text,
            int timeout = 30, params SqlParameter[] parameters)
        {
            if (string.IsNullOrWhiteSpace(Query))
                throw new ArgumentException(
                    "Query cannot be empty !",
                    nameof(Query)
                    );

            int AffectedRows = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.CommandType = commandType;
                        command.CommandTimeout = timeout;

                        if (parameters != null && parameters.Length > 0)
                            command.Parameters.AddRange(parameters);

                        AffectedRows = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); // Exceptions Will be handeled in the right way later on
            }
            return AffectedRows;
        }
    }
}
