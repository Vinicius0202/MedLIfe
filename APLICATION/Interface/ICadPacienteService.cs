using DOMAIN.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APLICATION.Interface
{
   public interface ICadPacienteService
    {

        Task CadPaciente(CadPaciente paciente); 
    
    }
}
