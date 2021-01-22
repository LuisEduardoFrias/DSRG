
namespace DSG
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Data.SqlTypes;
    using System.Linq;
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
                        sqlComd = new SqlCommand("select name from sysobjects where type='U' and name <> '__EFMigrationsHistory'", sqlCon);

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

            SqlCommand sqlComd = null;

            foreach (string tableName in tables)
            {
                Tables = await ObtenerClausila(sqlCon, sqlComd, tableName, 
                    await ObtenerCompas(sqlCon, sqlComd, tableName, Tables));
            }

            return Tables;
        }


        private async Task<List<Table>> ObtenerCompas(SqlConnection sqlCon,SqlCommand sqlComd, string tableName, List<Table> Tables)
        {
            try
            {
                sqlComd = new SqlCommand(
                 " SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_OCTET_LENGTH, IS_NULLABLE from Information_Schema.Columns "
              + $" WHERE TABLE_NAME = '{tableName}' ORDER BY COLUMN_NAME", sqlCon);

                sqlCon.Open();

                SqlDataReader reader = sqlComd.ExecuteReader();

                while (await reader.ReadAsync())
                {
                    Tables.Add(new Table
                    {
                        TableName = tableName,
                        PropertyName = reader["COLUMN_NAME"].ToString(),
                        PropertyType = reader["DATA_TYPE"].ToString(),
                        PropertyLeangth = reader["CHARACTER_OCTET_LENGTH"].ToString() == "-1" ? "MAX" : reader["CHARACTER_OCTET_LENGTH"].ToString(),
                        IsNullable = reader["IS_NULLABLE"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();

                return null;
            }

            sqlCon.Close();

            return Tables;
        }

        private async Task<List<Table>> ObtenerClausila(SqlConnection sqlCon, SqlCommand sqlComd, string tableName, List<Table> Tables)
        {
            try
            {
                sqlComd = new SqlCommand(
                    " SELECT COLUMN_NAME, CONSTRAINT_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE" +
                    $" WHERE TABLE_NAME = '{ tableName }' ", sqlCon);

                sqlCon.Open();

                SqlDataReader reader = sqlComd.ExecuteReader();

                while (await reader.ReadAsync())
                {
                    Tables.Where(x => x.TableName == tableName).First(x => x.PropertyName == reader["COLUMN_NAME"].ToString())
                        .ConstraintName = reader["CONSTRAINT_NAME"].ToString();
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();

                return null;
            }

            sqlCon.Close();

            return Tables;
        }

    }
}
