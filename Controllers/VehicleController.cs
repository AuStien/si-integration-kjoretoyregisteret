using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTR.Data;
using KTR.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KTR.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("vehicle")]
    public class VehicleController : ControllerBase
    {

        private readonly VehicleData data = new VehicleData();

        /// <summary>
        /// Get information about a vehicle
        /// </summary>
        /// <param name="skiltnummer"></param>
        /// <returns>Somethinf</returns>
        /// <response code="200">Returns the newly created item</response>
        /// <response code="400">If the item is null</response> 
        [HttpGet("description/{skiltnummer}")]
        public ActionResult<OutData> GetDescription(string skiltnummer)
        {
            OutData outData = data.getCarDescription(skiltnummer);
            if (outData == null)
            {
                if (data.hasAPIKey)
                    return StatusCode(500);
                else
                    return StatusCode(500, "Missing environment key 'KjoretoyRegisterApiNokkel'");
            }
            else return Ok(outData);
        }
    }
}
