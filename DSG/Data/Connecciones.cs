
namespace DSG
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Threading.Tasks;
    //
    using Models;
    //

    public class ConnectionString
    {
        private static ConnectionString Instance;

        public static ConnectionString GetInstance()
        {
            if (Instance == null)
                Instance = new ConnectionString();

            return Instance;
        }

        public ConnectionString()
        {
        }


        public async Task<List<string>> GetDataBases(string server, bool credentials, string user = null, string password = null)
        {
            SqlConnection sqlCon = new SqlConnection(
                "Server=" + server + "; " +
                "database=; " +
                (credentials == true ? "Trusted_connection=True;" : " User Id=" + user + "; Password=" + password + ";"));

            SqlCommand sqlComd = new SqlCommand("SELECT  * FROM sys.databases WHERE database_id > 4 ORDER BY database_id  ASC; ", sqlCon);

            sqlCon.Open();

            SqlDataReader reader = await sqlComd.ExecuteReaderAsync();

            List<string> databases = new List<string>();


            while (await reader.ReadAsync())
            {
                databases.Add(reader["name"].ToString());
            }

            sqlCon.Close();

            return databases;

        }

        public async Task<List<string>> GetTables(string server, string database, bool credentials, string obtener, string user = null, string password = null)
        {
            SqlConnection sqlCon = new SqlConnection(
                "Server=" + server + "; " +
                "database=" + database + "; " + 
                (credentials == true ? "Trusted_connection=True;" : " User Id=" + user + "; Password=" + password + ";"));

            SqlCommand sqlComd = null;

            switch (obtener)
            {
                case "Tablas":
                    {
                        /*--La consulta muestra todas las tablas de la base de datos*/
                        sqlComd = new SqlCommand("Select name from sysobjects where type='U'", sqlCon);

                        break;
                    }
                case "Vistas":
                    {
                        /*--La consulta muestra todas las vistas de la base de datos*/
                        sqlComd = new SqlCommand("select name from sysobjects where type='V'", sqlCon);

                        break;
                    }
                case "Procedimientos":
                    {
                        /*--La consulta muestra todos los procedimientos de la base de datos*/
                        sqlComd = new SqlCommand("select name from sysobjects where type='P'", sqlCon);

                        break;
                    }
                case "Triggers":
                    {
                        /*--La consulta muestra todos los triggers de la base de datos*/
                        sqlComd = new SqlCommand("select name from sysobjects where type='T'", sqlCon);

                        break;
                    }
                default :
                    {
                        /*--La consulta muestra todas las tablas de la base de datos*/
                        sqlComd = new SqlCommand("Select name from sysobjects where type='U'", sqlCon);

                        break;
                    }

            }

            sqlCon.Open();

            SqlDataReader reader = await sqlComd.ExecuteReaderAsync();

            List<string> tables = new List<string>();

            while (await reader.ReadAsync())
            {
                tables.Add( reader["name"].ToString() );
            }

            sqlCon.Close();

            return tables;

        }


        public async Task<List<Table>> GetTablesProperty(string server, string database, bool credentials, string[] tables, string user = null, string password = null)
        {
            SqlConnection sqlCon = new SqlConnection(
               "Server=" + server + "; " +
               "database=" + database + "; " +
               (credentials == true ? "Trusted_connection=True;" : " User Id=" + user + "; Password=" + password + ";"));

            List<Table> Tables = new List<Table>();

            SqlCommand sqlComd;

            foreach (string tableName in tables)
            {
                sqlComd = new SqlCommand("SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_OCTET_LENGTH " +
                                            " FROM Information_Schema.Columns " +
                                            " WHERE TABLE_NAME = '" + tableName + @"' "+
                                            " ORDER BY COLUMN_NAME ", sqlCon);

                sqlCon.Open();

                SqlDataReader reader = await sqlComd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    Tables.Add(new Table
                    {
                        TableName = tableName,
                        PropertyName = reader["COLUMN_NAME"].ToString(),
                        PropertyType = reader["DATA_TYPE"].ToString(),
                        PropertyLeangth = reader["CHARACTER_OCTET_LENGTH"].ToString(),
                    });
                }

                sqlCon.Close();
            }

            return Tables;
        }

    }
}
