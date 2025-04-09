using BinaryActionsCalc.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryActionsCalc.Logic.Interfaces
{
    public interface ICalculationStrategy
    {
        public int MatchingOrder { get; }
        public ParameterType ParameterType { get; }
        public bool CanHandle(string val1, string val2);
        public object Calc(OperationType operation, string val1, string val2);
    }
}
