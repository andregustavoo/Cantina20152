using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using ControllerCantina.Interfaces;
using System.Configuration;
using ModelCantina;
namespace ControllerCantina.ADO{

    public class ControllerFuncionarioADO : IControllerFuncionario 
    {

        public bool GravarFuncionario(Funcionario funcionario)
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["ConexadoADO"].ConnectionString;
            SqlConnection connection = ADODBConnection.Connection();
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "insert into tbl_funcionario (nome_funcionario,matricula_funcionario) values(@nome,@matricula)";
            command.Parameters.AddWithValue("@nome", funcionario.Nome);
            command.Parameters.AddWithValue("@matricula", funcionario.Matricula);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
            
        }

        public bool AtualizarFuncionario(ModelCantina.Funcionario funcionario)
        {
            SqlConnection connection = ADODBConnection.Connection();
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "update tbl_funcionario set nome_funcionario = @nome, matricula_funcionario=@matricula " +
            "where id_funcionario=@idfuncionario";
            command.Parameters.AddWithValue("@idfuncionario", funcionario.IdFuncionario);
            command.Parameters.AddWithValue("@nome", funcionario.Nome);
            command.Parameters.AddWithValue("@matricula", funcionario.Matricula);
            int nRows = command.ExecuteNonQuery();
            connection.Close();
            if (nRows == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool ExcluirFuncionario(ModelCantina.Funcionario funcionario)
        {
            SqlConnection connection = ADODBConnection.Connection();
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "delete from tbl_funcionario where id_funcionario=@idfuncionario";
            command.Parameters.AddWithValue("@idfuncionario", funcionario.IdFuncionario);
            int nRows=command.ExecuteNonQuery();
            connection.Close();
            if (nRows == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public IList<ModelCantina.Funcionario> BuscarFuncionarios(string criterios)
        {
            SqlConnection connection=ADODBConnection.Connection();
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select id_funcionario,nome_funcionario,matricula_funcionario from tbl_funcionario";
            Funcionario funcionario;
            IList<Funcionario> funcionarios = new List<Funcionario>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    funcionario = new Funcionario();
                    funcionario.IdFuncionario = reader.GetInt32(0);
                    funcionario.Nome = reader.GetString(1);
                    funcionario.Matricula = reader.GetString(2);
                    funcionarios.Add(funcionario);
                }
            }
            connection.Close();
            return funcionarios;
        }

        public ModelCantina.Funcionario LocalizarFuncionarioPorID(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
