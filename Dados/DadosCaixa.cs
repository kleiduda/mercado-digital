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
        public decimal ValorSangria { get; set; }
        public int IdVendedor { get; set; }
        //
        public decimal ValorAbertura { get; set; }
        public decimal ValorFechamento { get; set; }
        public int Novo { get; set; }

        public DadosCaixa() { }

        public DadosCaixa(decimal valorInicial, decimal valorSangria, int idVendedor, decimal valorAbertura, decimal valorFechamento, int novo)
        {
            ValorInicial = valorInicial;
            ValorSangria = valorSangria;
            IdVendedor = idVendedor;
            ValorAbertura = valorAbertura;
            ValorFechamento = valorFechamento;
            Novo = novo;
        }

        protected SqlCommand command = new SqlCommand();
        //protected SqlCommand Comando = new SqlCommand();
        protected SqlDataReader dr;
        public DataTable ValoresCaixa(DadosCaixa Caixa)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                using (var command = new SqlCommand())
                {
                    try
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT * FROM tb_caixa WHERE id_vendedor=@id_vendedor";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@id_vendedor",Caixa.IdVendedor);
                        SqlDataAdapter SqlDat = new SqlDataAdapter(command);
                        SqlDat.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            CaixaCache.IdVendedor = int.Parse(dt.Rows[0]["id_vendedor"].ToString());
                            CaixaCache.ValorInicial = decimal.Parse(dt.Rows[0]["valor_inicial"].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        dt = null;
                    }
                    return dt;
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
                        command.Parameters.AddWithValue("@valor_sangria", Caixa.ValorSangria);
                        command.Parameters.AddWithValue("@id_vendedor", Caixa.IdVendedor);
                        command.Parameters.AddWithValue("@new", Caixa.Novo);

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
        //LogCaixa
        public string InsertLogCaixa(DadosCaixa Log)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "LogCaixa";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_vendedor", Log.IdVendedor);
                    command.Parameters.AddWithValue("@valor_fechamento", Log.ValorFechamento);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao cadastrar Log";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message + ex.StackTrace;
                }
                return rpta;
            }

        }
        //RelatorioCaixaAtendente
        public DataTable ValorInicialSangria(DadosCaixa Atendente)
        {
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "RelatorioCaixa";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_vendedor", Atendente.IdVendedor);
                    SqlDataAdapter SqlDat = new SqlDataAdapter(command);
                    SqlDat.Fill(dt);
                }catch(Exception ex)
                {
                    dt = null;
                }
                return dt;
            }
        }
        //valores total de vendas do atendente por dia
        public DataTable ValoresVendaTotal(DadosCaixa Total)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "TotalVendas";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_vendedor", Total.IdVendedor);
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
        //fechar caixa
        public string FecharCaixa(DadosCaixa Fechar)
        {
            using (var connectio = GetConnection())
            {
                connectio.Open();
                string rpta = "";
                try
                {
                    command.Connection = connectio;
                    command.CommandText = "FecharCaixa";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@valor_fechamento", Fechar.ValorFechamento);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao atualizar LOG CAIXA";
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
