using BinaryActionsCalc.Data.Enums;
using BinaryActionsCalc.Data.Models;
using BinaryActionsCalc.Data.Repositories;
using BinaryActionsCalc.Logic.Interfaces;
using Microsoft.Extensions.Logging;

namespace BinaryActionsCalc.Logic.Services
{
    public class CalculationService : ICalculationService
    {
        private readonly List<ICalculationStrategy> _calcStrategies;
        private readonly IOperationsRepository _operationsRepository;
        private readonly ILogger<CalculationService> _logger;
        private Lazy<Dictionary<int, List<int>?>> _operationsDict;

        public CalculationService(
            IEnumerable<ICalculationStrategy> calcStrategies, 
            IOperationsRepository operationsRepository,
            ILogger<CalculationService> logger
            )
        {
            _calcStrategies = calcStrategies.OrderBy(s => s.MatchingOrder).ToList();
            _operationsRepository = operationsRepository;
            _logger = logger;

            _operationsDict = new Lazy<Dictionary<int, List<int>?>>(() => LoadOperationsParameterTypesDict());
        }

        private Dictionary<int, List<int>?> LoadOperationsParameterTypesDict()
        {
            _logger.LogInformation("Loading supported operations dictionary");
            return _operationsRepository.GetDict().Result;
        }

        public async Task<object?> Calculate(OperationType operation, string val1, string val2)
        {
            var strategy = _calcStrategies.OrderBy(s => s.MatchingOrder).FirstOrDefault(s => s.CanHandle(val1, val2) && IsSupporteOperation(operation, s.ParameterType));

            if (strategy == null)
            {
                throw new InvalidOperationException($"Operation '{operation.ToString()}' is not supported on parameters {val1} & {val2}");
            }
            
            var res = strategy.Calc(operation, val1, val2);
            await AddHistoryRecord(operation, val1, val2, res);

            return res;
        }

        private async Task AddHistoryRecord(OperationType operation, string val1, string val2, object res)
        {
            var record = new CalculationHistory() { Value1 = val1, Value2 = val2, OperationId = operation, Result = res.ToString() };
            _operationsRepository.Create(record);
            await _operationsRepository.SaveChangesAsync();
        }

        private bool IsSupporteOperation(OperationType operation, ParameterType parameterType)
        {
            if (!_operationsDict.Value.TryGetValue((int)operation, out var supportedParameterTypes))
                throw new InvalidOperationException($"Operation '{operation.ToString()}' is not supported");

            var supported =  supportedParameterTypes?.Contains((int)parameterType) == true;
            return supported;
        }
    }
}
