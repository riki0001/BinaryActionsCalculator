using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BinaryActionsCalc.Data.Models;
using BinaryActionsCalc.Logic.DTOs;

namespace BinaryActionsCalc.Logic.Mapping
{
    public class ModelToEntity: Profile
    {
        public ModelToEntity()
        {
            CreateMap<OperationTypeDto, OperationTypes>();
        }
    }
}
