using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dados
{
    public class DadosPedidoCompra : Connection
    {
        public int IDPedidoCompra { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public int  IDProduto { get; set; }
        public int Qtd { get; set; }
        public string Resultado { get; set; }
        public string Pesquisa { get; set; }
        public int IDFornecedor { get; set; }
        public int IDVendedor { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
        public string Obs { get; set; }
        public string ObsItem { get; set; }
        public int IdStatusVenda { get; set; }

        public DadosPedidoCompra(int iDPedidoCompra, DateTime dataAbertura, DateTime dataFechamento, int iDProduto, int qtd, string resultado, 
            string pesquisa, int iDFornecedor, int iDVendedor, DateTime ultimaAtualizacao, string obs ,int idStatusVenda, string obsItem)
        {
            IDPedidoCompra = iDPedidoCompra;
            DataAbertura = dataAbertura;
            DataFechamento = dataFechamento;
            IDProduto = iDProduto;
            Qtd = qtd;
            Resultado = resultado;
            Pesquisa = pesquisa;
            IDFornecedor = iDFornecedor;
            IDVendedor = iDVendedor;
            UltimaAtualizacao = ultimaAtualizacao;
            Obs = obs;
            IdStatusVenda = idStatusVenda;
            ObsItem = obsItem;
        }

        public DadosPedidoCompra()
        {
        }
        protected SqlCommand command = new SqlCommand();
        protected SqlDataReader dr;

        public string PedidoCompra_New(DadosPedidoCompra PCOMPRA)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "PedidoCompra_New";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@data_abertura", PCOMPRA.DataAbertura);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "erro ao cadastrar";
                    
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        public DataTable PedidoCompra_Lista()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT p.id, Convert(varchar(10), p.data_abertura, 103) as Data, v.nome, f.nome_fantasia, p.observacao " +
                        "FROM tb_pedido_compra p LEFT JOIN tb_vendedor v ON p.id_vendedor = v.id_vendedor LEFT JOIN tb_fornecedores f ON p.id_fornecedor = f.id";
                    command.CommandType = CommandType.Text;
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
        public DataTable PedidoCompra_ListarProdutos()
        {
            DataTable DtResult = new DataTable("produto");

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT p.id_produto, p.codigo, p.descricao, p.preco, i.tipo_embalagem, i.qtd_embalagem, i.preco_unidade, i.metro_cubico " +
                        "FROM tb_produto p LEFT JOIN tb_produto_info i ON p.id_produto = i.id_produto";
                    command.CommandType = CommandType.Text;

                    SqlDataAdapter SqlDat = new SqlDataAdapter(command);
                    SqlDat.Fill(DtResult);

                }
                catch (Exception ex)
                {
                    DtResult = null;
                }
                return DtResult;
            }

        }
        public DataTable PedidoCompra_PesquisaProduto(DadosPedidoCompra PESQUISA)
        {
            DataTable DtResultado = new DataTable("product");
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "PedidoCompra_Pesquisa";
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter parPesquisaProduto = new SqlParameter();
                    parPesquisaProduto.ParameterName = "@search_text";
                    parPesquisaProduto.SqlDbType = SqlDbType.VarChar;
                    parPesquisaProduto.Size = 50;
                    parPesquisaProduto.Value = PESQUISA.Pesquisa;
                    command.Parameters.Add(parPesquisaProduto);

                    SqlDataAdapter SqlDat = new SqlDataAdapter(command);
                    SqlDat.Fill(DtResultado);

                    command.Parameters.Clear();
                }
                catch (Exception ex)
                {
                    DtResultado = null;
                }
                return DtResultado;
            }

        }
        public string PedidoCompra_AddItemPedido(DadosPedidoCompra Item)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "PedidoCompra_AddItem";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_pedido_compra", Item.IDPedidoCompra);
                    command.Parameters.AddWithValue("@id_produto", Item.IDProduto);
                    command.Parameters.AddWithValue("@quantidade", Item.Qtd);
                    command.Parameters.AddWithValue("@obs_item", Item.ObsItem);
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
        #region ITEM_PEDIDO
        public DataTable PedidoCompra_ListarItem(DadosPedidoCompra ITEM)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "PedidoCompra_ItensPedido";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_pedido_compra", ITEM.IDPedidoCompra);
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
        public DataTable PedidoCompra_Info(DadosPedidoCompra INFO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT pc.id, f.nome_fantasia, s.nome as status, pc.observacao FROM tb_pedido_compra pc LEFT JOIN tb_fornecedores f " +
                        "ON pc.id_fornecedor = f.id LEFT JOIN tb_status_venda s ON pc.id_status_venda = s.id_status_venda WHERE pc.id = @id";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id", INFO.IDPedidoCompra);
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
        public string PedidoCompra_Update(DadosPedidoCompra PEDIDO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "PedidoCompra_Update";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", PEDIDO.IDPedidoCompra);
                    command.Parameters.AddWithValue("@id_fornecedor", PEDIDO.IDFornecedor );
                    command.Parameters.AddWithValue("@id_vendedor", PEDIDO.IDVendedor);
                    command.Parameters.AddWithValue("@observacao", PEDIDO.Obs);
                    command.Parameters.AddWithValue("@id_status_venda", PEDIDO.IdStatusVenda);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Error";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message + ex.StackTrace;
                }
                return rpta;
            }
        }
        public DataTable PedidoCompra_DadosExcel(DadosPedidoCompra EXCEL)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "PedidoCompra_DadosExcel";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_pedido_compra", EXCEL.IDPedidoCompra);
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
        #endregion
    }
}
