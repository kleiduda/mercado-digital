using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using Supporte;

namespace Dados.Administrador
{
    public class DadosAdministrador : DadosPedido
    {
        public DataTable ListarVendasTotal()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM View_TotalVendas";
                    command.CommandType = CommandType.Text;
                    SqlDataAdapter SqlDat = new SqlDataAdapter(command);
                    SqlDat.Fill(dt);
                }
                catch (Exception ex)
                {
                    dt = null;
                }
                return dt;
            }
        }
        public Collection<Vendas> TotalVendas()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var colecao = new Collection<Vendas>();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM View_TotalVendas";
                    command.CommandType = CommandType.Text;
                    SqlDataAdapter SqlDat = new SqlDataAdapter(command);
                    SqlDat.Fill(dt);
                    connection.Close();
                    foreach (DataRow row in dt.Rows)
                    {
                        Vendas p = new Vendas
                        {
                            IdPagamento = int.Parse(row["id_pagamento"].ToString()),
                            IdStatusVenda = int.Parse(row["id_status_venda"].ToString()),
                            Total = decimal.Parse(row["TotalDeVendas"].ToString())
                        };
                        colecao.Add(p);
                    }

                }
                catch (Exception ex)
                {
                    colecao = null;
                }
                return colecao;
            }
        }
        public Collection<DataVencimento> Vencimento()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var colecao = new Collection<DataVencimento>();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "DataVencimento";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter SqlDat = new SqlDataAdapter(command);
                    SqlDat.Fill(dt);
                    connection.Close();
                    foreach (DataRow row in dt.Rows)
                    {
                        DataVencimento dv = new DataVencimento
                        {
                            Codigo = row["codigo"].ToString(),
                            Descrição = row["descricao"].ToString(),
                            Vencimento = row["data_validade"].ToString(),
                            QtdEstoque = int.Parse(row["estoque"].ToString())
                        };
                        colecao.Add(dv);
                    }
                }
                catch (Exception ex)
                {
                    colecao = null;
                }
                return colecao;
            }
        }
    }
}
