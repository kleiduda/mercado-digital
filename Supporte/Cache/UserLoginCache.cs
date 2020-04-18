using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supporte.Enums;

namespace Supporte.Cache
{
   public static class UserLoginCache
    {
        public static int IdUser { get; set; }
        public static string Login { get; set; }
        public static string Nome { get; set; }
        public static string SobreNome { get; set; }
        public static string Email { get; set; }
        public static int Cargo { get; set; }
       
    }
}
