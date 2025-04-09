using AutoMapper;
using BinaryActionsCalc.Data.Enums;
using BinaryActionsCalc.Data.Repositories;
using BinaryActionsCalc.Logic.DTOs;
using BinaryActionsCalc.Logic.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryActionsCalc.Logic.Services
{
    public class OperationService : IOperationService
    {
        private readonly IOperationsRepository _operationsRepository;
        private readonly ILogger<OperationService> _logger;
        private readonly IMapper _mapper;

        public OperationService(
            IOperationsRepository operationsRepository,
            ILogger<OperationService> logger,
            IMapper mapper
            )
        {
            _operationsRepository = operationsRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OperationTypeDto>> GetAll()
        {
            var types = await _operationsRepository.GetAll();
            var mapped = _mapper.Map<IEnumerable<OperationTypeDto>>( types );

            return mapped;
        }
    }
}
