using DOMAIN.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APLICATION.Interface
{
     public interface IClineteService
    {
        Task AdicionarCLiente(CadCLiente login);

    }
}
