using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dados.NotaFiscal
{
    public class DadosNotaFiscal : Connection
    {
        public string Cpf { get; set; }
        public int IdPedido { get; set; }
        public DadosNotaFiscal() { }

        public DadosNotaFiscal(string cpf, int idPedido)
        {
            Cpf = cpf;
            IdPedido = idPedido;
        }
        private SqlCommand command = new SqlCommand();
        private SqlDataReader dr;
        public string CadastroCpfNota(DadosNotaFiscal CpfNota)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO tb_cpf_nota (cpf, id_pedido) values (@cpf, @id_pedido)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@cpf", CpfNota.Cpf);
                    command.Parameters.AddWithValue("@id_pedido", CpfNota.IdPedido);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao cadastrar CPF";
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
