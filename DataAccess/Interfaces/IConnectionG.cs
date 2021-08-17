using CrossCutting.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IConnectionG<T,J>  where T : class
    {
        Task<List<Table>> ObtenerCompos(T sqlCon, J sqlComd, string tableName, List<Table> Tables);

        Task<List<Table>> ObtenerClausula(T sqlCon, J sqlComd, string tableName, List<Table> Tables);
    }
}
