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
        public bool Login(string user, string password)
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
