using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Supporte.Cache;


namespace Dados
{
    public class DadosUsuario : Connection
    {
        public int IdVendedor { get; set; }
        public string Login { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int Cargo { get; set; }
        public string Senha { get; set; }

        public DadosUsuario() { }

        public DadosUsuario(int idVendedor, string login, string nome, string sobreNome, string email, string telefone, int cargo, string senha)
        {
            IdVendedor = idVendedor;
            this.Login = login;
            Nome = nome;
            SobreNome = sobreNome;
            Email = email;
            Telefone = telefone;
            Cargo = cargo;
            Senha = senha;
        }

        protected SqlCommand command = new SqlCommand();
        protected SqlDataReader dr;
        //pegando as funcoes de usuario
        //listando os usuarios
        public DataTable ListarUsuarios()
        {
            DataTable dt = new DataTable("vendedores");
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from tb_vendedor";
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
        public List<DadosUsuario> ListVendedorWithLista()
        {
            List<DadosUsuario> lista = new List<DadosUsuario>();

            using (var connection = GetConnection())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tb_vendedor";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DadosUsuario obj = new DadosUsuario();
                            obj.IdVendedor = reader.GetInt32(0);
                            obj.Login = reader.GetString(1);
                            obj.Nome = reader.GetString(2);
                            obj.SobreNome = reader.GetString(3);
                            obj.Email = reader.GetString(4);
                            obj.Telefone = reader.GetString(5);
                            obj.Cargo = reader.GetInt32(6);
                            lista.Add(obj);
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = null;
                }
                return lista;
            }

        }
        public DataTable ListFuncao()
        {
            DataTable dtResult = new DataTable();
            using (var connection = GetConnection())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tb_funcao";
                    command.CommandType = CommandType.Text;
                    SqlDataAdapter SqlDat = new SqlDataAdapter(command);
                    SqlDat.Fill(dtResult);

                }
                catch (Exception ex)
                {
                    dtResult = null;
                }
                return dtResult;

            }
        }
        public bool FuncaoUsuario(int idFuncao, string nomeFuncao)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tb_funcao";
                    command.CommandType = CommandType.Text;
                    dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            FuncaoCache.IdFuncao = idFuncao;
                            FuncaoCache.NomeFuncao = nomeFuncao;
                        }
                        return true;
                    }
                }
                catch (Exception ex)
                {

                }
                return false;
            }
        }
        //verificando se o usuario ja existe
        public bool Validate(DadosUsuario Usuario)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT login FROM tb_vendedor WHERE login = @login";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@login", Usuario.Login);

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
        //cadastro de novo usuario
        public string InsertUsuario(DadosUsuario Usuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO tb_vendedor (login, nome, sobre_nome, email, telefone, id_funcao, senha)" +
                        "VALUES (@login, @nome, @sobre_nome, @email, @telefone, @id_funcao, @senha)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@login", Usuario.Login);
                    command.Parameters.AddWithValue("@nome", Usuario.Nome);
                    command.Parameters.AddWithValue("@sobre_nome", Usuario.SobreNome);
                    command.Parameters.AddWithValue("@email", Usuario.Email);
                    command.Parameters.AddWithValue("@telefone", Usuario.Telefone);
                    command.Parameters.AddWithValue("@id_funcao", Usuario.Cargo);
                    command.Parameters.AddWithValue("@senha", Usuario.Senha);

                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao inserir cadastro de usuario";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        //editando o cadastro do usuario
        public string Edit(DadosUsuario Usuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE tb_vendedor SET login=@login, nome=@nome, sobre_nome=@sobre_nome, email=@email, telefone=@telefone, cargo=@cargo, senha=@senha" +
                        "WHERE id_vendedor=@id_vendedor";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id_vendedor", Usuario.IdVendedor);
                    command.Parameters.AddWithValue("@login", Usuario.Login);
                    command.Parameters.AddWithValue("@nome", Usuario.Nome);
                    command.Parameters.AddWithValue("@sobre_nome", Usuario.SobreNome);
                    command.Parameters.AddWithValue("@email", Usuario.Email);
                    command.Parameters.AddWithValue("@telefone", Usuario.Telefone);
                    command.Parameters.AddWithValue("@cargo", Usuario.Cargo);
                    command.Parameters.AddWithValue("@senha", Usuario.Senha);

                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao atualizar usuario";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                finally
                {
                    connection.Close();
                }
                return rpta;
            }
        }
        //pegando os dados dos usuarios
        public bool LoginUsuario(string user, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tb_vendedor where login=@login and senha=@password";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@login", user);
                    command.Parameters.AddWithValue("@password", password);
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            UserLoginCache.IdUser = dr.GetInt32(0);
                            UserLoginCache.Nome = dr.GetString(2);
                            UserLoginCache.SobreNome = dr.GetString(3);
                            UserLoginCache.Email = dr.GetString(4);
                            UserLoginCache.Cargo = dr.GetString(5);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }
    }
}
