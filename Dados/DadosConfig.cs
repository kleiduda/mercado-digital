using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dados
{
    public class DadosConfig : Connection
    {
        public string PatchImage { get; set; }

        public DadosConfig() { }

        public DadosConfig(string patchImage)
        {
            PatchImage = patchImage;
        }

        // protected Connection Con = new Connection();
        protected SqlCommand Comando = new SqlCommand();
        protected SqlDataReader LerLinhas;

        public DataTable Config()
        {
            using (var connection = GetConnection())
            {
                DataTable dtResult = new DataTable("path");
                try
                {
                    connection.Open();
                    Comando.CommandText = "SELECT * FROM tb_configuracoes";
                    Comando.CommandType = CommandType.Text;

                    SqlDataAdapter sqlData = new SqlDataAdapter(Comando);
                    sqlData.Fill(dtResult);
                }
                catch (Exception ex)
                {
                    dtResult = null;
                }
                return dtResult;
            }

        }
        //public DataTable Config()
        //{
        //    var connection = GetConnection();
        //    DataTable dtResult = new DataTable("path");
        //    try
        //    {

        //        Comando.CommandText = "SELECT * FROM tb_configuracoes";
        //        Comando.CommandType = CommandType.Text;

        //        SqlDataAdapter sqlData = new SqlDataAdapter(Comando);
        //        sqlData.Fill(dtResult);
        //    }
        //    catch (Exception ex)
        //    {
        //        dtResult = null;
        //    }
        //    return dtResult;
        //}
    }
}
