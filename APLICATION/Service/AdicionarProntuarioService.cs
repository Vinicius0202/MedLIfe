using APLICATION.Interface;
using DOMAIN.Model;
using DOMAIN.Reposiroty;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APLICATION.Service
{
     public class AdicionarProntuarioService: IAddProntuarioService
    {
        private readonly IAddProntuarioRepository _repositorio;

        public AdicionarProntuarioService(IAddProntuarioRepository repository)
        {
            _repositorio = repository;
        }

        public async Task AddProntuario(AdicionarProntuario prontuario)
        {

            await _repositorio.AdicionarProntuario(prontuario);
        }

        public async Task ConsultaProntuario(AdicionarProntuario paciente)
        {

            await _repositorio.ConsultarProntuario(paciente);

        }


    }
}
