using BinaryActionsCalc.Data.Enums;
using BinaryActionsCalc.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryActionsCalc.Logic.Services
{
    public class NumberCalculationStrategy : ICalculationStrategy
    {
        public int MatchingOrder => 1;
        public ParameterType ParameterType => ParameterType.Number;

        public bool CanHandle(string val1, string val2) =>
            double.TryParse(val1, out _) && double.TryParse(val2, out var _);


        public object Calc(OperationType operation, string val1, string val2)
        {
            double.TryParse(val1, out var parsedVal1);
            double.TryParse(val2, out var parsedVal2);
            switch (operation)
            {
                case OperationType.Add:
                    return parsedVal1 + parsedVal2;
                case OperationType.Subtract:
                    return parsedVal1 - parsedVal2;
                case OperationType.multiply:
                    return parsedVal1 * parsedVal2;
                case OperationType.divide:
                    return parsedVal1 / parsedVal2;
                default:
                    throw new NotSupportedException($"Operation '{operation.ToString()}' is not supported for parameters of type number");
            }
        }
    }
}
