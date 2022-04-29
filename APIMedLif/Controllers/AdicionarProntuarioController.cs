using APLICATION.Interface;
using DOMAIN.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMedLif.Controllers
{
    public class AdicionarProntuarioController : Controller
    {
        private readonly IAddProntuarioService _Service;
        public AdicionarProntuarioController(IAddProntuarioService service)
        {
            _Service = service;
        }

        [HttpPost("/AdicionarPronturario")]
        public async Task<IActionResult> AdicionarCliente([FromBody] AdicionarProntuario paciente)
        {
            await _Service.AddProntuario(paciente);
            return StatusCode(200);
        }
        [HttpGet("/ConsultarPaciente")]
        public async Task<IActionResult> ConsultarCliente([FromBody] AdicionarProntuario paciente)
        {
            await _Service.ConsultaProntuario(paciente);
            return StatusCode(200);
        }

    }
}
