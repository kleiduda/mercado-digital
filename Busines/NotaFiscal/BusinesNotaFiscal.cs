using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.NotaFiscal;

namespace Busines.NotaFiscal
{
    public class BusinesNotaFiscal
    {
        public static string CadastroCpfNota(string cpf, int idPedido)
        {
            DadosNotaFiscal obj = new DadosNotaFiscal();
            obj.Cpf = cpf;
            obj.IdPedido = idPedido;
            return obj.CadastroCpfNota(obj);
        }
    }
}
