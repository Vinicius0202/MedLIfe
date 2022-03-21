using DOMAIN.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace APLICATION.Interface
{
    public class Validator
    {

        public static bool ValidarDocumento(string documento)
        {
            return ValidarCPF(documento); 
        }

        private static bool ValidarCPF(string cpf)
        {
            if (string.IsNullOrEmpty(cpf) && cpf.Length > 14) throw new Exception("Tamnho do documneto Permetido é de 14 caracteres " + cpf.Length); 
            
            return true;

        }

    }
}
