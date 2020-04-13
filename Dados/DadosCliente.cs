﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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
        public DadosCliente()
        {

        }

        public DadosCliente(int idCliente, string nome, string sobreNome, string cPF, string fone, string email, string cEP, string endereco, string bairro, string cidade, string uF, string observacao)
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
        }
        protected SqlCommand command = new SqlCommand();
        protected SqlDataReader reader;
        public string InsertCadastroCliente(DadosCliente Cliente)
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
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao cadastrar cliente";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
            
        }
        //recuperar o cliente pelo CPF ou Nome
        public DataTable MostrarDadosCliente(DadosCliente Dados)
        {
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "DadosCliente";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@cpf", Dados.CPF);
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
}
