﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using System.Data;


namespace Busines
{
    public class BusinesPedido
    {
        //cadastro nova compra
        public static string CadastroNovaCompra(int idCliente, int idVendedor, int idStatus)
        {
            DadosPedido obj = new DadosPedido();
            obj.IdCliente = idCliente;
            obj.IdVendedor = idVendedor;
            obj.IdStatus = idStatus;
            return obj.CadastroNovaCompra(obj);
        }
        //listando dados do pedido
        public static DataTable DetalhePedido(int idVendedor)
        {
            DadosPedido obj = new DadosPedido();
            obj.IdVendedor = idVendedor;
            return obj.DetalhePedido(obj);
        }
        //inserindo item no pedido
        public static string InserirItemPedido(int idPedido, int idProduto, int quantidade)
        {
            DadosPedido obj = new DadosPedido();
            obj.IdPedido = idPedido;
            obj.IdProduto = idProduto;
            obj.Quantidade = quantidade;
            return obj.InsertItemPedido(obj);
        }
    }
}
