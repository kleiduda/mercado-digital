using Dados.Pagamento;
using Supporte.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.Pagamento
{
    public class BusinesCartao : BusinesPagamento
    {
        public static string CadastroCartao(BandeirasCartao bandeira, decimal taxaDebito, decimal taxaCredito)
        {
            DadosCartao obj = new DadosCartao();
            obj.Bandeira = bandeira;
            obj.TaxaDebito = taxaDebito;
            obj.TaxaCredito = taxaCredito;
            return obj.CadastroCartao(obj);
        }
        public static string UpdateCartao(BandeirasCartao bandeira, decimal taxaDebito, decimal taxaCredito)
        {
            DadosCartao obj = new DadosCartao();
            obj.Bandeira = bandeira;
            obj.TaxaDebito = taxaDebito;
            obj.TaxaCredito = taxaCredito;
            return obj.UpdateCartao(obj);
        }
        public static DataTable ListarDebito()
        {
            return new DadosCartao().ListarDebito();
        }
        public static DataTable ListarCredito()
        {
            return new DadosCartao().ListarCredito();
        }
        public static bool ValidaCartao(BandeirasCartao bandeira)
        {
            DadosCartao obj = new DadosCartao();
            obj.Bandeira = bandeira;
            return obj.Valida(obj);
        }
    }
}
