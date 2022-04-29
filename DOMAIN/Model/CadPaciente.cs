using System;
using System.Collections.Generic;
using System.Text;

namespace DOMAIN.Model
{
   public class CadPaciente
    {

        public string Nome { get; set; }
        public string Email { get; set; }
        public int DataNascimento { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public int Numero { get; set; }
        public int Cep { get; set; }
        public string Bairro { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public int CPF { get; set; }
        public int RG { get; set; }
    }
}
