using Azure;
using BinaryActionsCalc.Data.Models;
using BinaryActionsCalc.Logic.DTOs.Requests;
using BinaryActionsCalc.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BinaryActionsCalc.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculateController : ControllerBase
{

    private readonly ILogger<CalculateController> _logger;
    private readonly ICalculationService _calculationService;

    public CalculateController(
        ILogger<CalculateController> logger,
        ICalculationService calculationService)
    {
        _logger = logger;
        _calculationService = calculationService;
    }

    [HttpPost()]
    public async Task<IActionResult> Execute([FromBody] CalculateReqDto request)
    {
        var result = await _calculationService.Calculate(request.Operation, request.Value1, request.Value2);
        return Ok(result);
    }
}
