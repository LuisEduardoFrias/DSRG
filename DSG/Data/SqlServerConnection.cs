
namespace DSG
{
    using System;
    using System.Collections.Generic;
    using sql = System.Data.SqlClient;
    using System.Linq;
    using System.Threading.Tasks;
    using DSRG.Models;
    using DSG.Interfaces;
    using System.Data.SqlClient;

    //

    public class SqlServerConnection : IConnection<sql.SqlConnection, sql.SqlCommand>
    {
        private static SqlServerConnection Instance;

        public static SqlServerConnection GetInstance()
        {
            if (Instance == null)
                Instance = new SqlServerConnection();

            return Instance;
        }

        private SqlServerConnection()
        {
        }


        public async Task<List<string>> GetDataBases(string server, bool credentials, string user = null, string password = null)
        {
            sql.SqlConnection sqlCon = new sql.SqlConnection(
               $"Server={server}; " +
                "database=; " +
                (credentials == true ? "Trusted_connection=True;" : $" User Id={user}; Password={password};"));

            sql.SqlCommand sqlComd = new sql.SqlCommand("SELECT * FROM sys.databases WHERE database_id > 4 ORDER BY database_id  ASC; ", sqlCon);

            sqlCon.Open();

            sql.SqlDataReader reader = await sqlComd.ExecuteReaderAsync();

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
            sql.SqlConnection sqlCon = new sql.SqlConnection(
                "Server=" + server + "; " +
                "database=" + database + "; " + 
                (credentials == true ? "Trusted_connection=True;" : " User Id=" + user + "; Password=" + password + ";"));

            sql.SqlCommand sqlComd;

            switch (obtener)
            {
                case "Tablas":
                    {
                        /*--La consulta muestra todas las tablas de la base de datos*/
                        sqlComd = new sql.SqlCommand("select name from sysobjects where type='U' and name <> '__EFMigrationsHistory'", sqlCon);

                        break;
                    }
                case "Vistas":
                    {
                        /*--La consulta muestra todas las vistas de la base de datos*/
                        sqlComd = new sql.SqlCommand("select name from sysobjects where type='V'", sqlCon);

                        break;
                    }
                case "Procedimientos":
                    {
                        /*--La consulta muestra todos los procedimientos de la base de datos*/
                        sqlComd = new sql.SqlCommand("select name from sysobjects where type='P'", sqlCon);

                        break;
                    }
                case "Triggers":
                    {
                        /*--La consulta muestra todos los triggers de la base de datos*/
                        sqlComd = new sql.SqlCommand("select name from sysobjects where type='T'", sqlCon);

                        break;
                    }
                default :
                    {
                        /*--La consulta muestra todas las tablas de la base de datos*/
                        sqlComd = new sql.SqlCommand("Select name from sysobjects where type='U'", sqlCon);

                        break;
                    }

            }

            sqlCon.Open();

            sql.SqlDataReader reader = await sqlComd.ExecuteReaderAsync();

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
            sql.SqlConnection sqlCon = new sql.SqlConnection(
               "Server=" + server + "; " +
               "database=" + database + "; " +
               (credentials == true ? "Trusted_connection=True;" : " User Id=" + user + "; Password=" + password + ";"));

            List<Table> Tables = new List<Table>();

            sql.SqlCommand sqlComd = null;

            foreach (string tableName in tables)
            {
                Tables = await ObtenerClausula(sqlCon, sqlComd, tableName, 
                    await ObtenerCompas(sqlCon, sqlComd, tableName, Tables));
            }

            return Tables;
        }


