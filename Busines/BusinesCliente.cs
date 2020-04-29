using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Busines
{
    public class BusinesCliente
    {
        public static string CadastroNovoContaFiado(string nome, string sobreNome, string cpf, string fone, string email, string cep, 
            string endereco, string bairro, string cidade, string uf, string observacao, int idPedido, decimal saldoDevedor)
        {
            DadosCliente obj = new DadosCliente();
            obj.Nome = nome;
            obj.SobreNome = sobreNome;
            obj.CPF = cpf;
            obj.Fone = fone;
            obj.Email = email;
            obj.CEP = cep;
            obj.Endereco = endereco;
            obj.Bairro = bairro;
            obj.Cidade = cidade;
            obj.UF = uf;
            obj.Observacao = observacao;
            obj.IdPedido = idPedido;
            obj.SaldoDevedor = saldoDevedor;
            return obj.CadastroNovoContaFiado(obj);
        }
        //dados do cliente
        DadosCliente obj = new DadosCliente();
        public static bool ConsultaCadastroCliente(string cpf)
        {
            DadosCliente obj = new DadosCliente();
            obj.CPF = cpf;
            return obj.ConsultaCadastroCliente(obj);
        }
        //listando os dados cadastrais do cliente que qianda nao tem conta fiado
        public static DataTable ListarClientes()
        {
            return new DadosCliente().ListarClientes();
        }
        public static DataTable MostrarDadosFiado(string cpf)
        {
            DadosCliente obj = new DadosCliente();
            obj.CPF = cpf;
            return obj.DadosFiadoCliente(obj);
        }
        public static bool ValidaCadastro(string cpf)
        {
            DadosCliente obj = new DadosCliente();
            obj.CPF = cpf;
            return obj.ValidarCadastro(obj);
        }
        //cadastro cpf
        public static string CadastroCpf(string cpf)
        {
            DadosCliente obj = new DadosCliente();
            obj.CPF = cpf;
            return obj.CadastroCpf(obj);
        }
    }
}
