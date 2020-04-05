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
        public string Imagem { get; set; }
        public string Embalagem { get; set; }
        public DateTime DataEntrada { get; set; }
        public string TxtPesquisa { get; set; }
        //estoque
        public int Estoque { get; set; }

        public DadosProduto()
        {

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

        protected SqlCommand Comando = new SqlCommand();
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
                    Comando.CommandText = "CadastroProduto";
                    Comando.CommandType = CommandType.StoredProcedure;

                    SqlParameter parIdProduto = new SqlParameter();
                    parIdProduto.ParameterName = "@id_produto";
                    parIdProduto.SqlDbType = SqlDbType.Int;
                    parIdProduto.Value = Produto.IdProduto;
                    parIdProduto.Direction = ParameterDirection.Output;
                    Comando.Parameters.Add(parIdProduto);

                    Comando.Parameters.AddWithValue("@codigo", Produto.Codigo);
                    Comando.Parameters.AddWithValue("@ean", Produto.EAN);
                    Comando.Parameters.AddWithValue("@descricao", Produto.Descricao);
                    Comando.Parameters.AddWithValue("@preco", Produto.Preco);
                    Comando.Parameters.AddWithValue("@preco_promocional", Produto.PrecoPromocional);
                    Comando.Parameters.AddWithValue("@id_categoria", Produto.IdCategoria);
                    Comando.Parameters.AddWithValue("@imagem", Produto.Imagem);
                    Comando.Parameters.AddWithValue("@embalagem", Produto.Embalagem);
                    Comando.Parameters.AddWithValue("@estoque", Produto.Estoque);

                    rpta = Comando.ExecuteNonQuery() == 2 ? "OK" : "Erro ao inserir o registro (cadastro de produto)";

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
                Comando.CommandText = "UpdateProduto";
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@id_produto", Produto.IdProduto);
                Comando.Parameters.AddWithValue("@codigo", Produto.Codigo);
                Comando.Parameters.AddWithValue("@ean", Produto.EAN);
                Comando.Parameters.AddWithValue("@descricao", Produto.Descricao);
                Comando.Parameters.AddWithValue("@preco", Produto.Preco);
                Comando.Parameters.AddWithValue("@preco_promocional", Produto.PrecoPromocional);
                Comando.Parameters.AddWithValue("@id_categoria", Produto.IdCategoria);
                Comando.Parameters.AddWithValue("@image", Produto.Imagem);
                Comando.Parameters.AddWithValue("@embalagem", Produto.Embalagem);
                Comando.Parameters.AddWithValue("@estoque", Produto.Estoque);

                rpta = Comando.ExecuteNonQuery() == 2 ? "OK" : "Erro ao atualizar o produto";

                Comando.Parameters.Clear();
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
                    Comando.CommandText = "ListarProdutos";
                    Comando.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter SqlDat = new SqlDataAdapter(Comando);
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
                    Comando.CommandText = "PesquisaProduto";
                    Comando.CommandType = CommandType.StoredProcedure;

                    SqlParameter parPesquisaProduto = new SqlParameter();
                    parPesquisaProduto.ParameterName = "@search_text";
                    parPesquisaProduto.SqlDbType = SqlDbType.VarChar;
                    parPesquisaProduto.Size = 50;
                    parPesquisaProduto.Value = Produto.TxtPesquisa;
                    Comando.Parameters.Add(parPesquisaProduto);

                    SqlDataAdapter SqlDat = new SqlDataAdapter(Comando);
                    SqlDat.Fill(DtResultado);

                    Comando.Parameters.Clear();
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
                    Comando.CommandText = "SELECT codigo FROM tb_produto WHERE codigo = @codigo";
                    Comando.CommandType = CommandType.Text;

                    SqlParameter ParCode = new SqlParameter();
                    ParCode.ParameterName = "@codigo";
                    ParCode.Value = Produto.Codigo;
                    ParCode.SqlDbType = SqlDbType.VarChar;
                    ParCode.Size = 50;
                    Comando.Parameters.Add(ParCode);
                    var result = Comando.ExecuteScalar();
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
    }
}