        public async Task<List<string>> GetStructureViews(string server, string database, bool credentials, string[] views, string user = null, string password = null)
        {
            sql.SqlConnection sqlCon = new sql.SqlConnection(
                  "Server=" + server + "; " +
                  "database=" + database + "; " +
                  (credentials == true ? "Trusted_connection=True;" : " User Id=" + user + "; Password=" + password + ";"));

            List<string> Listviews = new List<string>();

            sql.SqlCommand sqlComd;

            foreach (string viewsName in views)
            {
                try
                {
                    sqlComd = new sql.SqlCommand($"EXEC sp_helptext N'{database}.dbo.{viewsName}';", sqlCon);

                    sqlCon.Open();

                    sql.SqlDataReader reader = sqlComd.ExecuteReader();

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
            sql.SqlConnection sqlCon = new sql.SqlConnection(
               "Server=" + server + "; " +
               "database=" + database + "; " +
               (credentials == true ? "Trusted_connection=True;" : " User Id=" + user + "; Password=" + password + ";"));

            List<string> Listprocedures = new List<string>();

            sql.SqlCommand sqlComd;

            foreach (string proceduresName in procedures)
            {
                try
                {
                    sqlComd = new sql.SqlCommand($"EXEC sp_helptext N'{database}.dbo.{proceduresName}';", sqlCon);

                    sqlCon.Open();

                    sql.SqlDataReader reader = sqlComd.ExecuteReader();

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
            sql.SqlConnection sqlCon = new sql.SqlConnection(
                          "Server=" + server + "; " +
                          "database=" + database + "; " +
                          (credentials == true ? "Trusted_connection=True;" : " User Id=" + user + "; Password=" + password + ";"));

            List<string> Listtriggers = new List<string>();

            sql.SqlCommand sqlComd;

            foreach (string triggersName in triggers)
            {
                try
                {
                    sqlComd = new sql.SqlCommand($" SELECT " +
                                              " Object_name(so.parent_object_id) TableName, " +
                                              " so.name TrigerName, " +
                                              " so.create_date[CreateDate], " +
                                              " sm.definition[Text] " +
                                              " FROM   sys.objects so " +
                                              " INNER JOIN sys.sql_modules sm " +
                                              " ON so.object_id = sm.object_id " +
                                              " WHERE  so.type = 'TR' ", sqlCon);

                    sqlCon.Open();

                    sql.SqlDataReader reader = sqlComd.ExecuteReader();

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


        public async Task<List<Table>> ObtenerCompas(sql.SqlConnection sqlCon, sql.SqlCommand sqlComd, string tableName, List<Table> Tables)
        {
            try
            {
                sqlComd = new sql.SqlCommand(
                 " SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_OCTET_LENGTH, IS_NULLABLE, NUMERIC_PRECISION, NUMERIC_SCALE, COLUMN_DEFAULT from Information_Schema.Columns "
              + $" WHERE TABLE_NAME = '{tableName}' ORDER BY ORDINAL_POSITION", sqlCon);

                //"NUMERIC_PRECISION, NUMERIC-SCALE

                sqlCon.Open();

                sql.SqlDataReader reader = sqlComd.ExecuteReader();

                while (await reader.ReadAsync())
                {
                    Tables.Add(new Table
                    {
                        TableName = tableName,
                        PropertyName = reader["COLUMN_NAME"].ToString(),
                        PropertyType = reader["DATA_TYPE"].ToString(),
                        PropertyLeangth = reader["CHARACTER_OCTET_LENGTH"].ToString() == "-1" ? "MAX" : reader["CHARACTER_OCTET_LENGTH"].ToString(),
                        PropertyPrecision = reader["NUMERIC_PRECISION"].ToString(),
                        PropertyScale = reader["NUMERIC_SCALE"].ToString(),
                        ColumnDefault = reader["COLUMN_DEFAULT"].ToString(),
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

        public async Task<List<Table>> ObtenerClausula(sql.SqlConnection sqlCon, sql.SqlCommand sqlComd, string tableName, List<Table> Tables)
        {
            try
            {
                sqlComd = new sql.SqlCommand(
                    " SELECT COLUMN_NAME, CONSTRAINT_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE" +
                    $" WHERE TABLE_NAME = '{ tableName }' ", sqlCon);

                sqlCon.Open();

                sql.SqlDataReader reader = sqlComd.ExecuteReader();

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
