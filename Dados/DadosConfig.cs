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
        protected SqlCommand command = new SqlCommand();
        protected SqlDataReader LerLinhas;
        //pegando valor da Path image
        public DataTable PathImage()
        {
            using (var connection = GetConnection())
            {
                DataTable dtResult = new DataTable("path");
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_configuracoes";
                    command.CommandType = CommandType.Text;

                    SqlDataAdapter sqlData = new SqlDataAdapter(command);
                    sqlData.Fill(dtResult);
                }
                catch (Exception ex)
                {
                    dtResult = null;
                }
                return dtResult;
            }

        }
        //cadastrando a pathimage
        public string CadastroPathImage(DadosConfig Path)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "ImagePath";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@image_path", Path.PatchImage);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao cadastrar a path";

                    command.Parameters.Clear();
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
