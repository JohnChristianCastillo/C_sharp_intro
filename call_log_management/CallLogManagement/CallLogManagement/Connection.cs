using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace CallLogManagement
{
    internal class Connection
    {
        // initialize connection variable
        public SqlConnection connection;
        public SqlCommand cmd; // 
        public SqlDataAdapter data_adapter; // forwards the communication betwen the dataset and the database
        public string message; 

        // constructor
        public void _connection()
        {
            // initialize connection
            //conn = new SqlConnection(@"Data Source=DESKTOP-5Q9O9QV\SQLEXPRESS;Initial Catalog=CallLogManagement;Integrated Security=True");
            // local connection
            connection = new SqlConnection(@"Data Source=.;Initial Catalog=CallManagement;Integrated Security=True");
            connection.Open();
        }

        // method to send data
        public void data_send(string query)
        {
            try
            {
                _connection(); // call connection method
                cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery(); // typically used to perform insert, update, delete that does not return data
                message = "Data has been saved successfully!";
            }
            catch (Exception ex)
            {
                message = "Failed to execute query!";
            }
            connection.Close();
        }   
        public void data_receive(string query)
        {
            try
            {
                _connection(); // call connection method
                cmd = new SqlCommand(query, connection);
                data_adapter = new SqlDataAdapter(cmd);
                message = "Data has been received successfully!";
            }
            catch (Exception ex)
            {
                message = "Failed to execute query!";
            }
            connection.Close();
        }
    }
}
