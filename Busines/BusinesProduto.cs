using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Supporte;

namespace Busines
{
   public class BusinesProduto
    {
        public static string InsertRegister(string codigo, string ean, string descricao,decimal precoCusto, decimal preco, decimal precoPromocional, int idCategoria, string image, string embalagem, int estoque)
        {
            DadosProduto obj = new DadosProduto();
            obj.Codigo = codigo;
            obj.EAN = ean;
            obj.Descricao = descricao;
            obj.PrecoCusto = precoCusto;
            obj.Preco = preco;
            obj.PrecoPromocional = precoPromocional;
            obj.IdCategoria = idCategoria;
            obj.Imagem = image;
            obj.Embalagem = embalagem;
            obj.Estoque = estoque;

            return obj.InsertRegister(obj);
        }
        //editando o produto
        public static string Editar(int idProduto, string codigo, string ean, string descricao,decimal precoCusto, decimal preco, decimal precoPromocional, int idcategoria, string imagem, string embalagem, int estoque)
        {
            DadosProduto obj = new DadosProduto();
            obj.IdProduto = idProduto;
            obj.Codigo = codigo;
            obj.EAN = ean;
            obj.Descricao = descricao;
            obj.PrecoCusto = precoCusto;
            obj.Preco = preco;
            obj.PrecoPromocional = precoPromocional;
            obj.IdCategoria = idcategoria;
            obj.Imagem = imagem;
            obj.Embalagem = embalagem;
            obj.Estoque = estoque;

            return obj.Editar(obj);

        }
        //listando os produtos
        public static DataTable ListarProdutos()
        {
            return new DadosProduto().ListarProdutos(); 
        }
        //pesquisa
        public static DataTable PesquisaProduto(string searchText)
        {
            DadosProduto obj = new DadosProduto();
            obj.TxtPesquisa = searchText;
            return obj.PesquisaProduto(obj);
        }
        //verificando se o produto ja esta cadastrado
        public static bool ValidaProduto(string codigo)
        {
            DadosProduto obj = new DadosProduto();
            obj.Codigo = codigo;

            return obj.Validate(obj);

        }
        //CATEGORIAS
        //listando as categorias
        public static DataTable ListarCategorias()
        {
            return new DadosProduto().ListarCategorias();
        }
        //cadastro da categoria
        public static string CadastroCategoria(string nomeCategoria)
        {
            DadosProduto obj = new DadosProduto();
            obj.NomeCategoria = nomeCategoria;
            return obj.CadastroCategoria(obj);
        }
        //valida categoria
        public static bool ValidaCategoria(string nomeCategoria)
        {
            DadosProduto obj = new DadosProduto();
            obj.NomeCategoria = nomeCategoria;
            return obj.ValidarCategoria(obj);
        }
        #region Busines Administrador
        public static DataTable ProdutosMaisVendidos()
        {
            return new DadosProduto().ProdutosMaisVendidos();
        }
        //com lista
        public static List<DadosProduto> ProdutosVendidos()
        {
            return new DadosProduto().GetProdutos();
        }
        //list
        public static List<Vendas> CarregaDadosComDataReader()
        {
            return new DadosProduto().CarregaDadosDataReader();
        }
        //collection
        public static Collection<Vendas> CarregaDadosComDataTable()
        {
            return new DadosProduto().CarregaDadosDataTable();
        }

        
        #endregion
    }
}
