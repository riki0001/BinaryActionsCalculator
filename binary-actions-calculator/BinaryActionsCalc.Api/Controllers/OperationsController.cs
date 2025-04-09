using Azure;
using BinaryActionsCalc.Data.Models;
using BinaryActionsCalc.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BinaryActionsCalc.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class OperationController : ControllerBase
{
    private readonly IOperationService _operationService;
    private readonly ILogger<OperationController> _logger;

    public OperationController(
        IOperationService operationService,
        ILogger<OperationController> logger)
    {
        _operationService = operationService;
        _logger = logger;
    }

    [HttpGet("All")]
    public IActionResult GetAll()
    {
        var res = _operationService.GetAll();
        return Ok(res);
    }
}
