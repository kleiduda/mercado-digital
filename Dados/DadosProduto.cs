using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dados
{
    public class DadosProduto
    {
        public int IdProduto { get; set; }
        public string Codigo { get; set; }
        public string EAN { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public decimal PrecoPromocional { get; set; }
        public int IdCategoria { get; set; }
        public string Imagem { get; set; }
        public string TxtPesquisa { get; set; }


        public DadosProduto()
        {

        }

        public DadosProduto(int idProduto, string codigo, string eAN, string descricao, decimal preco, decimal precoPromocional, int idCategoria, string imagem, string txtPesquisa)
        {
            IdProduto = idProduto;
            Codigo = codigo;
            EAN = eAN;
            Descricao = descricao;
            Preco = preco;
            PrecoPromocional = precoPromocional;
            IdCategoria = idCategoria;
            Imagem = imagem;
            TxtPesquisa = txtPesquisa;
            
        }

        protected Connection Con = new Connection();
        protected SqlCommand Comando = new SqlCommand();
        protected SqlDataReader dr;

        //inserir regsitro
        public string InsertRegister(DadosProduto Produto)
        {
            string resposta = "";
            try
            {
                Comando.Connection = Con.OpenConection();
                Comando.CommandText = "Insert into tb_produto (codigo, ean, descricao, preco, preco_promocional, id_categoria, image" +
                    ") VALUES (@codigo, @ean, @descricao, @preco, @preco_promocional, @id_categoria, @image)";
                Comando.CommandType = CommandType.Text;

                Comando.Parameters.AddWithValue("@codigo", Produto.Codigo);
                Comando.Parameters.AddWithValue("@ean", Produto.EAN);
                Comando.Parameters.AddWithValue("@descricao", Produto.Descricao);
                Comando.Parameters.AddWithValue("@preco", Produto.Preco);
                Comando.Parameters.AddWithValue("@preco_promocional", Produto.PrecoPromocional);
                Comando.Parameters.AddWithValue("@id_categoria", Produto.IdCategoria);
                Comando.Parameters.AddWithValue("@image", Produto.Imagem);

                resposta = Comando.ExecuteNonQuery() == 1 ? "OK" : "Erro ao inserir o registro (cadastro de produto)";
            }
            catch (Exception ex)
            {
                resposta = ex.Message;

            }
            finally
            {
                Con.ClosedConection();
            }
            return resposta;
        }
        //listando os produtos
        public DataTable ListarProdutos()
        {
            DataTable DtResult = new DataTable("produto");
            try
            {
                Comando.Connection = Con.OpenConection();
                Comando.CommandText = "Select * from tb_produto";
                Comando.CommandType = CommandType.Text;

                SqlDataAdapter SqlDat = new SqlDataAdapter(Comando);
                SqlDat.Fill(DtResult);

            }
            catch (Exception ex)
            {
                DtResult = null;
            }
            return DtResult;
        }
        //pesquisando
        public DataTable PesquisaProduto(DadosProduto Produto)
        {
            DataTable DtResultado = new DataTable("product");
            try
            {
                Comando.Connection = Con.OpenConection();
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
}
