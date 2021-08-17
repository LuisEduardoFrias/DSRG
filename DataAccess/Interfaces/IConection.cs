using CrossCutting.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IConection
    {
        Task<List<string>> GetDataBases();

        Task<List<string>> GetEstructuras(string obtener);


        Task<List<Table>> GetTablesProperty(string[] tables);

        Task<List<string>> GetStructureViews(string[] views);

        Task<List<string>> GetStructureProcedures(string[] procedures);

        Task<List<string>> GetStructureTriggers(string[] triggers);

        Task<List<string>> GetStructureFunctions(string[] triggers);
    }
}
