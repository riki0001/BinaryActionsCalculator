using BinaryActionsCalc.Data.Enums;
using BinaryActionsCalc.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryActionsCalc.Logic.Services
{
    public class DateCalculationStrategy : ICalculationStrategy
    {
        public int MatchingOrder => 2;
        public ParameterType ParameterType => ParameterType.Date;

        public bool CanHandle(string val1, string val2)
        {
            //need to add support to additional date formats
            return DateTime.TryParse(val1, out DateTime _) && double.TryParse(val2, out double _);
        }

        public object Calc(OperationType operation, string val1, string val2)
        {
            DateTime.TryParse(val1, out DateTime parsedVal1);
            double.TryParse(val2, out double parsedVal2);

            switch (operation) {
                case OperationType.Add:
                    return parsedVal1.AddDays(parsedVal2);
                case OperationType.Subtract:
                    return parsedVal1.AddDays(parsedVal2 * -1);
                default:
                    throw new NotSupportedException($"Operation '{operation.ToString()}' is not allowed on date parameter");
            }      
        }
    }
}
