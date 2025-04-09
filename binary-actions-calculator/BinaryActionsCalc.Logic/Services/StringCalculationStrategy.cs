using BinaryActionsCalc.Data.Enums;
using BinaryActionsCalc.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryActionsCalc.Logic.Services
{
    public class StringCalculationStrategy : ICalculationStrategy
    {
        public int MatchingOrder { get => 100; }

        public ParameterType ParameterType => ParameterType.String;

        public bool CanHandle(string val1, string val2) => true;

        public object Calc(OperationType operation, string val1, string val2)
        {
            switch (operation)
            {
                case OperationType.Add:
                case OperationType.concat:
                    return val1 + val2;
                default:
                    throw new NotSupportedException($"Operation '{operation.ToString()}' is not supported on parameters of type string");
            }
        }
    }
}
