using APLICATION.Interface;
using DOMAIN.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMedLif.Controllers
{
    public class AgedarCosultaCotoroller : Controller
    {

        private readonly IAgendarConsultaService _Service;
        public AgedarCosultaCotoroller(IAgendarConsultaService service)
        {
            _Service = service;
        }

        [HttpPost("/AgendarConsulta")]
        public async Task<IActionResult> AgendarCosulta([FromBody] AgendarConsulta consulta)
        {
            await _Service.AgendarConsulta(consulta);
            return StatusCode(200);
        }
        [HttpGet("/RemarcarConsulta")]
        public async Task<IActionResult> RemarcarCaonsulta([FromBody] AgendarConsulta consulta)
        {
            await _Service.AgendarConsulta(consulta);
            return StatusCode(200);
        }
        [HttpDelete("/CacelarConsulta")]
        public async Task<IActionResult> CacelarConsulta([FromBody] AgendarConsulta consulta)
        {
            await _Service.AgendarConsulta(consulta);
            return StatusCode(200);


        }
    }
}