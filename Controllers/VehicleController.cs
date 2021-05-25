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
    [ApiController]
    [Route("vehicle")]
    public class VehicleController : ControllerBase
    {

        private readonly VehicleData data = new VehicleData();

        [HttpGet("{skiltnummer}")]
        public KjoretoyRoot Get(string skiltnummer)
        {
            return data.getVehicleByRegisterPlate(skiltnummer);
        }

        [HttpGet("description/{skiltnummer}")]
        public IActionResult GetDescription(string skiltnummer)
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
