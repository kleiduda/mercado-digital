using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Microsoft.SqlServer.Server;

namespace Busines
{
   public class BusinesFornecedor
    {
        public static string Fornecedor_Cadastro(string cnpj, string nomeFantasia, string razaoSocial, string ie, string email, string fone, string whatsApp,
            string pais, string uf, string cidade, string bairro, string rua, string numero, string complemento, string cep, string contato)
        {
            DadosFornecedor obj = new DadosFornecedor();
            obj.Cnpj = cnpj;
            obj.NomeFantasia = nomeFantasia;
            obj.RazaoSocial = razaoSocial;
            obj.IE = ie;
            obj.Email = email;
            obj.Fone = fone;
            obj.WhatsApp = whatsApp;
            obj.Pais = pais;
            obj.UF = uf;
            obj.Cidade = cidade;
            obj.Bairro = bairro;
            obj.Rua = rua;
            obj.Numero = numero;
            obj.Complemento = complemento;
            obj.CEP = cep;
            obj.Contato = contato;
            return obj.Fornecedor_Cadastro(obj);
        }
        public static string Fornecedor_Update(int id, string cnpj, string nomeFantasia, string razaoSocial, string ie, string fone, string whatsApp,
            string pais, string uf, string cidade, string bairro, string rua, string numero, string complemento,string cep, string contato)
        {
            DadosFornecedor obj = new DadosFornecedor();
            obj.IDFornecedor = id;
            obj.Cnpj = cnpj;
            obj.NomeFantasia = nomeFantasia;
            obj.RazaoSocial = razaoSocial;
            obj.IE = ie;
            obj.Fone = fone;
            obj.WhatsApp = whatsApp;
            obj.Pais = pais;
            obj.UF = uf;
            obj.Cidade = cidade;
            obj.Bairro = bairro;
            obj.Rua = rua;
            obj.Numero = numero;
            obj.Complemento = complemento;
            obj.CEP = cep;
            obj.Contato = contato;
            return obj.Fornecedor_Update(obj);
        }
        public static bool Fornecedor_Valida(string cnpj)
        {
            DadosFornecedor obj = new DadosFornecedor();
            obj.Cnpj = cnpj;
            return obj.Fornecedor_Valida(obj);
        }
        public static string Fornecedor_Delete(int id)
        {
            DadosFornecedor obj = new DadosFornecedor();
            obj.IDFornecedor = id;
            return obj.Fornecedor_Delete(obj);
        }
        public static DataTable Fornecedor_Lista()
        {
            return new DadosFornecedor().Fornecedor_Lista();
        }

    }
}
