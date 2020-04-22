using Dados;
using System.Data;

namespace Busines
{
   public class BusinesCaixa
    {
        DadosCaixa obj = new DadosCaixa();
        public static string InsertValoresCaixa(decimal valorInicial, decimal valorSangria, int idVendedor, int novo)
        {
            DadosCaixa obj = new DadosCaixa();
            obj.ValorInicial = valorInicial;
            obj.ValorSangria = valorSangria;
            obj.IdVendedor = idVendedor;
            obj.Novo = novo;
            
            return obj.InsertValoresCaixa(obj);
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
        public static string FecharCaixa(decimal valorFechamento)
        {
            DadosCaixa obj = new DadosCaixa();
            obj.ValorFechamento = valorFechamento;
            return obj.FecharCaixa(obj);
        }
    }
}
