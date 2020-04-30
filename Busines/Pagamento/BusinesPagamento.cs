using System.Data;
using Dados.Pagamento;
using Supporte.Enums;

namespace Busines.Pagamento
{
   public class BusinesPagamento
    {
		public static string CadastroPedidoPagamento(TiposPagamento idPagamento, int idPedido, decimal valorRecebido, decimal troco)
		{
			DadosPagamento obj = new DadosPagamento();
			obj.IdPagamento = idPagamento;
			obj.IdPedido = idPedido;
			obj.ValorRecebido = valorRecebido;
			obj.Troco = troco;
			return obj.CadastroPedidoPagamento(obj);
		}
		public static DataTable ListarPedidoPagamento(int idPedido)
		{
			DadosPagamento obj = new DadosPagamento();
			obj.IdPedido = idPedido;
			return obj.ListarPedidoPagamento(obj);
		}
	}
}
