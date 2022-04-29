using DOMAIN.Model;
using DOMAIN.Reposiroty;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace INFRA.SQL.Repository
{
    public class CadPacienteRepository : ICadPacienteRepository
    {
        public Task CadaPaciente(CadPaciente paciente)
        {
            string query = $"INSERT INTO CadPaciente (Nome,Email,DataNascimento,Logradouro,Complemento,Numero,CEP,Bairro,UF,Cidade,CPF,RG) VALUES ('{paciente.Nome}','{paciente.Email}','{paciente.DataNascimento}','{paciente.Logradouro}','{paciente.Complemento}','{paciente.Numero}','{paciente.Cep}','{paciente.Bairro}','{paciente.UF}','{paciente.Cidade}','{paciente.CPF}','{paciente.RG}')";
            string conexao = @"DataSource=DESKTOP-TUV72H1\SQLEXPRESS;Initial Catalog=MedLIfe;Integrated Security = True";

            #region Conexão com o banco
            var con = new SqlConnection(conexao);

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);

                if (con.State == ConnectionState.Closed)
                    con.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            #endregion

            return null;
        }
    }
}
