﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supporte
{
    public  class Vendas
    {
        public  string Codigo { get; set; }
        public  string Descricao { get; set; }
        public  decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public decimal Total { get; set; }
        public int IdPagamento { get; set; }
        public int IdStatusVenda { get; set; }

    }
}
