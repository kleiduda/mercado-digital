using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supporte.Cache;
using System.Data;
using System.Data.SqlClient;
using Supporte.Enums;

namespace Dados
{
    public class DadosCaixa : Connection
    {
        public decimal Troco { get; set; }
        public decimal Sangria { get; set; }
        public int IdVendedor { get; set; }
        public decimal ValorFechamento { get; set; }
        public StatusCaixa StatusCaixa { get; set; }
        public int IdCaixa { get; set; }

        public DadosCaixa() { }

        public DadosCaixa(decimal troco, decimal sangria, int idVendedor, decimal valorFechamento, StatusCaixa statusCaixa, int IdCaixa)
        {
            Troco = troco;
            Sangria = sangria;
            IdVendedor = idVendedor;
            ValorFechamento = valorFechamento;
            StatusCaixa = statusCaixa;
            IdCaixa = IdCaixa;
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
                        command.CommandText = "SELECT * FROM tb_caixa WHERE id_vendedor=@id_vendedor AND id_status_caixa=1 AND id=@id_caixa";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@id_vendedor",Caixa.IdVendedor);
                        command.Parameters.AddWithValue("@id_caixa", Caixa.IdCaixa);
                        SqlDataAdapter SqlDat = new SqlDataAdapter(command);
                        SqlDat.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            CaixaCache.idStatusCaixa = int.Parse(dt.Rows[0]["id_status_caixa"].ToString());
                            CaixaCache.Troco = decimal.Parse(dt.Rows[0]["troco"].ToString());
                            CaixaCache.IdCaixa = int.Parse(dt.Rows[0]["id"].ToString());
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
        public string AberturaCaixa(DadosCaixa Caixa)
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
                        command.CommandText = "AberturaCaixa";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@troco", Caixa.Troco);
                        command.Parameters.AddWithValue("@id_vendedor", Caixa.IdVendedor);
                        command.Parameters.AddWithValue("@id_status_caixa", Caixa.StatusCaixa);

                        rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao Abrir o Caixa";
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
        //public string InsertLogCaixa(DadosCaixa Log)
        //{
        //    using (var connection = GetConnection())
        //    {
        //        connection.Open();
        //        string rpta = "";
        //        try
        //        {
        //            command.Connection = connection;
        //            command.CommandText = "LogCaixa";
        //            command.CommandType = CommandType.StoredProcedure;
        //            command.Parameters.AddWithValue("@id_vendedor", Log.IdVendedor);
        //            command.Parameters.AddWithValue("@valor_fechamento", Log.ValorFechamento);
        //            rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao cadastrar Log";
        //        }
        //        catch (Exception ex)
        //        {
        //            rpta = ex.Message + ex.StackTrace;
        //        }
        //        return rpta;
        //    }

        //}
        //RelatorioCaixaAtendente
        //public DataTable DadosDoCaixa(DadosCaixa Atendente)
        //{
        //    DataTable dt = new DataTable();
        //    using (var connection = GetConnection())
        //    {
        //        try
        //        {
        //            command.Connection = connection;
        //            command.CommandText = "DadosDoCaixa";
        //            command.CommandType = CommandType.StoredProcedure;
        //            command.Parameters.AddWithValue("@id_vendedor", Atendente.IdVendedor);
        //            SqlDataAdapter SqlDat = new SqlDataAdapter(command);
        //            SqlDat.Fill(dt);
        //        }catch(Exception ex)
        //        {
        //            dt = null;
        //        }
        //        return dt;
        //    }
        //}
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
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "FecharCaixa";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_caixa", Fechar.IdCaixa);
                    command.Parameters.AddWithValue("@id_vendedor", Fechar.IdVendedor);
                    command.Parameters.AddWithValue("@valor_fechamento", Fechar.ValorFechamento);
                    command.Parameters.AddWithValue("@sangria", Fechar.Sangria);
                    command.Parameters.AddWithValue("@id_status_caixa", Fechar.StatusCaixa);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao atualizar SANGRIA";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message + ex.StackTrace;
                }
                return rpta;
            }
        }
        //verificar caixas abertos
        public DataTable VerificarCaixasAbertos(DadosCaixa Valida)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_caixa WHERE id_status_caixa=1 and id_vendedor=@id_vendedor";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id_vendedor", Valida.IdVendedor);
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
        //gravar ID Caixa
        public DataTable PegarIdCaixaAtual(DadosCaixa Id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT id FROM tb_caixa where id_vendedor=@id_vendedor AND id_status_caixa=1";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id_vendedor", Id.IdVendedor);
                    SqlDataAdapter SqlDat = new SqlDataAdapter(command);
                    SqlDat.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        CacheIdCaixa.IdCaixa = int.Parse(dt.Rows[0]["id"].ToString());
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
}
