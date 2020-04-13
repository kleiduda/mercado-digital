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
        public static string InsertCadastroCliente(string nome, string sobreNome, string cpf, string fone, string email, string cep, string endereco, string bairro, string cidade, string uf, string observacao)
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
            return obj.InsertCadastroCliente(obj);
        }
        //dados do cliente
        public static DataTable MostrarDadosCliente(string cpf)
        {
            DadosCliente obj = new DadosCliente();
            obj.CPF = cpf;
            return obj.MostrarDadosCliente(obj);
        }
    }
}
