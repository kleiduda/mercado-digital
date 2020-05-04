using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace Dados
{
    public class DadosProduto : Connection
    {
        public int IdProduto { get; set; }
        public string Codigo { get; set; }
        public string EAN { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public decimal PrecoPromocional { get; set; }
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public string Imagem { get; set; }
        public string Embalagem { get; set; }
        public DateTime DataEntrada { get; set; }
        public string TxtPesquisa { get; set; }
        //estoque
        public int Estoque { get; set; }
        //categoria

        public DadosProduto()
        {

        }

        public DadosProduto(int idCategoria, string nomeCategoria)
        {
            IdCategoria = idCategoria;
            NomeCategoria = nomeCategoria;
        }
        public DadosProduto(string nomeCategoria)
        {
            NomeCategoria = nomeCategoria;
        }
        public DadosProduto(int idProduto, string codigo, string eAN, string descricao, decimal preco, decimal precoPromocional,
            int idCategoria, string imagem, string embalagem, DateTime dataEntrada, string txtPesquisa, int estoque)
        {
            IdProduto = idProduto;
            Codigo = codigo;
            EAN = eAN;
            Descricao = descricao;
            Preco = preco;
            PrecoPromocional = precoPromocional;
            IdCategoria = idCategoria;
            Imagem = imagem;
            Embalagem = embalagem;
            DataEntrada = dataEntrada;
            TxtPesquisa = txtPesquisa;
            //estoque
            Estoque = estoque;

        }

        protected SqlCommand command = new SqlCommand();
        protected SqlDataReader dr;

        //inserir regsitro
        public string InsertRegister(DadosProduto Produto)
        {
            string rpta = "";
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "CadastroProduto";
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter parIdProduto = new SqlParameter();
                    parIdProduto.ParameterName = "@id_produto";
                    parIdProduto.SqlDbType = SqlDbType.Int;
                    parIdProduto.Value = Produto.IdProduto;
                    parIdProduto.Direction = ParameterDirection.Output;
                    command.Parameters.Add(parIdProduto);

                    command.Parameters.AddWithValue("@codigo", Produto.Codigo);
                    command.Parameters.AddWithValue("@ean", Produto.EAN);
                    command.Parameters.AddWithValue("@descricao", Produto.Descricao);
                    command.Parameters.AddWithValue("@preco", Produto.Preco);
                    command.Parameters.AddWithValue("@preco_promocional", Produto.PrecoPromocional);
                    command.Parameters.AddWithValue("@id_categoria", Produto.IdCategoria);
                    command.Parameters.AddWithValue("@imagem", Produto.Imagem);
                    command.Parameters.AddWithValue("@embalagem", Produto.Embalagem);
                    command.Parameters.AddWithValue("@estoque", Produto.Estoque);

                    rpta = command.ExecuteNonQuery() == 2 ? "OK" : "Erro ao inserir o registro (cadastro de produto)";

                }
                catch (Exception ex)
                {
                    rpta = ex.Message;

                }
            }


            return rpta;
        }
        //Editar o Produto
        public string Editar(DadosProduto Produto)
        {
            string rpta = "";
            var connection = GetConnection();
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UpdateProduto";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id_produto", Produto.IdProduto);
                command.Parameters.AddWithValue("@codigo", Produto.Codigo);
                command.Parameters.AddWithValue("@ean", Produto.EAN);
                command.Parameters.AddWithValue("@descricao", Produto.Descricao);
                command.Parameters.AddWithValue("@preco", Produto.Preco);
                command.Parameters.AddWithValue("@preco_promocional", Produto.PrecoPromocional);
                command.Parameters.AddWithValue("@id_categoria", Produto.IdCategoria);
                command.Parameters.AddWithValue("@image", Produto.Imagem);
                command.Parameters.AddWithValue("@embalagem", Produto.Embalagem);
                command.Parameters.AddWithValue("@estoque", Produto.Estoque);

                rpta = command.ExecuteNonQuery() == 2 ? "OK" : "Erro ao atualizar o produto";

                command.Parameters.Clear();
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            return rpta;
        }
        //listando os produtos
        public DataTable ListarProdutos()
        {
            DataTable DtResult = new DataTable("produto");

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "ListarProdutos";
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter SqlDat = new SqlDataAdapter(command);
                    SqlDat.Fill(DtResult);

                }
                catch (Exception ex)
                {
                    DtResult = null;
                }
                return DtResult;
            }

        }
        //pesquisando
        public DataTable PesquisaProduto(DadosProduto Produto)
        {
            DataTable DtResultado = new DataTable("product");
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "PesquisaProduto";
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter parPesquisaProduto = new SqlParameter();
                    parPesquisaProduto.ParameterName = "@search_text";
                    parPesquisaProduto.SqlDbType = SqlDbType.VarChar;
                    parPesquisaProduto.Size = 50;
                    parPesquisaProduto.Value = Produto.TxtPesquisa;
                    command.Parameters.Add(parPesquisaProduto);

                    SqlDataAdapter SqlDat = new SqlDataAdapter(command);
                    SqlDat.Fill(DtResultado);

                    command.Parameters.Clear();
                }
                catch (Exception ex)
                {
                    DtResultado = null;
                }
                return DtResultado;
            }

        }
        //verificando se o produto ja esta cadastrado
        public bool Validate(DadosProduto Produto)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT codigo FROM tb_produto WHERE codigo = @codigo";
                    command.CommandType = CommandType.Text;

                    SqlParameter ParCode = new SqlParameter();
                    ParCode.ParameterName = "@codigo";
                    ParCode.Value = Produto.Codigo;
                    ParCode.SqlDbType = SqlDbType.VarChar;
                    ParCode.Size = 50;
                    command.Parameters.Add(ParCode);
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {

                }
                return false;
            }
        }
        //CATEGORIAS
        //listar categorias
        public DataTable ListarCategorias()
        {
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_categoria ORDER BY id_categoria DESC";
                    command.CommandType = CommandType.Text;
                    SqlDataAdapter SqlDat = new SqlDataAdapter(command);
                    SqlDat.Fill(dt);
                }
                catch (Exception ex)
                {
                    dt = null;
                }
                return dt;
            }
        }
        //cadastro de categoria
        public string CadastroCategoria(DadosProduto Categoria)
        {
            string rpta = "";
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT into tb_categoria (nome_categoria) values (@nome_categoria)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@nome_categoria", Categoria.NomeCategoria);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao cadastrar categoria";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        //verificar se ja existe um cadsatro de categoria no banco
        public bool ValidarCategoria(DadosProduto Categoria)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_categoria where nome_categoria=@nome_categoria";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@nome_categoria", Categoria.NomeCategoria);
                    var result = command.ExecuteScalar();
                    if (result !=null)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {

                }
                return false;
            }
        }
        #region Dados Administrador
        public DataTable ProdutosMaisVendidos()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "select pr.codigo, pr.descricao, i.quantidade, i.preco, SUM(i.quantidade*i.preco) as Total from tb_pedido_item i INNER JOIN tb_produto pr ON i.id_produto=pr.id_produto GROUP BY pr.codigo, pr.descricao, i.quantidade, i.preco";
                    command.CommandType = CommandType.Text;
                    SqlDataAdapter SqlDat = new SqlDataAdapter(command);
                    SqlDat.Fill(dt);
                }
                catch (Exception ex)
                {
                    dt = null;
                }
                return dt;
            }
        }

        #endregion
    }

}
