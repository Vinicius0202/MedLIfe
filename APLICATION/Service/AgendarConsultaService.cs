using APLICATION.Interface;
using DOMAIN.Model;
using DOMAIN.Reposiroty;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APLICATION.Service
{
    public class AgendarConsultaService : IAgendarConsultaService
    {
        private readonly IAgendarConsultaRepository _repository;

        public AgendarConsultaService(IAgendarConsultaRepository repository)
        {
            _repository = repository;
        }

        public async Task AgendarConsulta(AgendarConsulta consulta)
        {
            await _repository.AgendarConsulta(consulta);
        }

        public async Task CacelarConsulta(AgendarConsulta Cancelar)
        {
            await _repository.CacelarConsulta(Cancelar);
        }

        public async Task RemarcarCosulta(AgendarConsulta remarcar)
        {
            await _repository.RemarcarCosulta(remarcar);
        }
    }

}
