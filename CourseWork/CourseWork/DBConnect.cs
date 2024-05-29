using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    internal class DBConnect
    {
        private SqlConnection _connection=new SqlConnection(@"Data Source=DESKTOP-KFHF8O3\SQLEXPRESS;Initial Catalog=CourseWorkDB;Integrated Security=True;Connect Timeout=30;");

        public SqlConnection GetConnection()
        {
            return _connection;
        }

        public void OpenConnection() 
        { 
            if(_connection.State==System.Data.ConnectionState.Closed)
                _connection.Open();
        }

        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
                _connection.Close();
        }
    }
}
