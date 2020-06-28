using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Busines
{
    public class BPedidosCompra
    {
        public static string PedidoCompra_New(DateTime dataAbertura)
        {
            DadosPedidoCompra obj = new DadosPedidoCompra();
            obj.DataAbertura = dataAbertura;
            return obj.PedidoCompra_New(obj);
        }
        public static DataTable PedidoCompra_Lista()
        {
            return new DadosPedidoCompra().PedidoCompra_Lista();
        }
        public static DataTable PedidoCompra_ListaProdutos()
        {
            return new DadosPedidoCompra().PedidoCompra_ListarProdutos();
        }
        #region PEDIDO ITEM
        public static string PedidoCompra_AddItemPedido(int idPedidoCompra,  int idProduto, int qtd, string obsItem)
        {
            DadosPedidoCompra obj = new DadosPedidoCompra();
            obj.IDPedidoCompra = idPedidoCompra;
            obj.IDProduto = idProduto;
            obj.Qtd = qtd;
            obj.ObsItem = obsItem;
            return obj.PedidoCompra_AddItemPedido(obj);
        }
        public static DataTable PedidoCompra_ListarItem(int id)
        {
            DadosPedidoCompra obj = new DadosPedidoCompra();
            obj.IDPedidoCompra = id;
            return obj.PedidoCompra_ListarItem(obj);
        }
        public static DataTable PedidoCompra_PesquisaProduto(string pesquisa)
        {
            DadosPedidoCompra obj = new DadosPedidoCompra();
            obj.Pesquisa = pesquisa;
            return obj.PedidoCompra_PesquisaProduto(obj);
        }
        public static DataTable PedidoCompra_Info(int id)
        {
            DadosPedidoCompra obj = new DadosPedidoCompra();
            obj.IDPedidoCompra = id;
            return obj.PedidoCompra_Info(obj);
        }
        public static string PedidoCompra_Update(int id, int idFornecedor, int idVendedor, string obs, int idStatus)
        {
            DadosPedidoCompra obj = new DadosPedidoCompra();
            obj.IDPedidoCompra = id;
            obj.IDFornecedor = idFornecedor;
            obj.IDVendedor = idVendedor;
            obj.Obs = obs;
            obj.IdStatusVenda = idStatus;
            return obj.PedidoCompra_Update(obj);
        }
        public static DataTable PedidoCompra_DadosExcel(int id)
        {
            DadosPedidoCompra obj = new DadosPedidoCompra();
            obj.IDPedidoCompra = id;
            return obj.PedidoCompra_DadosExcel(obj);
        }
        #endregion
    }
}
