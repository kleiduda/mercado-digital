using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Dados.Administrador;

namespace Busines.Administrador
{
   public class BusinesAdministrador : BusinesPedido
    {
        public static DataTable TotalDeVendas()
        {
            return new DadosAdministrador().ListarVendasTotal();
        }
    }
    
}
