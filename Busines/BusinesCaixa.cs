using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Busines
{
   public class BusinesCaixa
    {
        DadosCaixa obj = new DadosCaixa();
        public static string InsertValoresCaixa(decimal valorInicial, int idVendedor)
        {
            DadosCaixa obj = new DadosCaixa();
            obj.ValorInicial = valorInicial;
            obj.IdVendedor = idVendedor;
            
            return obj.InsertValoresCaixa(obj);
        }
        public bool ValorInicial()
        {
            return obj.ValoresCaixa();
        }
    }
}
