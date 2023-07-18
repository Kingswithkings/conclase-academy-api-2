using conclase_academy_api_2.interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace conclase_academy_api_2.services
{
    public class DatabaseHelper : iDatabaseHelper 
    {
        private IConfiguration _configuration;
        public DatabaseHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DataTable ExecuteQuerry(string query)
        {
            var dbconnectionstring = _configuration.GetSection("ConnectionStrings : DefaultConnection").Value;

            using (var connection = new SqlConnection(dbconnectionstring))
            {
                var dataTable = new DataTable();
                var command = new SqlCommand(query, connection);
                var dataAdapter = new SqlDataAdapter(command);

                dataAdapter.Fill(dataTable);
                return  dataTable;
            }
           
        }

        
        
    }
}
