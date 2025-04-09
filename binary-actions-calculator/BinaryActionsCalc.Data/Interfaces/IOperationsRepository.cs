using BinaryActionsCalc.Data.Interfaces;
using BinaryActionsCalc.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryActionsCalc.Data.Repositories
{
    public interface IOperationsRepository : IBaseRepository
    {
        Task<IEnumerable<OperationTypes>> GetAll();
        Task<Dictionary<int, List<int>?>> GetDict();
        //Task SaveOperationAuditRecord();

    }
}
