using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Supporte.Enums;

namespace Dados
{
    public class DadosPedido : Connection
    {
        //Pedido
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public StatusPedido IdStatusPedido { get; set; }
        //pedido item
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public int EstoqueQuantidade { get; set; }
        public string Resultado { get; set; }
        public decimal Preco { get; set; }
        public TiposPagamento Pagamento { get; set; }
        //
        public int IdCaixa { get; set; }
        public TipoEntrega IdTipoEntrega { get; set; }
        public DateTime DataAbertura { get; set; }

        //construtores
        public DadosPedido()
        {

        }
        public DadosPedido(int idPedido, int idCliente, int idVendedor, StatusPedido idStatusPedido, int idProduto, int quantidade, int estoqueQuantidade, 
            string resultado, decimal preco, TiposPagamento pagamento, int idCaixa, TipoEntrega idTipoEntrega, DateTime dataAbertura)
        {
            IdPedido = idPedido;
            IdCliente = idPedido;
            IdVendedor = idVendedor;
            IdStatusPedido = IdStatusPedido;
            IdProduto = idProduto;
            Quantidade = quantidade;
            EstoqueQuantidade = estoqueQuantidade;
            Resultado = resultado;
            Preco = preco;
            Pagamento = pagamento;
            IdCaixa = idCaixa;
            dataAbertura = dataAbertura;
        }
        //metodos
        protected SqlCommand command = new SqlCommand();
        protected SqlDataReader reader;
        //cadastro de nova compra
        public string CadastroNovaCompra(DadosPedido Pedido)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "NovaCompra";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter parID = new SqlParameter();
                    parID.ParameterName = "@id_pedido";
                    parID.Value = Pedido.IdPedido;
                    parID.SqlDbType = SqlDbType.Int;
                    parID.Direction = ParameterDirection.Output;
                    command.Parameters.Add(parID);
                    command.Parameters.AddWithValue("@id_cliente", Pedido.IdCliente);
                    command.Parameters.AddWithValue("@id_vendedor", Pedido.IdVendedor);
                    command.Parameters.AddWithValue("@id_status", Pedido.IdStatusPedido);
                    command.Parameters.AddWithValue("@id_caixa", Pedido.IdCaixa);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao cadastrar nova compra";
                    command.Parameters.Clear();
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        //abrir nova compra
        public string AbrirCompra(DadosPedido Compra)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "Insert into tb_pedido (id_cliente, id_vendedor, id_status, id_entrega, data_abertura, id_caixa) values (@id_cliente, @id_vendedor, @id_status, @id_entrega, @data_abertura, @id_caixa)";
                    command.CommandType = CommandType.Text;
                    //
                    command.Parameters.AddWithValue("@id_cliente", Compra.IdCliente);
                    command.Parameters.AddWithValue("@id_vendedor", Compra.IdVendedor);
                    command.Parameters.AddWithValue("@id_status", Compra.IdStatusPedido);
                    command.Parameters.AddWithValue("@id_entrega", Compra.IdTipoEntrega);
                    command.Parameters.AddWithValue("@data_abertura", Compra.DataAbertura);
                    command.Parameters.AddWithValue("@id_caixa", Compra.IdCaixa);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao abrir compra";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message + ex.StackTrace;
                }
                return rpta;
            }
        }
        //recuperando dados da compra
        //public List<DadosPedido> DetalhePedido(DadosPedido Pedido)
        //{
        //    using (var connection = GetConnection())
        //    {
        //        connection.Open();
        //        List<DadosPedido> list = new List<DadosPedido>();
        //        try
        //        {
        //            command.Connection = connection;
        //            command.CommandText = "DetalhePedido";
        //            command.CommandType = CommandType.StoredProcedure;
        //            command.Parameters.AddWithValue("@id_vendedor", Pedido.IdVendedor);
        //            reader = command.ExecuteReader();
        //            if (reader.HasRows)
        //            {
        //                while (reader.Read())
        //                {
        //                    DadosPedido obj = new DadosPedido();
        //                    obj.IdPedido = reader.GetInt32(0);
        //                    obj.IdCliente = reader.GetInt32(1);
        //                    list.Add(obj);
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //        }
        //        return list;
        //    }
        //}
        public DataTable DetalhePedido(DadosPedido Pedido)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "DetalhePedido";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_vendedor", Pedido.IdVendedor);
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
        //incluindo item o pedido
        public string InsertItemPedido(DadosPedido Item)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "pIncluirItemPedido";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_pedido", Item.IdPedido);
                    command.Parameters.AddWithValue("@id_produto", Item.IdProduto);
                    command.Parameters.AddWithValue("@quantidade", Item.Quantidade);
                    command.Parameters.AddWithValue("@estoque_quantidade", Item.EstoqueQuantidade);
                    SqlParameter parResultado = new SqlParameter();
                    parResultado.ParameterName = "@resultado";
                    parResultado.Value = Item.Resultado;
                    parResultado.SqlDbType = SqlDbType.VarChar;
                    parResultado.Size = 200;
                    parResultado.Direction = ParameterDirection.Output;
                    command.Parameters.Add(parResultado);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao inserir item no pedido";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
            
        }
        //listar itens do pedido
        public DataTable ListarItensPedido(DadosPedido Item)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable("listitem");
                try
                {
                    command.Connection = connection;
                    command.CommandText = "ListarItens";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_pedido",Item.IdPedido );
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
        //fechar compra
        public string FecharCompra(DadosPedido Update)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "FecharCompra";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_pedido", Update.IdPedido);
                    command.Parameters.AddWithValue("@id_pagamento", Update.Pagamento);
                    command.Parameters.AddWithValue("@id_status", Update.IdStatusPedido);
                    command.Parameters.AddWithValue("@id_cliente", Update.IdCliente);
                    
                    rpta = command.ExecuteNonQuery() == 2 ? "OK" : "Erro ao atualizar compra";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message + ex.StackTrace;
                }
                return rpta;
            }
        }

    }
}
