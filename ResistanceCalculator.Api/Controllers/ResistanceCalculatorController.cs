using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ResistanceCalculator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResistanceCalculatorController : ControllerBase
    {
        private readonly IResistanceCalculator _calculator;
        public ResistanceCalculatorController(IResistanceCalculator calculator)
        {
            this._calculator = calculator;
        }

        /// <summary>
        /// Calculates the minimum and Maximum resistance value for the input request.
        /// </summary>
        /// <param name="request">A <see cref="CalculateResistanceRequest"/> the represents the input.</param>
        /// <returns>A <see cref="CalculateResistanceResponse"/> with the minimum and maximum resitance values.</returns>
        [HttpPost("CalculateResistance")]
        public ActionResult<CalculateResistanceResponse> CalculateResistance([FromBody] CalculateResistanceRequest request)
        {
            try
            {
                if (request == null)
                {
                    throw new ArgumentNullException("Request cannot be null");
                }

                if (string.IsNullOrWhiteSpace(request.BandAColor) || string.IsNullOrWhiteSpace(request.BandBColor) || string.IsNullOrWhiteSpace(request.BandCColor) || string.IsNullOrWhiteSpace(request.BandDColor))
                {
                    throw new ArgumentException("Either BandAColor or BandBColor or BandCColor or BandDColor is not provided.");
                }

                var resistanceResponse = this._calculator.CalculateOhmValue(request.BandAColor, request.BandBColor, request.BandCColor, request.BandDColor);

                return Ok(resistanceResponse);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.StackTrace);
            }
        }

        
    }
}
