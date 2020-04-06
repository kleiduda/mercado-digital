using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supporte.Cache;
using System.Data;
using System.Data.SqlClient;

namespace Dados
{
    public class DadosCaixa : Connection
    {
        public decimal ValorInicial { get; set; }
        public int IdVendedor { get; set; }
        //
        public decimal ValorAbertura { get; set; }
        public decimal ValorFechamento { get; set; }

        public DadosCaixa() { }

        public DadosCaixa(decimal valorInicial, int idVendedor, decimal valorAbertura, decimal valorFechamento)
        {
            ValorInicial = valorInicial;
            IdVendedor = idVendedor;
            ValorAbertura = valorAbertura;
            ValorFechamento = valorFechamento;
        }


        //protected SqlCommand Comando = new SqlCommand();
        protected SqlDataReader dr;
        public bool ValoresCaixa()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_caixa";
                    command.CommandType = CommandType.Text;

                    dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            CaixaCache.ValorInicial = dr.GetDecimal(1);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public string InsertValoresCaixa(DadosCaixa Caixa)
        {
            string rpta = "";
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "ValorInicialCaixa";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@valor_inicial", Caixa.ValorInicial);
                        command.Parameters.AddWithValue("@id_vendedor", Caixa.IdVendedor);

                        rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao inserir valores";
                    }
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                finally
                {
                    connection.Close();
                }
                return rpta;
            }
        }
    }
}
