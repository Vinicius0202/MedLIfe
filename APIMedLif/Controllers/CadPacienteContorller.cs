using APLICATION.Interface;
using DOMAIN.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMedLif.Controllers
{
    public class CadPacienteContorller : Controller
    {

        private readonly ICadPacienteService _Service;
        public CadPacienteContorller(ICadPacienteService service)
        {
            _Service = service;
        }

        [HttpPost("/CadastrarPaciente")]
        public async Task<IActionResult> AdicionarCliente([FromBody] CadPaciente paciente)
        {
            await _Service.CadPaciente(paciente);
            return StatusCode(200);
        }
    }
}

