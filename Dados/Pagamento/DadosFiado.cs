using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dados.Pagamento
{
   public class DadosFiado : Connection
    {
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public decimal SaldoDevedor { get; set; }
        public DadosFiado()
        {

        }
        public DadosFiado(int idPedido, int idCliente, decimal saldoDevedor)
        {
            IdPedido = idPedido;
            IdCliente = idCliente;
            saldoDevedor = saldoDevedor;
        }
        protected SqlCommand command = new SqlCommand();
        protected SqlDataReader reader;
        public string InsertFiado(DadosFiado Dados)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "Criar_Atualizar_Conta_Fiado";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id_cliente", Dados.IdCliente);
                    command.Parameters.AddWithValue("@id_pedido", Dados.IdPedido);
                    command.Parameters.AddWithValue("@saldo_devedor", Dados.SaldoDevedor);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao cadastrar conta fiado";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        //verificando se o cliente ja possui alguma compra fiado
        public bool VerificarValoresFiado(DadosFiado Valida)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_fiado WHERE id_cliente=@id_cliente";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id_cliente", Valida.IdCliente);
                    var result = command.ExecuteScalar();
                    if (result!=null)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {

                }
                return false;
            }
        }
        //mostrar dados
        public DataTable MostrarDadosFiado(DadosFiado Dados)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT saldo_devedor FROM tb_fiado WHERE id_cliente=@id_cliente";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id_cliente", Dados.IdCliente);
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
