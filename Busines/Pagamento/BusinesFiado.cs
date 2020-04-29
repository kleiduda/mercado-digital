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
        public static string AtualizarContaFiado(int idPedido, int idCliente, decimal saldoDevedor)
        {
            DadosFiado obj = new DadosFiado();
            obj.IdPedido = idPedido;
            obj.IdCliente = idCliente;
            obj.SaldoDevedor = saldoDevedor;
            return obj.AtualizarContaFiado(obj);
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
