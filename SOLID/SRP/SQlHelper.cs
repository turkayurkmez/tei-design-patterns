using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class SQlHelper
    {
        public int ExecuteNonQuery(string query)
        {
            /*
             * SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=SRP;Integrated Security=True");
             * 
             * SqlCommand command = new SqlCommand(query, connection);
             * 
             * parametre eklersiniz...
             * 
             * connection.Open();
             * var result = command.ExecuteNonQuery();
             * connection.Close();
             * 
             * 
             */
            var operation = new Random().Next(0, 2);
            return operation;
        }
    }
}
