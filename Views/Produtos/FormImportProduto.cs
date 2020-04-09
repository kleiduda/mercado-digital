using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Busines;

namespace Views
{
    public partial class FormImportProduto : Form
    {
        private bool IsNew = true;
        string arquivoExcel = "@produtos.xlsx";
        public FormImportProduto()
        {
            InitializeComponent();
            ProgressBar.Visible = false;
            //circleProgres.Visible = false;
            //lblProgres.Visible = false;
            btnSqlServer.Visible = false;
        }
        private void FormImportProduto_Load(object sender, EventArgs e)
        {

        }
        //public void ValidateData()
        //{
        //    decimal total = 0;
        //    foreach (DataGridViewRow row in dgvDados.Rows)
        //    {
        //        for (int i = 0; i < row.Cells.Count; i++)
        //        {
        //            if (row.Cells[i].Value == null || row.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[i].Value.ToString()))
        //            {
        //                lblError.Text = Convert.ToString(row.Cells.Count);
        //            }

        //        }
        //    }

        //}
        private void MessageOK(string message)
        {
            MessageBox.Show(message, "Sistema de Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Mostrar Mensaje de Error
        private void MessageError(string message)
        {
            MessageBox.Show(message, "Sistema de Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private DataTable GetTabelaExcel(string arquivoExcel)
        {
            DataTable dt = new DataTable();
            try
            {
                //pega a extensão do arquivo
                string Ext = Path.GetExtension(arquivoExcel);
                string connectionString = "";
                //verifica a versão do Excel pela extensão
                if (Ext == ".xls")
                { //para o  Excel 97-03    
                    connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source =" + arquivoExcel + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                else if (Ext == ".xlsx")
                { //para o  Excel 07 e superior
                    connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + arquivoExcel + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                OleDbConnection conn = new OleDbConnection(connectionString);
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
                cmd.Connection = conn;
                conn.Open();
                DataTable dtSchema;
                dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string nomePlanilha = dtSchema.Rows[0]["TABLE_NAME"].ToString();
                conn.Close();
                //le todos os dados da planilha para o Data Table    
                conn.Open();
                cmd.CommandText = "SELECT * From [" + nomePlanilha + "]";
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        private void CarregaDadosExcel()
        {
            try
            {
                //limpa o combobox
                //cboBusca.Items.Clear();
                //converte os dados do Excel para um DataTable
                DataTable dt = GetTabelaExcel(arquivoExcel);
                //ajusta a largura das colunas aos dados
                dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvDados.DataSource = dt;
                //No total de registros
                //lblValidate.Text = "Seu arquivo tem " + (dgvDados.Rows.Count).ToString() + " linhas para serem importadas.";
                string[] listaNomeColunas = dt.Columns.OfType<DataColumn>().Select(x => x.ColumnName).ToArray();

                //Adiciona os nomes das colunas no Combobox
                //cboBusca.Items.AddRange(listaNomeColunas);
                //if (cboBusca.Items.Count > 0)
                //    cboBusca.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
        }

        private void btnLocalizarArquivoExcel_Click(object sender, EventArgs e)
        {
            DialogResult drResult = ofd1.ShowDialog();

            if (drResult == System.Windows.Forms.DialogResult.OK)
                txtArquivoExcel.Text = ofd1.FileName;

            if (!string.IsNullOrEmpty(txtArquivoExcel.Text) && File.Exists(txtArquivoExcel.Text))
            {
                arquivoExcel = txtArquivoExcel.Text;
                CarregaDadosExcel();
                //ValidateData();
                btnSqlServer.Visible = true;
            }
            else
            {
                CarregaDadosExcel();
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArquivoExcel.Text) && File.Exists(txtArquivoExcel.Text))
            {
                arquivoExcel = txtArquivoExcel.Text;
                CarregaDadosExcel();
                //ValidateData();
                btnSqlServer.Visible = true;
            }
            else
            {
                CarregaDadosExcel();
            }
        }

        //private void btnProcurar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ((DataTable)dgvDados.DataSource).DefaultView.RowFilter = string.Format("" + cboBusca.Text + " like '%{0}%'", txtCriterio.Text.Trim().Replace("'", "''"));
        //        lblRegistros.Text = (dgvDados.Rows.Count - 1).ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro :" + ex.Message);
        //    }
        //}

        private void btnExibirTodos_Click(object sender, EventArgs e)
        {
            CarregaDadosExcel();
        }


        //Import data for SQL SERVER
        private void backGroundWork_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(40);
                backGroundWork.WorkerReportsProgress = true;
                backGroundWork.ReportProgress(i);

            }
        }

        private void backGroundWork_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //ProgressBar.Value = e.ProgressPercentage;
            //lblProgres.Text = e.ProgressPercentage.ToString() + "%";
            //if (lblProgres.Text == "100%")
            //{
            //    MessageBox.Show("Dados importados com sucesso");
            //}
        }


        private void btnSqlServer_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (dgvDados.RowCount < 0)
                {
                    MessageError("Não há dados para importar");
                }
                else
                {

                    if (this.IsNew)
                    {
                        backGroundWork.RunWorkerAsync();
                       // lblProgres.Visible = true;
                        //circleProgres.Visible = true;
                        dgvDados.Visible = false;
                        for (int i = 0; i < dgvDados.Rows.Count; i++)
                        {
                            rpta = BusinesProduto.InsertRegister(
                                Convert.ToString(dgvDados.Rows[i].Cells["codigo"].Value.ToString().TrimEnd()),
                                Convert.ToString(dgvDados.Rows[i].Cells["ean"].Value.ToString().TrimEnd()),
                                Convert.ToString(dgvDados.Rows[i].Cells["descricao"].Value.ToString().TrimEnd()),
                                Convert.ToDecimal(dgvDados.Rows[i].Cells["preco"].Value.ToString().TrimEnd()),
                                Convert.ToDecimal(dgvDados.Rows[i].Cells["preco_promocional"].Value.ToString().TrimEnd()),
                                Convert.ToInt32(dgvDados.Rows[i].Cells["id_categoria"].Value.ToString().TrimEnd()),
                                Convert.ToString(dgvDados.Rows[i].Cells["imagem"].Value.ToString().TrimEnd()),
                                Convert.ToString(dgvDados.Rows[i].Cells["embalagem"].Value.ToString().TrimEnd()),
                                Convert.ToInt32(dgvDados.Rows[i].Cells["estoque"].Value.ToString().TrimEnd()));


                            ProgressBar.Value = i * ProgressBar.MaximumValue / dgvDados.Rows.Count + 1;
                            //lblProgres.Text = i.ToString() + " Linhas Importadas";
                            //lblProgres.Update();
                            //circleProgres.Value = i * ProgressBar.MaximumValue / dgvDados.Rows.Count + 1;
                            //circleProgres.Update();

                            //Application.DoEvents();
                            ProgressBar.Show();
                        }
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNew)
                        {
                            this.MessageOK("Produtos importados com sucesso!");
                        }
                        else
                        {
                            this.MessageOK("ok não");
                        }
                    }
                    else
                    {
                        this.MessageError(rpta);
                    }

                    IsNew = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtArquivoExcel_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the Dataformat of the data can be accepted
            // (we only accept file drops from Explorer, etc.)
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy; // Okay
            else
                e.Effect = DragDropEffects.None; // Unknown data, ignore it
        }

        private void txtArquivoExcel_DragDrop(object sender, DragEventArgs e)
        {
            // Extract the data from the DataObject-Container into a string list
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            // Do something with the data...

            // For example add all files into a simple label control:
            foreach (string File in FileList)
                this.txtArquivoExcel.Text += File;

            if (!string.IsNullOrEmpty(txtArquivoExcel.Text) && File.Exists(txtArquivoExcel.Text))
            {
                arquivoExcel = txtArquivoExcel.Text;
                CarregaDadosExcel();
                //ValidateData();
                btnSqlServer.Visible = true;
            }
            else
            {
                CarregaDadosExcel();
            }
        }

       
    }
}
