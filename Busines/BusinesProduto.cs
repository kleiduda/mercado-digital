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
        public static string Produto_Cadastro(string codigo, string ean, string descricao,decimal precoCusto, decimal preco, decimal precoPromocional, 
            int idCategoria, string image, string embalagem, int estoque, string tipoEmbalagem = null, int qtdEmbalagem = 0, decimal precoUnidade = 0, 
            decimal metroCubico = 0, string medida = "0")
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
            obj.TipoEmbalagem = tipoEmbalagem;
            obj.QtdEmbalagem = qtdEmbalagem;
            obj.PrecoUnidade = precoUnidade;
            obj.MetroCubico = metroCubico;
            obj.Estoque = estoque;
            obj.Medida = medida;

            return obj.InsertRegister(obj);
        }
        //editando o produto
        public static string Produto_Update(int idProduto, string codigo, string ean, string descricao, decimal precoCusto, decimal preco, decimal precoPromocional,
            int idCategoria, string image, string embalagem, int estoque, string tipoEmbalagem = null, int qtdEmbalagem = 0, decimal precoUnidade = 0,
            decimal metroCubico = 0, string medida = "0")
        {
            DadosProduto obj = new DadosProduto();
            obj.IdProduto = idProduto;
            obj.Codigo = codigo;
            obj.EAN = ean;
            obj.Descricao = descricao;
            obj.PrecoCusto = precoCusto;
            obj.Preco = preco;
            obj.PrecoPromocional = precoPromocional;
            obj.IdCategoria = idCategoria;
            obj.Imagem = image;
            obj.Embalagem = embalagem;
            obj.TipoEmbalagem = tipoEmbalagem;
            obj.QtdEmbalagem = qtdEmbalagem;
            obj.PrecoUnidade = precoUnidade;
            obj.MetroCubico = metroCubico;
            obj.Estoque = estoque;
            obj.Medida = medida;

            return obj.Editar(obj);

        }
        //listando os produtos
        public static DataTable ListarProdutos()
        {
            return new DadosProduto().ListarProdutos(); 
        }
        public static DataTable Produto_ListaPorId(int id)
        {
            DadosProduto obj = new DadosProduto();
            obj.IdProduto = id;
            return obj.Produto_ListaPorID(obj);
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
