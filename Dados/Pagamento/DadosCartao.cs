using Supporte.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Dados.Pagamento
{
   public class DadosCartao : DadosPagamento
    {
        public BandeirasCartao Bandeira { get; set; }
        public decimal TaxaDebito { get; set; }
        public decimal TaxaCredito { get; set; }
        public DadosCartao()
        {

        }

        public DadosCartao(BandeirasCartao bandeira, decimal taxaDebito, decimal taxaCredito, int idPagamento)
        {
            Bandeira = bandeira;
            TaxaDebito = taxaDebito;
            TaxaCredito = taxaCredito;
        }
        private SqlCommand command = new SqlCommand();
        SqlDataReader dr;
        public string CadastroCartao(DadosCartao Cartao)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO tb_cartoes (id_bandeira, taxa_debito, taxa_credito) VALUES (@id_bandeira, @taxa_debito, @taxa_credito)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id_bandeira", Cartao.Bandeira);
                    command.Parameters.AddWithValue("@taxa_debito", Cartao.TaxaDebito);
                    command.Parameters.AddWithValue("@taxa_credito", Cartao.TaxaCredito);
                    //command.Parameters.AddWithValue("@id_pagamento", Cartao.IdPagamento);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Falha ao cadastrar cartao";
                    connection.Close();
                }
                catch (Exception ex)
                {
                    rpta = ex.Message + ex.StackTrace;
                }
                return rpta;
            }
        }
        public string UpdateCartao(DadosCartao Cartao)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "Update tb_cartoes SET taxa_debito=@taxa_debito, taxa_credito=@taxa_credito WHERE id_bandeira=@id_bandeira";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id_bandeira", Cartao.Bandeira);
                    command.Parameters.AddWithValue("@taxa_debito", Cartao.TaxaDebito);
                    command.Parameters.AddWithValue("@taxa_credito", Cartao.TaxaCredito);
                    //command.Parameters.AddWithValue("@id_pagamento", Cartao.IdPagamento);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Falha ao atualizar cartao";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message + ex.StackTrace;
                }
                return rpta;
            }
        }
        public DataTable ListarDebito()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_cartoes WHERE id_pagamento = 2";
                    command.CommandType = CommandType.Text;
                    SqlDataAdapter SqlDat = new SqlDataAdapter(command);
                    SqlDat.Fill(dt);
                    connection.Close();
                }
                catch (Exception ex)
                {
                    dt = null;
                }
                return dt;
            }
        }
        public DataTable ListarCredito()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_cartoes WHERE id_pagamento = 3";
                    command.CommandType = CommandType.Text;
                    SqlDataAdapter SqlDat = new SqlDataAdapter(command);
                    SqlDat.Fill(dt);
                    connection.Close();
                }
                catch (Exception ex)
                {
                    dt = null;
                }
                return dt;
            }
        }
        public bool Valida(DadosCartao Cartao)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tb_cartoes where id_bandeira = @id_bandeira";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id_bandeira",Cartao.Bandeira);
                    var result = command.ExecuteScalar();
                    if (result != null)
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
    }
}
