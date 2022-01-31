using Microsoft.AspNetCore.Mvc;
using Evaluation.Server.Services;
using Evaluation.Shared;

namespace Evaluation.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MaritimeConversionController : ControllerBase
    {
        private readonly ILogger<MaritimeConversionController> logger;
        private IMaritimeConverterService maritimeConverterService { get; set; }

        public MaritimeConversionController(ILogger<MaritimeConversionController> logger, IMaritimeConverterService maritimeConverterService)
        {
            this.logger = logger;
            this.maritimeConverterService = maritimeConverterService;
        }

        [HttpGet("ConvertKnotsToKmh/{knots}")]
        public async Task<ActionResult> ConvertKnotsToKmh(double knots)
        {
            try
            {
                var res = await maritimeConverterService.ConvertKnotsToKmh(knots);
                
                return Ok(res);
            }
            catch (Exception ex)
            {
                logger.LogError($"Error in MaritimeConversionController.ConvertKnotsToKmh(): {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("CalculateCollitionTime/{kmh1}/{kmh2}/{distance}")]
        public async Task<ActionResult> CalculateCollitionTime(double kmh1, double kmh2, int distance)
        {
            try
            {
                var res = await Task.FromResult(0);  //Erstatt med kall mot service
                return Ok(res);
            }
            catch (Exception ex)
            {
                logger.LogError($"Error in MaritimeConversionController.CalculateCollitionTime(): {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


    }
}
