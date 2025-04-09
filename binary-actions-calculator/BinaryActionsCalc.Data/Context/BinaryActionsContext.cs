using BinaryActionsCalc.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryActionsCalc.Data.Context
{
    public class BinaryActionsContext : DbContext
    {
        public BinaryActionsContext()
        {
        }

        public BinaryActionsContext(DbContextOptions<BinaryActionsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ParameterTypes> ParameterTypes { get; set; }
        public virtual DbSet<OperationTypes> OperationTypes { get; set; }
        public virtual DbSet<CalculationHistory> CalculationHistory { get; set; }
        public virtual DbSet<ParameterTypeOperations> ParameterTypeOperations { get; set; }

    }
}