
namespace DSG
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Threading.Tasks;
    using DSRG.Models;
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
               $"Server={server}; " +
                "database=; " +
                (credentials == true ? "Trusted_connection=True;" : $" User Id={user}; Password={password};"));

            SqlCommand sqlComd = new SqlCommand("SELECT * FROM sys.databases WHERE database_id > 4 ORDER BY database_id  ASC; ", sqlCon);

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

            SqlCommand sqlComd;

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
                Tables = await ObtenerClausula(sqlCon, sqlComd, tableName, 
                    await ObtenerCompas(sqlCon, sqlComd, tableName, Tables));
            }

            return Tables;
        }

        public async Task<List<string>> GetStructureViews(string server, string database, bool credentials, string[] views, string user = null, string password = null)
        {
            SqlConnection sqlCon = new SqlConnection(
                  "Server=" + server + "; " +
                  "database=" + database + "; " +
                  (credentials == true ? "Trusted_connection=True;" : " User Id=" + user + "; Password=" + password + ";"));

            List<string> Listviews = new List<string>();

            SqlCommand sqlComd;

            foreach (string viewsName in views)
            {
                try
                {
                    sqlComd = new SqlCommand($"EXEC sp_helptext N'{database}.dbo.{viewsName}';", sqlCon);

                    sqlCon.Open();

                    SqlDataReader reader = sqlComd.ExecuteReader();

                    while (await reader.ReadAsync())
                    {
                        Listviews.Add(reader["Text"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();

                    return null;
                }

                sqlCon.Close();

                return Listviews;
            }

            return Listviews;
        }

        public async Task<List<string>> GetStructureProcedures(string server, string database, bool credentials, string[] procedures, string user = null, string password = null)
        {
            SqlConnection sqlCon = new SqlConnection(
               "Server=" + server + "; " +
               "database=" + database + "; " +
               (credentials == true ? "Trusted_connection=True;" : " User Id=" + user + "; Password=" + password + ";"));

            List<string> Listprocedures = new List<string>();

            SqlCommand sqlComd;

            foreach (string proceduresName in procedures)
            {
                try
                {
                    sqlComd = new SqlCommand($"EXEC sp_helptext N'{database}.dbo.{proceduresName}';", sqlCon);

                    sqlCon.Open();

                    SqlDataReader reader = sqlComd.ExecuteReader();

                    while (await reader.ReadAsync())
                    {
                        Listprocedures.Add(reader["Text"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();

                    return null;
                }

                sqlCon.Close();

                return Listprocedures;
            }

            return Listprocedures;
        }

        public async Task<List<string>> GetStructureTriggers(string server, string database, bool credentials, string[] triggers, string user = null, string password = null)
        {
            SqlConnection sqlCon = new SqlConnection(
                          "Server=" + server + "; " +
                          "database=" + database + "; " +
                          (credentials == true ? "Trusted_connection=True;" : " User Id=" + user + "; Password=" + password + ";"));

            List<string> Listtriggers = new List<string>();

            SqlCommand sqlComd;

            foreach (string triggersName in triggers)
            {
                try
                {
                    sqlComd = new SqlCommand($" SELECT " +
                                              " Object_name(so.parent_object_id) TableName, " +
                                              " so.name TrigerName, " +
                                              " so.create_date[CreateDate], " +
                                              " sm.definition[Text] " +
                                              " FROM   sys.objects so " +
                                              " INNER JOIN sys.sql_modules sm " +
                                              " ON so.object_id = sm.object_id " +
                                              " WHERE  so.type = 'TR' ", sqlCon);

                    sqlCon.Open();

                    SqlDataReader reader = sqlComd.ExecuteReader();

                    while (await reader.ReadAsync())
                    {
                        Listtriggers.Add(reader["Text"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();

                    return null;
                }

                sqlCon.Close();

                return Listtriggers;
            }

            return Listtriggers;
        }

        public async Task<List<string>> GetStructureFunctions(string server, string database, bool credentials, string[] triggers, string user = null, string password = null)
        {
            //https://docs.microsoft.com/es-es/sql/relational-databases/user-defined-functions/view-user-defined-functions?view=sql-server-ver15
            return new List<string> { };
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

        private async Task<List<Table>> ObtenerClausula(SqlConnection sqlCon, SqlCommand sqlComd, string tableName, List<Table> Tables)
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
