using BinaryActionsCalc.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryActionsCalc.Data.Models
{
    [Table("parameter_type_operations")]
    public class ParameterTypeOperations : BaseEntity
    {
        public ParameterTypes? ParameterTypes { get; set; }
    }
}
