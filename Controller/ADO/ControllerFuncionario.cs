using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;
using ModelCantina;
namespace ControllerCantina.ADO{

    public class ControllerFuncionario 
    {
        /*
         Recebe como parâmetro um objeto da classe Funcionário e retorna um valor bool 
         * informando se as modificações foram realizadas com sucesso
         */
        public bool GravarFuncionario(Funcionario funcionario)
        {
            //Recupera a referência a conexão do banco de dados centralizada
            SqlConnection connection = ADODBConnection.Connection();
            //Abre a conexão com o banco de dados
            connection.Open();
            SqlCommand command = connection.CreateCommand();//Cria um comando a ser enviado ao banco de dados
            if (funcionario.IdFuncionario == 0) //Novo Funcionário
            {
                /*
                 Se for um novo funcionário realizaremos um insert
                 * a marção @nome e @matricula indicam que a SQL recebe parâmetros para execução da instrução
                 */
                command.CommandText = "insert into tbl_funcionario (nome_funcionario,matricula_funcionario) values(@nome,@matricula)";
                //Associamos os parâmetros na instrução SQL aos valores que estão no objeto da classe Funcionário
                command.Parameters.AddWithValue("@nome", funcionario.Nome);
                command.Parameters.AddWithValue("@matricula", funcionario.Matricula);
            }
            else
            {
                /*
                 Se o ID do funcionário for != 0 significa que precisamos atualizar os dados do funcionário
                 * através da instrução update, definindo os parâmetros necessários
                 * Observe que dessa vez precisamos do ID para ser usado na cláusula where do comando update
                 */
                command.CommandText = "update tbl_funcionario set nome_funcionario = @nome, matricula_funcionario=@matricula " +
            "where id_funcionario=@idfuncionario";
                //Associamos os parâmetros na instrução SQL aos valores que estão no objeto da classe Funcionário
                command.Parameters.AddWithValue("@idfuncionario", funcionario.IdFuncionario);
                command.Parameters.AddWithValue("@nome", funcionario.Nome);
                command.Parameters.AddWithValue("@matricula", funcionario.Matricula);
            }
            int linhasModificadas=command.ExecuteNonQuery();//executa o comando e retorna o número de linhas modificadas
            connection.Close();//Fecha a conexão com o banco de dados
            if (linhasModificadas == 0)//Se for 0 algum problema aconteceu e nenhum registro foi modifcado
                return false;
            else
                return true;
        }

        /*Recebe como parâmetro um objeto da classe Funcionário, mas funcionário também com 
         * um inteiro representando o id do funcionário*/
        public bool ExcluirFuncionario(Funcionario funcionario)
        {
            SqlConnection connection = ADODBConnection.Connection();
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            /*O comando agora é um delete que recebe como parâmetro o id do funcionário que será excluido*/
            command.CommandText = "delete from tbl_funcionario where id_funcionario=@idfuncionario";
            command.Parameters.AddWithValue("@idfuncionario", funcionario.IdFuncionario);
            int linhasModificadas=command.ExecuteNonQuery(); //Executa o comando e retorna o número de linhas modificadas
            connection.Close();
            if (linhasModificadas == 0)
                return false;
            else
                return true;
        }
        /*
         Busca os funcionario pelo nome. Se a variável nome for uma string vazia o comando retorna
         * todos os funcionários cadastrados armazenados em uma lista
         */
        public IList<Funcionario> BuscarFuncionarios(string nome)
        {
            SqlConnection connection=ADODBConnection.Connection();
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            /*
             O comando criado agora é um select. É fundamental colocar os campos em vez de usar *
             * já que a ordem das colunas vai ser necessária no momento de criação da lista
             */
            command.CommandText = "select id_funcionario,nome_funcionario,matricula_funcionario from tbl_funcionario";
            if (nome.Length != 0)//Se o nome for diferente de vazio, adiciona a cláusula where ao select
            {
                command.CommandText += " where nome like @nome";
                command.Parameters.AddWithValue("@nome", "%" + nome + "%");
            }
            Funcionario funcionario;
            /*Cria uma lista de funcionários vazias para armazenar os dados */
            IList<Funcionario> funcionarios = new List<Funcionario>();
            /*
                No bloco using criamos um objeto do tipo SqlDataReader que contém os registros retornados pela 
             * consulta SQL informada. O bloco using garante que o objeto reader será eliminado da memória após
             * a execução do código, tornando o gerenciamento de memória da aplicação mais eficiente
             */
            using (SqlDataReader reader = command.ExecuteReader())
            {
                //Enquanto tiver registro o laço é executado
                while (reader.Read())
                {
                    funcionario = new Funcionario();//Instancia um objeto da classe funcionario
                    funcionario.IdFuncionario = reader.GetInt32(0);//Captura a coluna de acordo com o tipo e a posição na consulta
                    funcionario.Nome = reader.GetString(1);
                    funcionario.Matricula = reader.GetString(2);
                    funcionarios.Add(funcionario);//adiciona o funcionário na lista
                }
            }
            connection.Close();//Fecha a conexão
            return funcionarios;//Retorna a lista de funcionários
        }
    }
}
