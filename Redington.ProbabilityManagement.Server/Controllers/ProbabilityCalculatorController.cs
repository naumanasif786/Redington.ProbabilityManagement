using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Redington.ProbabilityManagement.Application.Enums;
using Redington.ProbabilityManagement.Application.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Redington.ProbabilityManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProbabilityCalculatorController(IMediator mediator) : ControllerBase
    {                 
        [HttpGet("Probability/{probabilityType}")]
        public async Task<IActionResult> Get(
           [FromRoute(Name = "probabilityType")] ProbabilityType probabilityType,
           [FromQuery(Name = "probabilityA")] double probabilityA,
           [FromQuery(Name = "probabilityB")] double probabilityB)
        {            
            var query = new Application.Queries.GetProbabilityQuery { ProbabilityA = probabilityA, ProbabilityB = probabilityB, ProbabilityType = probabilityType };
            
            IList<ValidationResult> results = [];
            var isValidQuery = 
                Validator.TryValidateObject(query, new ValidationContext(query, null, null), results, true);

            if (!isValidQuery)
            {
                return BadRequest(error: results);
            }

            return Ok(await mediator.Send(query));
        }
    }
}
