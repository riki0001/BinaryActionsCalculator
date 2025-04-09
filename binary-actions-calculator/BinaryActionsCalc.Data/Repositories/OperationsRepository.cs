using BinaryActionsCalc.Data.Context;
using BinaryActionsCalc.Data.Interfaces;
using BinaryActionsCalc.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryActionsCalc.Data.Repositories
{
    public class OperationsRepository : BaseRepository, IOperationsRepository
    {
        public OperationsRepository(BinaryActionsContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<OperationTypes>> GetAll() {
            var operations = _dbContext.OperationTypes
                .ToList();

            return operations;
        }
        public async Task<Dictionary<int, List<int>?>> GetDict() {
            var operationsdict = _dbContext.OperationTypes
                .Include( o => o.ParameterTypeToOperation )
                .ThenInclude( op => op.ParameterTypes)
                .ToDictionary(o => o.Id, o => o.ParameterTypeToOperation?.Select(p => p.ParameterTypes.Id).ToList());
            return operationsdict;
        }
        //Task SaveOperationAuditRecord();

    }
}
