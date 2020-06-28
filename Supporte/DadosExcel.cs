using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Supporte
{
    public class DadosExcel
    {
        public byte[] Foto { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public int QtdCaixa { get; set; }
        public decimal ValorUnidade { get; set; }
        public int Quantidade { get; set; }
        public decimal Total { get; set; }
        public decimal MetroCubico { get; set; }
        public decimal TotalCBM { get; set; }
        public int MinimoVenda { get; set; }
        public string CodBarra { get; set; }
        public string Medida { get; set; }

        public string ObsItem { get; set; }

        public DadosExcel(byte[] foto, string codigo, string descricao, int qtdCaixa, decimal valorUnidade, int quantidade, decimal total, 
            decimal metroCubico, decimal totalCBM, int minimoVenda, string codBarra, string medida, string obsItem)
        {
            Foto = foto;
            Codigo = codigo;
            Descricao = descricao;
            QtdCaixa = qtdCaixa;
            ValorUnidade = valorUnidade;
            Quantidade = quantidade;
            Total = total;
            MetroCubico = metroCubico;
            TotalCBM = totalCBM;
            MinimoVenda = minimoVenda;
            CodBarra = codBarra;
            Medida = medida;
            ObsItem = obsItem;
        }

        public DadosExcel()
        {

        }
    }
}
