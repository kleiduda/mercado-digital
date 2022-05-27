using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dados
{
   public abstract class Connection
    {
        private readonly string connectionString;
        
        public Connection()
        {
            //connectionString = @"Server=DESKTOP-AHJ1VA6\SQLEXPRESS; DataBase=dbMercado; Integrated Security=true";
            connectionString = @"Server=localhost\SQLEXPRESS;Database=dbMercado;Trusted_Connection=True;";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        //public string serverConection { get; set; }

        ////static private string ServerConexao = @"Server=DESKTOP-O47R53V\SQLEXPRESS; DataBase=dbMercado; Integrated Security=true";
        //static private string ServerConexao = @"Server=DESKTOP-JNLM84J\SQLEXPRESS; DataBase=dbMercado; Integrated Security=true";
        ////static private string ServerConexao = @"Data Source=170.81.41.175,1433;Network Library=DBMSSOCN;Initial Catalog=dbStudio;User ID=root;Password=Alliance@2020; ";
        //private SqlConnection Conexao = new SqlConnection(ServerConexao);

        ////abrindo a conexão
        //public SqlConnection OpenConection()
        //{
        //    if (Conexao.State == ConnectionState.Closed)

        //        Conexao.Open();
        //    return Conexao;
        //}

        ////fechando a conexão
        //public SqlConnection ClosedConection()
        //{
        //    if (Conexao.State == ConnectionState.Open)
        //        Conexao.Close();
        //    return Conexao;

        //}
    }
}
