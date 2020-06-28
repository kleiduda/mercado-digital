using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dados
{
    public class DadosFornecedor : Connection
    {
        public int IDFornecedor { get; set; }
        public string Cnpj { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string IE { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }
        public string WhatsApp { get; set; }
        public int IDEndereco { get; set; }
        //enderecp
        public string Pais { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Contato { get; set; }

        public DadosFornecedor(int iDFornecedor, string cnpj, string nomeFantasia, string razaoSocial, string iE, string email, string fone, string whatsApp, int iDEndereco, string pais, string uF, string cidade, string bairro, string rua, string numero, string complemento, string cEP, string contato)
        {
            IDFornecedor = iDFornecedor;
            Cnpj = cnpj;
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            IE = iE;
            Email = email;
            Fone = fone;
            WhatsApp = whatsApp;
            IDEndereco = iDEndereco;
            Pais = pais;
            UF = uF;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            CEP = cEP;
            Contato = contato;
        }

        public DadosFornecedor()
        {

        }

        protected SqlCommand command = new SqlCommand();
        protected SqlDataReader dr;

        //register
        public string Fornecedor_Cadastro(DadosFornecedor FORNECEDOR)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "Fornecedor_Cadastro";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@cnpj", FORNECEDOR.Cnpj);
                    command.Parameters.AddWithValue("@nome_fantasia", FORNECEDOR.NomeFantasia);
                    command.Parameters.AddWithValue("@razao_social", FORNECEDOR.RazaoSocial);
                    command.Parameters.AddWithValue("@ie", FORNECEDOR.IE);
                    command.Parameters.AddWithValue("@email", FORNECEDOR.Email);
                    command.Parameters.AddWithValue("@fone", FORNECEDOR.Fone);
                    command.Parameters.AddWithValue("@whatsapp", FORNECEDOR.WhatsApp);
                    //
                    command.Parameters.AddWithValue("@pais", FORNECEDOR.Pais);
                    command.Parameters.AddWithValue("@cidade", FORNECEDOR.Cidade);
                    command.Parameters.AddWithValue("@uf", FORNECEDOR.UF);
                    command.Parameters.AddWithValue("@bairro", FORNECEDOR.Bairro);
                    command.Parameters.AddWithValue("@rua", FORNECEDOR.Rua);
                    command.Parameters.AddWithValue("@numero", FORNECEDOR.Numero);
                    command.Parameters.AddWithValue("@complemento", FORNECEDOR.Complemento);
                    command.Parameters.AddWithValue("@cep", FORNECEDOR.CEP);
                    command.Parameters.AddWithValue("@contato", FORNECEDOR.Contato);
                    //
                    rpta = command.ExecuteNonQuery() == 2 ? "OK" : "Erro ao cadastrar";

                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        //show
        public DataTable Fornecedor_Lista()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT f.id, f.nome_fantasia, f.cnpj, f.email, f.fone, e.uf, e.cidade " +
                        "FROM tb_fornecedores f INNER JOIN tb_endereco e ON f.id = e.id_fornecedor";
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
        public DataTable Fornecedor_ListaDetalhe()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "";
                    command.CommandType = CommandType.Text;
                }
                catch (Exception ex)
                {
                    dt = null;
                }
                return dt;
            }
        }

        //update
        public string Fornecedor_Update(DadosFornecedor UPDATE)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "Forncedor_Update";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", UPDATE.IDFornecedor);
                    command.Parameters.AddWithValue("@cnpj", UPDATE.Cnpj);
                    command.Parameters.AddWithValue("@nome_fantasia", UPDATE.NomeFantasia);
                    command.Parameters.AddWithValue("@razao_social", UPDATE.RazaoSocial);
                    command.Parameters.AddWithValue("@ie", UPDATE.IE);
                    command.Parameters.AddWithValue("@email", UPDATE.Email);
                    command.Parameters.AddWithValue("@fone", UPDATE.Fone);
                    command.Parameters.AddWithValue("@whatsapp", UPDATE.WhatsApp);
                    //
                    command.Parameters.AddWithValue("@pais", UPDATE.Pais);
                    command.Parameters.AddWithValue("@cidade", UPDATE.Cidade);
                    command.Parameters.AddWithValue("@uf", UPDATE.UF);
                    command.Parameters.AddWithValue("@bairro", UPDATE.Bairro);
                    command.Parameters.AddWithValue("@rua", UPDATE.Rua);
                    command.Parameters.AddWithValue("@numero", UPDATE.Numero);
                    command.Parameters.AddWithValue("@complemento", UPDATE.Complemento);
                    command.Parameters.AddWithValue("@cep", UPDATE.CEP);
                    command.Parameters.AddWithValue("@contato", UPDATE.Contato);
                    //
                    rpta = command.ExecuteNonQuery() == 2 ? "OK" : "Erro ao atualizar";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        //delete
        public string Fornecedor_Delete(DadosFornecedor DELETE)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE * FROM tb_fornecedor WHERE id=@id";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id", DELETE.IDFornecedor);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "erro ao deletar";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        //validate
        public bool Fornecedor_Valida(DadosFornecedor VALIDA)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_fornecedor WHERE cnpj=@cnpj";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@cnpj", VALIDA.Cnpj);
                    var result = command.ExecuteScalar();
                    if (result !=null)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    var exception = ex.Message;
                }
                return false;
            }
        }
    }
}
