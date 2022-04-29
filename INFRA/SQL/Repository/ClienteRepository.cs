using DOMAIN.Model;
using DOMAIN.Reposiroty;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace INFRA.SQL.Repository
{
    public class ClienteRepository : IClienteRpository
    {
        public Task AdicinarCliente(CadCLiente loginn)
        {

            string query = $"INSERT INTO Login (Email,Senha) VALUES ('{loginn.Email}','{loginn.Senha}')";
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

