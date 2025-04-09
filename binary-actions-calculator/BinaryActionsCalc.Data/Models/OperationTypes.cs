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
    [Table("operation_type")]
    public class OperationTypes : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        [MaxLength(50)]
        public string? Description { get; set; }

        public virtual ICollection<ParameterTypeOperations>? ParameterTypeToOperation { get; set; }

    }
}
