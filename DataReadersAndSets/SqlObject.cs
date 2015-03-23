using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataReadersAndSets
{
    public static class SqlObject
    {
        public static SqlCommand SqlCommand { get; set; }
        private static string _connectionString;

        public static void Execute(string sqlInstruction)
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DataReadersAndSets"].ToString();
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand(sqlInstruction, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static IEnumerable<IDataReader> RetrieveQueryInDataReader(string sqlInstruction)
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DataReadersAndSets"].ToString();
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand(sqlInstruction, connection);
                command.Connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return reader;    
                    }
                }
            }
        }

        public static DataSet RetrieveQueryInDataSet(string sqlInstruction)
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DataReadersAndSets"].ToString();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var adapter = new SqlDataAdapter(sqlInstruction, connection);
                var dataSet = new DataSet("ReturnableValues");
                adapter.Fill(dataSet);
                return dataSet;
            }
        }
    }
}