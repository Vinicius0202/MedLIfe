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

        private static bool ValidarCPF(string login)
        {

            if (string.IsNullOrEmpty(login)) throw new Exception("Email incorreto");

            return true;

        }

    }
}
