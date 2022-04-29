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
    public class AddProntuarioRepository : IAddProntuarioRepository
    {
        public Task AdicionarProntuario(AdicionarProntuario prontuario)
        {
            string query = $"INSERT INTO AcionarProntuario (Nome,Idade,Convenio,Descricao) VALUES ('{prontuario.Nome}','{prontuario.Idade}','{prontuario.Convenio}','{prontuario.Descricao})";
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

        public Task ConsultarProntuario(AdicionarProntuario paciente)
        {
            string query = "select Nome From AdicionarProntuario";
            string conexao = @"Data Source=DESKTOP-MLMAGM2\SQLEXPRESS;Initial Catalog=teste1;Integrated Security=True";

            var con = new SqlConnection(conexao);
            List<AdicionarProntuario> list = new List<AdicionarProntuario>();

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);

                if (con.State == ConnectionState.Closed)
                    con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new AdicionarProntuario()
                        {
                            Nome = reader["Nome"].ToString(),
                           
                        }
                          ); ;
                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }

            return null;
        }
    }
}
