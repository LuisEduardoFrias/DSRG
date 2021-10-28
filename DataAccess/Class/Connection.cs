using DataAccess.Interfaces;
using mysql = MySql.Data.MySqlClient;
using sql = System.Data.SqlClient;

namespace DataAccess.Class
{
    public class Connection
    {
        protected static string _server, _database, _user = null, _password = null;
        protected static bool _credentials;
        protected static int? _port;

        private static Connection Instance;
        public static Connection GetInstance(string server,  bool credentials, string database = null, int? port = null, string user = null, string password = null)
        {
            if (Instance == null)
                Instance = new Connection();

            _server = server;
            _database = database;
            _user = user;
            _password = password;
            _credentials = credentials;
            _port = port;
            return Instance;
        }

        public IConection GetConecction()
        {
           // mysql.MySqlConnection mySqlCon = new mysql.MySqlConnection($"Server={_server}; Port={_port}; User Id={_user}; Password={_password};");

            sql.SqlConnection sqlCon = new sql.SqlConnection(
               $"Server={_server}; " +
                "database=; " +
                (_credentials == true ? "Trusted_connection=True;" : $" User Id={_user}; Password={_password};"));

            try
            {
                //mySqlCon.Open();
                //mySqlCon.Close();
                //return MySqlConnection.GetInstance();

                sqlCon.Open();
                sqlCon.Close();
                return SqlServerConnection.GetInstance();
            }
            catch
            {
                try
                {
                    sqlCon.Open();
                    sqlCon.Close();
                    return SqlServerConnection.GetInstance();
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
