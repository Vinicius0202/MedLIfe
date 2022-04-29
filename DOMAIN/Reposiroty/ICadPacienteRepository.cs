using DOMAIN.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Reposiroty
{
   public interface ICadPacienteRepository
    {

        Task CadaPaciente(CadPaciente paciente);
    
    }
}
