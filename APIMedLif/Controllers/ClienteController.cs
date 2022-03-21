using APLICATION.Interface;
using DOMAIN.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMedLif.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClineteService _Service;
        public ClienteController(IClineteService service)
        {
            _Service = service;
        }

        [HttpPost("/CadastrarCliente")] 
        public async Task<IActionResult> AdicionarCliente([FromBody] CLienteModel cliente)
        {
            await _Service.AdicionarCLiente(cliente);
            return StatusCode(200);
        }


    }
}
