using DOMAIN.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APLICATION.Interface
{
   public interface IAgendarConsultaService
    {
        Task AgendarConsulta(AgendarConsulta consulta);
        Task CacelarConsulta(AgendarConsulta Cancelar);
        Task RemarcarCosulta(AgendarConsulta remarcar);

    }
}
