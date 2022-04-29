using APLICATION.Interface;
using DOMAIN.Model;
using DOMAIN.Reposiroty;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APLICATION.Service
{
    public class CadPacienteService : ICadPacienteService
    {

        private readonly ICadPacienteRepository _pacienteRepository;

        public CadPacienteService(ICadPacienteRepository paciente)
        {
            _pacienteRepository = paciente;
        }

        public async Task CadPaciente(CadPaciente paciente)
        {
             await _pacienteRepository.CadaPaciente(paciente);
        }
    }
}
