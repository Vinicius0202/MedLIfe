using DOMAIN.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APLICATION.Interface
{
    public interface IAddProntuarioService
    {
        Task AddProntuario(AdicionarProntuario prontuario);

        Task ConsultaProntuario(AdicionarProntuario paciente);
    
    }
}
