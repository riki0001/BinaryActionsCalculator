using BinaryActionsCalc.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryActionsCalc.Logic.Interfaces
{
    public interface ICalculationService
    {
        Task<object> Calculate(OperationType operation, string val1, string val2);
    }
}
