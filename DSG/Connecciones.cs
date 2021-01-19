using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSG
{
    public enum Connection
    {
        SqlServer,
        MySql
    }

    public class ConnectionString
    {
        private static ConnectionString Instance;

        Connection _connection;

        public static ConnectionString GetInstance(Connection connection)
        {
            if (Instance == null)
                Instance = new ConnectionString(connection);

            return Instance;
        }

        public ConnectionString(Connection connection)
        {
            _connection = connection;
        }

        public string GetConnectionString() =>
            _connection switch =>
            {
                Connection.SqlServer = ""
    }
        }

    }
}
