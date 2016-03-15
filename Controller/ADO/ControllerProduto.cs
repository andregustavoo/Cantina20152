using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using ModelCantina;
using System.Threading.Tasks;

namespace ControllerCantina.ADO
{
    public class ControllerProduto
    {
        public List<Produto> BuscarProduto(string descricao)
        {
            SqlConnection conexao = ADODBConnection.Connection();
            conexao.Open();
            SqlCommand command = conexao.CreateCommand();
            command.CommandText = "select id_produto,descricao_produto,preco_unitario from tbl_produto order by descricao_produto";
            Produto p;
            List<Produto> listaProdutos = new List<Produto>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    p = new Produto();
                    p.IdProduto = reader.GetInt32(0);
                    p.Descricao = reader.GetString(1);
                    p.PrecoUnitario = reader.GetSqlMoney(2).ToDouble();
                    listaProdutos.Add(p);
                }
            }
            conexao.Close();
            return listaProdutos;
        }
    }
}
