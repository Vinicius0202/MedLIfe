﻿using APLICATION.Interface;
using DOMAIN.Model;
using DOMAIN.Reposiroty;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APLICATION.Service
{
    public class ClienteService : IClineteService  
    {
        private readonly IClienteRpository _Repository;
        public ClienteService(IClienteRpository repository)
        {
            _Repository = repository;
        }
        public async Task AdicionarCLiente(CadCLiente login)
        {
            if (login != null && Validator.ValidarDocumento(login.Email))
            {
                await _Repository.AdicinarCliente(login);
           }
        }
    }
}
