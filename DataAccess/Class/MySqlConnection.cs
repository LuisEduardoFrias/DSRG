using DataAccess.Interfaces;
using CrossCutting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mysql = MySql.Data.MySqlClient;

namespace DataAccess.Class
{
    public class MySqlConnection :  Connection, IConnectionG<mysql.MySqlConnection, mysql.MySqlCommand>, IConection
    {
        private static MySqlConnection Instance;

        public static MySqlConnection GetInstance()
        {
            if (Instance == null)
                Instance = new MySqlConnection();

            return Instance;
        }

        private MySqlConnection()
        {
        }

        public async Task<List<string>> GetDataBases()
        {
            mysql.MySqlConnection sqlCon = new mysql.MySqlConnection($"Server={_server}; Port={_port}; User Id={_user}; Password={_password};");

            mysql.MySqlCommand sqlComd = new mysql.MySqlCommand("show databases", sqlCon);

            sqlCon.Open();

            System.Data.Common.DbDataReader reader = await sqlComd.ExecuteReaderAsync();

            List<string> databases = new List<string>();


            while (await reader.ReadAsync())
            {
                databases.Add(reader["Database"].ToString());
            }

            sqlCon.Close();

            return databases;
        }

        public async Task<List<string>> GetStructureFunctions(string[] triggers)
        {
            https://docs.microsoft.com/es-es/sql/relational-databases/user-defined-functions/view-user-defined-functions?view=sql-server-ver15
            return new List<string> { };
        }

        public async Task<List<string>> GetStructureProcedures(string[] procedures)
        {
            mysql.MySqlConnection sqlCon = new mysql.MySqlConnection($"Server={_server}; database = {_database} Port={_port}; User Id={_user}; Password={_password};");

            List<string> Listprocedures = new List<string>();

            mysql.MySqlCommand sqlComd;

            foreach (string proceduresName in procedures)
            {
                try
                {
                    sqlComd = new mysql.MySqlCommand($"EXEC sp_helptext N'{_database}.dbo.{proceduresName}';", sqlCon);

                    sqlCon.Open();

                    mysql.MySqlDataReader reader = sqlComd.ExecuteReader();

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

        public async Task<List<string>> GetStructureTriggers(string[] triggers)
        {
            mysql.MySqlConnection sqlCon = new mysql.MySqlConnection(
               "Server=" + _server + "; " +
               "database=" + _database + "; " +
               (_credentials == true ? "Trusted_connection=True;" : " User Id=" + _user + "; Password=" + _password + ";"));

            List<string> Listtriggers = new List<string>();

            mysql.MySqlCommand sqlComd;

            foreach (string triggersName in triggers)
            {
                try
                {
                    sqlComd = new mysql.MySqlCommand($" SELECT " +
                                              " Object_name(so.parent_object_id) TableName, " +
                                              " so.name TrigerName, " +
                                              " so.create_date[CreateDate], " +
                                              " sm.definition[Text] " +
                                              " FROM   sys.objects so " +
                                              " INNER JOIN sys.sql_modules sm " +
                                              " ON so.object_id = sm.object_id " +
                                              " WHERE  so.type = 'TR' ", sqlCon);

                    sqlCon.Open();

                    mysql.MySqlDataReader reader = sqlComd.ExecuteReader();

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

        public async Task<List<string>> GetStructureViews(string[] views)
        {
            mysql.MySqlConnection sqlCon = new mysql.MySqlConnection($"Server={_server}; database = {_database} Port={_port}; User Id={_user}; Password={_password};");

            List<string> Listviews = new List<string>();

            mysql.MySqlCommand sqlComd;

            foreach (string viewsName in views)
            {
                try
                {
                    sqlComd = new mysql.MySqlCommand($"EXEC sp_helptext N'{_database}.dbo.{viewsName}';", sqlCon);

                    sqlCon.Open();

                    mysql.MySqlDataReader reader = sqlComd.ExecuteReader();

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

        public async Task<List<string>> GetEstructuras(string obtener)
        {
            mysql.MySqlConnection sqlCon = new mysql.MySqlConnection($"Server={_server}; database = {_database} Port={_port}; User Id={_user}; Password={_password};");

            mysql.MySqlCommand sqlComd;

            switch (obtener)
            {
                case "Tablas":
                    {
                        /*--La consulta muestra todas las tablas de la base de datos*/
                        sqlComd = new mysql.MySqlCommand("select name from sysobjects where type='U' and name <> '__EFMigrationsHistory'", sqlCon);

                        break;
                    }
                case "Vistas":
                    {
                        /*--La consulta muestra todas las vistas de la base de datos*/
                        sqlComd = new mysql.MySqlCommand("select name from sysobjects where type='V'", connection: sqlCon);

                        break;
                    }
                case "Procedimientos":
                    {
                        /*--La consulta muestra todos los procedimientos de la base de datos*/
                        sqlComd = new mysql.MySqlCommand("select name from sysobjects where type='P'", connection: sqlCon);

                        break;
                    }
                case "Triggers":
                    {
                        /*--La consulta muestra todos los triggers de la base de datos*/
                        sqlComd = new mysql.MySqlCommand("select name from sysobjects where type='T'", connection: sqlCon);

                        break;
                    }
                default:
                    {
                        /*--La consulta muestra todas las tablas de la base de datos*/
                        sqlComd = new mysql.MySqlCommand("Select name from sysobjects where type='U'", connection: sqlCon);

                        break;
                    }

            }

            sqlCon.Open();

            System.Data.Common.DbDataReader reader = await sqlComd.ExecuteReaderAsync();
            //System.Data.Common.DbDataReader reader = await sqlComd.ExecuteReaderAsync();

            List<string> tables = new List<string>();

            while (await reader.ReadAsync())
            {
                tables.Add(reader["name"].ToString());
            }

            sqlCon.Close();

            return tables;
        }

        public async Task<List<Table>> GetTablesProperty(string[] tables)
        {
            mysql.MySqlConnection sqlCon = new mysql.MySqlConnection($"Server={_server}; database = {_database} Port={_port}; User Id={_user}; Password={_password};");

            List<Table> Tables = new List<Table>();

            mysql.MySqlCommand sqlComd = null;

            foreach (string tableName in tables)
            {
                Tables = await ObtenerClausula(sqlCon, sqlComd, tableName,
                    await ObtenerCompos(sqlCon, sqlComd, tableName, Tables));
            }

            return Tables;
        }


        public async Task<List<Table>> ObtenerClausula(mysql.MySqlConnection sqlCon, mysql.MySqlCommand sqlComd, string tableName, List<Table> Tables)
        {
            try
            {
                sqlComd = new mysql.MySqlCommand(
                 " SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_OCTET_LENGTH, IS_NULLABLE from Information_Schema.Columns "
              + $" WHERE TABLE_NAME = '{tableName}' ORDER BY COLUMN_NAME", connection: sqlCon);


                mysql.MySqlDataReader reader = sqlComd.ExecuteReader();

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


        public async Task<List<Table>> ObtenerCompos(mysql.MySqlConnection sqlCon, mysql.MySqlCommand sqlComd, string tableName, List<Table> Tables)
        {
            try
            {
                sqlComd = new mysql.MySqlCommand(
                    " SELECT COLUMN_NAME, CONSTRAINT_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE" +
                    $" WHERE TABLE_NAME = '{ tableName }' ", sqlCon);

                sqlCon.Open();

                mysql.MySqlDataReader reader = sqlComd.ExecuteReader();

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
