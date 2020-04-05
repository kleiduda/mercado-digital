using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Supporte.Cache;

namespace Busines
{
   public class BusinesUsuario
    {
        DadosUsuario dadosUsuario = new DadosUsuario();
        public bool LoginUser(string user, string password)
        {
            return dadosUsuario.Login(user, password);
        }
        
    }
}
