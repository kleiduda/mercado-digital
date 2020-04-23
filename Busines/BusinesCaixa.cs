using Dados;
using System.Data;

namespace Busines
{
   public class BusinesCaixa
    {
        DadosCaixa obj = new DadosCaixa();
        public static string AberturaCaixa(decimal valorInicial, int idVendedor)
        {
            DadosCaixa obj = new DadosCaixa();
            obj.ValorInicial = valorInicial;
            obj.IdVendedor = idVendedor;
            return obj.AberturaCaixa(obj);
        }
        public static DataTable ValorInicial(int idVendedor)
        {
            DadosCaixa obj = new DadosCaixa();
            obj.IdVendedor = idVendedor;
            return obj.ValoresCaixa(obj);
        }
        public static DataTable ValorIncialSangria(int idVendedor)
        {
            DadosCaixa obj = new DadosCaixa();
            obj.IdVendedor = idVendedor;
            return obj.ValorInicialSangria(obj);
        }
        //total de vendas do atendente
        public static DataTable ValoresVendaTotal(int idVEndedor)
        {
            DadosCaixa obj = new DadosCaixa();
            obj.IdVendedor = idVEndedor;
            return obj.ValoresVendaTotal(obj);
        }
        //inserir log caixa
        public static string InsertLogCaixa(int idVendedor, decimal valorFechamento)
        {
            DadosCaixa obj = new DadosCaixa();
            obj.IdVendedor = idVendedor;
            obj.ValorFechamento = valorFechamento;
            return obj.InsertLogCaixa(obj);
        }
        //fechar caixa
        public static string FecharCaixa(int idVendedor,  decimal valorFechamento, decimal sangria)
        {
            DadosCaixa obj = new DadosCaixa();
            obj.IdVendedor = idVendedor;
            obj.ValorFechamento = valorFechamento;
            obj.ValorSangria = sangria;
            return obj.FecharCaixa(obj);
        }
    }
}
