using Dados;
using System.Data;
using Supporte.Enums;

namespace Busines
{
   public class BusinesCaixa
    {
        DadosCaixa obj = new DadosCaixa();
        public static string AberturaCaixa(decimal troco, int idVendedor, StatusCaixa statusCaixa )
        {
            DadosCaixa obj = new DadosCaixa();
            obj.Troco = troco;
            obj.IdVendedor = idVendedor;
            obj.StatusCaixa = statusCaixa;
            return obj.AberturaCaixa(obj);
        }
        public static DataTable ValoresCaixa(int idVendedor, int idCaixa)
        {
            DadosCaixa obj = new DadosCaixa();
            obj.IdVendedor = idVendedor;
            obj.IdCaixa = idCaixa;
            return obj.ValoresCaixa(obj);
        }
        //public static DataTable ValorIncialSangria(int idVendedor)
        //{
        //    DadosCaixa obj = new DadosCaixa();
        //    obj.IdVendedor = idVendedor;
        //    return obj.ValorInicialSangria(obj);
        //}
        //total de vendas do atendente
        public static DataTable ValoresVendaTotal(int idVEndedor)
        {
            DadosCaixa obj = new DadosCaixa();
            obj.IdVendedor = idVEndedor;
            return obj.ValoresVendaTotal(obj);
        }
        //inserir log caixa
        //public static string InsertLogCaixa(int idVendedor, decimal valorFechamento)
        //{
        //    DadosCaixa obj = new DadosCaixa();
        //    obj.IdVendedor = idVendedor;
        //    obj.ValorFechamento = valorFechamento;
        //    return obj.InsertLogCaixa(obj);
        //}
        //fechar caixa
        public static string FecharCaixa(int idCaixa, int idVendedor,  decimal valorFechamento, decimal sangria, StatusCaixa idStatusCaixa)
        {
            DadosCaixa obj = new DadosCaixa();
            obj.IdCaixa = idCaixa;
            obj.IdVendedor = idVendedor;
            obj.ValorFechamento = valorFechamento;
            obj.Sangria = sangria;
            obj.StatusCaixa = idStatusCaixa;
            return obj.FecharCaixa(obj);
        }
        //verificar caixas abertos
        public static DataTable VerificarCaixasAbertos(int idVendedor)
        {
            DadosCaixa obj = new DadosCaixa();
            obj.IdVendedor = idVendedor;
            return obj.VerificarCaixasAbertos(obj   );
        }
        public static DataTable PegarIdCaixaAtual(int idVendedor)
        {
            DadosCaixa obj = new DadosCaixa();
            obj.IdVendedor = idVendedor;
            return obj.PegarIdCaixaAtual(obj);
        }
    }
}
