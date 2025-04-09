using BinaryActionsCalc.Logic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryActionsCalc.Logic.Interfaces
{
    public interface IOperationService
    {
        Task<IEnumerable<OperationTypeDto>> GetAll();
    }
}
