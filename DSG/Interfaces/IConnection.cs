using DSRG.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DSG.Interfaces
{
    public interface IConnection<T,J> where T : class
    {
        Task<List<string>> GetDataBases(string server, bool credentials, string user = null, string password = null);

        Task<List<string>> GetTables(string server, string database, bool credentials, string obtener, string user = null, string password = null);


        Task<List<Table>> GetTablesProperty(string server, string database, bool credentials, string[] tables, string user = null, string password = null);

        Task<List<string>> GetStructureViews(string server, string database, bool credentials, string[] views, string user = null, string password = null);

        Task<List<string>> GetStructureProcedures(string server, string database, bool credentials, string[] procedures, string user = null, string password = null);

        Task<List<string>> GetStructureTriggers(string server, string database, bool credentials, string[] triggers, string user = null, string password = null);

        Task<List<string>> GetStructureFunctions(string server, string database, bool credentials, string[] triggers, string user = null, string password = null);



        Task<List<Table>> ObtenerCompas(T sqlCon, J sqlComd, string tableName, List<Table> Tables);

        Task<List<Table>> ObtenerClausula(T sqlCon, J sqlComd, string tableName, List<Table> Tables);
    }
}
