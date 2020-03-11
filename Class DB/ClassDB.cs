using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gos_avtoinspekciya.Authorization
{
    class ClassDB
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Gos_avto_inspekciya;Integrated Security=True");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
