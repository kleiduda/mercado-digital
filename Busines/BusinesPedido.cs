using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using System.Data;
using Supporte.Enums;


namespace Busines
{
    public class BusinesPedido
    {
        //cadastro nova compra
        public static string CadastroNovaCompra(int idCliente, int idVendedor, StatusPedido idStatusPedido, TipoEntrega idTipoEntrega, DateTime dataAbertura, int idCaixa)
        {
            DadosPedido obj = new DadosPedido();
            obj.IdCliente = idCliente;
            obj.IdVendedor = idVendedor;
            obj.IdStatusPedido = idStatusPedido;
            obj.IdTipoEntrega = idTipoEntrega;
            obj.DataAbertura = dataAbertura;
            obj.IdCaixa = idCaixa;

            return obj.CadastroNovaCompra(obj);
        }
        //listando dados do pedido
        public static DataTable DetalhePedido(int idVendedor)
        {
            DadosPedido obj = new DadosPedido();
            obj.IdVendedor = idVendedor;
            return obj.DetalhePedido(obj);
        }
        //inserindo item no pedido
        public static string InserirItemPedido(int idPedido, int idProduto, int quantidade, int estoqueQuantidade)
        {
            DadosPedido obj = new DadosPedido();
            obj.IdPedido = idPedido;
            obj.IdProduto = idProduto;
            obj.Quantidade = quantidade;
            obj.EstoqueQuantidade = estoqueQuantidade;
            return obj.InsertItemPedido(obj);
        }
        //listar itens do pedido
        public static DataTable ListarItemPedido(int idPedido)
        {
            DadosPedido obj = new DadosPedido();
            obj.IdPedido = idPedido;
            return obj.ListarItensPedido(obj);
        }
        //fechar compra
        public static string FecharCompra(int idPedido, TiposPagamento pagamento, StatusPedido idStatus)
        {
            DadosPedido obj = new DadosPedido();
            obj.IdPedido = idPedido;
            obj.Pagamento = pagamento;
            obj.IdStatusPedido = idStatus;
            //obj.IdCliente = idCliente;
            return obj.FecharCompra(obj);
        }
        //verificar compras abertas
        public static DataTable VerificarComprasAbertas(int idVendedor, int idCaixa)
        {
            DadosPedido obj = new DadosPedido();
            obj.IdVendedor = idVendedor;
            obj.IdCaixa = idCaixa;
            return obj.VerificarComprasAbertas(obj);
        }
    }

}
