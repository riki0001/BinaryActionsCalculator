using BinaryActionsCalc.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryActionsCalc.Logic.DTOs.Requests
{
    public class CalculateReqDto
    {
        public OperationType Operation { get; set; }
        public string Value1 { get; set; } = string.Empty;
        public string Value2 { get; set; } = string.Empty;
    }
}
