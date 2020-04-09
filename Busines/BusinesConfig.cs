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
        public static DataTable PathImage()
        {
            DadosConfig obj = new DadosConfig();
            return obj.PathImage();
        }
        //cadastro de path
        public static string CadastroPathImage(string pathImage)
        {
            DadosConfig obj = new DadosConfig();
            obj.PatchImage = pathImage;
            return obj.CadastroPathImage(obj);
        }
    }
}
