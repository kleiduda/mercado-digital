using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Dados.Administrador;
using Supporte;

namespace Busines.Administrador
{
   public class BusinesAdministrador : BusinesPedido
    {
        public static DataTable TotalDeVendas()
        {
            return new DadosAdministrador().ListarVendasTotal();
        }
        public static Collection<Vendas> TotalVendas()
        {
            return new DadosAdministrador().TotalVendas();
        }
        public static Collection<DataVencimento> Vencimento()
        {
            return new DadosAdministrador().Vencimento();
        }
        //widget caixas aberto
        public static DataTable CaixaAberto()
        {
            return new DadosAdministrador().CaixasAbertos();
        }
    }
    
}
