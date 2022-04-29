using DOMAIN.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Reposiroty
{
    public interface IAgendarConsultaRepository
    {
        Task AgendarConsulta(AgendarConsulta agendar);
        Task CacelarConsulta(AgendarConsulta Cancelar);
        Task RemarcarCosulta(AgendarConsulta remarcar);
    }
}
