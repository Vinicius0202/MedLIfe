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
    public class AgendarConnsultaRepository : IAgendarConsultaRepository
    {
        public Task AgendarConsulta(AgendarConsulta agendar)
        {
            string query = $"INSERT INTO Agedamento (NomePaciente,Horario,Data,NomeMedico) VALUES ('{agendar.NomePaciente}','{agendar.Horario}','{agendar.Data}','{agendar.NomeMedico}')";
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

        public Task CacelarConsulta(AgendarConsulta Cancelar)
        {
            string query = $"DELETE FROM Agedamentos WHERE (NomePaciente,Horario,Data,NomeMedico) VALUES ('{Cancelar.NomePaciente}','{Cancelar.Horario}','{Cancelar.Data}','{Cancelar.NomeMedico}')";
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

        public Task RemarcarCosulta(AgendarConsulta remarcar)
        {
            string query = $"Upadate  Agedamentos WHERE (NomePaciente,Horario,Data,NomeMedico) VALUES ('{remarcar.NomePaciente}','{remarcar.Horario}','{remarcar.Data}','{remarcar.NomeMedico}')"; 
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
