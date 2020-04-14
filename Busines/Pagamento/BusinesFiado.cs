using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.Pagamento;

namespace Busines.Pagamento
{
    public class BusinesFiado
    {
        public static string CadastrarContaFiado(int idCliente, int idPedido, decimal saldoDevedor)
        {
            Dados.Pagamento.DadosFiado obj = new Dados.Pagamento.DadosFiado();
            obj.IdCliente = idCliente;
            obj.IdPedido = idPedido;
            obj.SaldoDevedor = saldoDevedor;
            return obj.InsertFiado(obj);
        }
        //verificar se o cliente ja tem algum valor pendente
        public static bool VerificarValorFiado(int idCliente)
        {
            DadosFiado obj = new DadosFiado();
            obj.IdCliente = idCliente;
            return obj.VerificarValoresFiado(obj);
        }
        //mostrar dados se tiver
        public static DataTable MostrarDadosFiado(int idCliente)
        {
            DadosFiado obj = new DadosFiado();
            obj.IdCliente = idCliente;
            return obj.MostrarDadosFiado(obj);
        }
    }
}
