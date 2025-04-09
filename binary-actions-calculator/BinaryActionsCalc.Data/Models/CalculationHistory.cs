using BinaryActionsCalc.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryActionsCalc.Data.Models
{
    public class CalculationHistory: BaseEntity
    {
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public OperationType OperationId { get; set; }
        public string Result { get; set; }

        [ForeignKey(nameof(OperationId))]
        public int? Operation { get; set; }

    }
}
