using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Busines
{
   public class BusinesProduto
    {
        public string InsertRegister(string codigo, string ean, string descricao, decimal preco, decimal precoPromocional, int idCategoria, string image)
        {
            DadosProduto obj = new DadosProduto();
            obj.Codigo = codigo;
            obj.EAN = ean;
            obj.Descricao = descricao;
            obj.Preco = preco;
            obj.PrecoPromocional = precoPromocional;
            obj.IdCategoria = idCategoria;
            obj.Imagem = image;

            return obj.InsertRegister(obj);
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
    }
}
