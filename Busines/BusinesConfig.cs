using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dados;

namespace Busines
{
    public class BusinesConfig
    {
        public static DataTable Config()
        {
            DadosConfig obj = new DadosConfig();
            return obj.Config();
        }
    }
}
