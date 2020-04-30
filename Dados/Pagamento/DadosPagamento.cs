using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Supporte.Enums;
using System.Windows.Documents;

namespace Dados.Pagamento
{
    public class DadosPagamento : Connection
    {
		public TiposPagamento IdPagamento { get; set; }
		public int IdPedido { get; set; }
        public decimal ValorRecebido { get; set; }
		public decimal Troco { get; set; }
		public DadosPagamento() { }

		public DadosPagamento(TiposPagamento idPagamento, int idPedido, decimal valorRecebido, decimal troco)
		{
			IdPagamento = idPagamento;
			IdPedido = idPedido;
			ValorRecebido = valorRecebido;
			Troco = troco;
		}

		private SqlCommand command = new SqlCommand();
        private SqlDataReader reader;

		public string CadastroPedidoPagamento(DadosPagamento Pagamento)
		{
			using (var connection = GetConnection())
			{
				connection.Open();
				string rpta = "";
				try
				{
					command.Connection = connection;
					command.CommandText = "Insert into tb_pedido_pagamento (id_pagamento, id_pedido, valor_recebido, troco) Values (@id_pagamento, @id_pedido, @valor_recebido, @troco)";
					command.CommandType = CommandType.Text;
					command.Parameters.AddWithValue("@id_pagamento", Pagamento.IdPagamento);
					command.Parameters.AddWithValue("@id_pedido", Pagamento.IdPedido);
					command.Parameters.AddWithValue("@valor_recebido", Pagamento.ValorRecebido);
					command.Parameters.AddWithValue("@troco", Pagamento.Troco);
					rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao atualizar pagamento";
		}
				catch (Exception ex)
				{
					rpta = ex.Message;
				}
				return rpta;

			}
		}
		public DataTable ListarPedidoPagamento(DadosPagamento Listar)
		{
			using (var connection = GetConnection())
			{
				connection.Open();
				DataTable dt = new DataTable();
				try
				{
					command.Connection = connection;
					command.CommandText = "Select * from tb_pedido_pagamento WHERE id_pedido=@id_pedido";
					command.CommandType = CommandType.Text;
					command.Parameters.AddWithValue("@id_pedido", Listar.IdPedido);
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

	}
}
