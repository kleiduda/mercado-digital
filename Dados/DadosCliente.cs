﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Supporte.Cache;

namespace Dados
{
    public class DadosCliente : Connection
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string CPF { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Observacao { get; set; }
        //
        public int IdPedido { get; set; }
        public decimal SaldoDevedor { get; set; }

        public DadosCliente()
        {

        }

        public DadosCliente(int idCliente, string nome, string sobreNome, string cPF, string fone, string email, string cEP, 
            string endereco, string bairro, string cidade, string uF, string observacao, int idPedido, decimal saldoDevedor)
        {
            IdCliente = idCliente;
            Nome = nome;
            SobreNome = sobreNome;
            CPF = cPF;
            Fone = fone;
            Email = email;
            CEP = cEP;
            Endereco = endereco;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;
            Observacao = observacao;
            IdPedido = IdPedido;
            SaldoDevedor = saldoDevedor;
        }
        protected SqlCommand command = new SqlCommand();
        protected SqlDataReader reader;
        public string CadastroNovoContaFiado(DadosCliente Cliente)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "CadastroCliente";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter parId = new SqlParameter();
                    parId.ParameterName = "@id_cliente";
                    parId.Value = Cliente.IdCliente;
                    parId.SqlDbType = SqlDbType.Int;
                    parId.Direction = ParameterDirection.Output;
                    command.Parameters.Add(parId);
                    command.Parameters.AddWithValue("@nome", Cliente.Nome);
                    command.Parameters.AddWithValue("@sobre_nome", Cliente.SobreNome);
                    command.Parameters.AddWithValue("@cpf", Cliente.CPF);
                    command.Parameters.AddWithValue("@fone", Cliente.Fone);
                    command.Parameters.AddWithValue("@email", Cliente.Email);
                    command.Parameters.AddWithValue("@cep", Cliente.CEP);
                    command.Parameters.AddWithValue("@endereco", Cliente.Endereco);
                    command.Parameters.AddWithValue("@bairro", Cliente.Bairro);
                    command.Parameters.AddWithValue("@cidade", Cliente.Cidade);
                    command.Parameters.AddWithValue("@uf", Cliente.UF);
                    command.Parameters.AddWithValue("@observacao", Cliente.Observacao);
                    //
                    command.Parameters.AddWithValue("@id_pedido", Cliente.IdPedido);
                    command.Parameters.AddWithValue("@saldo_devedor", Cliente.SaldoDevedor);

                    rpta = command.ExecuteNonQuery() == 2 ? "OK" : "Erro ao cadastrar cliente";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }

        }
        //recuperar o cliente pelo CPF ou Nome
        public bool ConsultaCadastroCliente(DadosCliente Dados)
        {
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tb_cliente where cpf=@cpf";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@cpf", Dados.CPF);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }

                }
                catch (Exception ex)
                {
                    dt = null;
                }
                return false;
            }

        }
        public DataTable ListarClientes()
        {
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM viewDadosFiado";
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
        //pegando os dados dos usuarios
        public DataTable DadosFiadoCliente(DadosCliente Fiado)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                using (var command = new SqlCommand())
                {
                    try
                    {
                        command.Connection = connection;
                        command.CommandText = "select * from viewDadosFiado where cpf=@cpf";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@cpf", Fiado.CPF);
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
        }
        public bool ValidarCadastro(DadosCliente Valida)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_cliente where cpf=@cpf";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@cpf", Valida.CPF);
                    var result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {

                }
                return false;
            }
        }
        //cadastro apenas do CPF para nota fiscal
        public string CadastroCpf(DadosCliente CPF)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "insert into tb_cliente (nome, sobre_nome, cpf, fone, email, cep, endereco, bairro, cidade, uf, observacao) values ('', '', @cpf, '', '', '', '', '', '', '', '')";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@cpf", CPF.CPF);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao cadastrar CPF";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }

        }
    }

}
