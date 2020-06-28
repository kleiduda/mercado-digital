using Busines;
using Supporte.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using Supporte;

namespace Views.Produtos
{
    public partial class PedidoCompra_New : Form
    {
        private bool IsNew = true;
        public PedidoCompra_New()
        {
            InitializeComponent();
        }
        public PedidoCompra_New(string value)
        {
            InitializeComponent();
            lblPedido.Text = value;
        }

        private void PedidoCompra_New_Load(object sender, EventArgs e)
        {
            PedidoInfo();
            if (lblStatus.Text == "STATUS: Fechado")
            {
                DisableEdit();
            }
            Produtos();
            Fornecedores();
            ItemLista();
            lblVendedor.Text = "Vendedor: " + UserLoginCache.Nome.ToString() + " " + UserLoginCache.SobreNome.ToString();
            //Fornecedores();
        }

        private void pButtons_Paint(object sender, PaintEventArgs e)
        {
            Pen separador = new Pen(Color.Gray, 4);
            separador.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            //width, position 1, left distance, position 2
            e.Graphics.DrawLine(separador, 1900, 70, 20, 70);
            //textbox line
            Pen linhaTxt = new Pen(Color.Black, 1);
            linhaTxt.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            e.Graphics.DrawLine(linhaTxt, 600, 60, 130, 60);
        }
        private void PedidoInfo()
        {
            DataTable dt = new DataTable();
            dt = BPedidosCompra.PedidoCompra_Info(Convert.ToInt32(lblPedido.Text));
            lblStatus.Text = "STATUS: " + dt.Rows[0]["status"].ToString();
            cbFornecedor.Text = dt.Rows[0]["nome_fantasia"].ToString();
            txtObs.Text = dt.Rows[0]["observacao"].ToString();
        }
        private void ItemLista()
        {
            dgvPedido.DataSource = BPedidosCompra.PedidoCompra_ListarItem(Convert.ToInt32(lblPedido.Text));
            dgvPedido.Columns["id_pedido_compra"].Visible = false;
            dgvPedido.Columns["quantidade"].HeaderText = "Qtd";
            dgvPedido.Columns["preco"].HeaderText = "VL";
            dgvPedido.Columns["descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPedido.Columns["codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DataGridViewCellStyle style = dgvPedido.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.WhiteSmoke;
            style.ForeColor = Color.Black;
            style.Font = new Font("Open Sans", 7, FontStyle.Bold);
            style.SelectionBackColor = Color.WhiteSmoke;

            dgvPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPedido.ColumnHeadersHeight = 40;
            dgvPedido.ColumnHeadersVisible = true;


            if (dgvPedido.Rows.Count > 0)
            {
                lblItem.Visible = false;
            }

        }
        private void Fornecedores()
        {
            cbFornecedor.DataSource = BusinesFornecedor.Fornecedor_Lista();
            cbFornecedor.DisplayMember = "nome_fantasia";
            cbFornecedor.ValueMember = "id";
        }
        public void Produtos()
        {
            dgvRegistros.DataSource = BPedidosCompra.PedidoCompra_ListaProdutos();
            dgvRegistros.Columns["id_produto"].Visible = false;
            dgvRegistros.Columns["preco"].Visible = false;
            dgvRegistros.Columns["descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvRegistros.Columns["id_produto"].Width = 50;
            dgvRegistros.Columns["tipo_embalagem"].HeaderText = "T.Embalagem";
            dgvRegistros.Columns["qtd_embalagem"].HeaderText = "QTD.Embalagem";
            dgvRegistros.Columns["preco_unidade"].HeaderText = "Prç.Unidade";
            dgvRegistros.Columns["metro_cubico"].HeaderText = "CBM/CX";
            dgvRegistros.Columns["id_produto"].DisplayIndex = 1;
            dgvRegistros.Columns["codigo"].DisplayIndex = 2;
            dgvRegistros.Columns["descricao"].DisplayIndex = 3;
            dgvRegistros.Columns["tipo_embalagem"].DisplayIndex = 4;
            dgvRegistros.Columns["qtd_embalagem"].DisplayIndex = 5;
            dgvRegistros.Columns["preco_unidade"].DisplayIndex = 6;
            dgvRegistros.Columns["metro_cubico"].DisplayIndex = 7;
            dgvRegistros.Columns["obs"].DisplayIndex = 8;

            dgvRegistros.Columns["qtd"].DisplayIndex = 9;
            dgvRegistros.Columns["add"].DisplayIndex = 10;
            foreach (DataGridViewColumn dc in dgvRegistros.Columns)
            {
                if (dc.Index.Equals(0) || dc.Index.Equals(1))
                {
                    dc.ReadOnly = false;
                }
                else
                {
                    dc.ReadOnly = true;
                }
            }

        }
        public void PesquisaProduto()
        {
            dgvRegistros.DataSource = BPedidosCompra.PedidoCompra_PesquisaProduto(txtSearch.Text);
        }

        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string rpta = "";
                string obs = "";

                if (e.ColumnIndex == 2)
                {
                    if (dgvRegistros.CurrentRow.Cells["qtd"].Value == null)
                    {
                        MessageBox.Show("Quantidade não pode estar vazio!");
                    }
                    else
                    {
                        if (dgvRegistros.CurrentRow.Cells["obs"].Value == null)
                        {
                            dgvRegistros.CurrentRow.Cells["obs"].Value = "";
                        }
                        rpta = BPedidosCompra.PedidoCompra_AddItemPedido
                            (
                                Convert.ToInt32(lblPedido.Text),
                                Convert.ToInt32(dgvRegistros.CurrentRow.Cells["id_produto"].Value.ToString()),
                                Convert.ToInt32(dgvRegistros.CurrentRow.Cells["qtd"].Value.ToString()),
                                dgvRegistros.CurrentRow.Cells["obs"].Value.ToString()
                            ) ;
                    }
                    if (rpta.Equals("OK"))
                    {
                        dgvRegistros.CurrentRow.Cells["add"].Value = true;
                        ItemLista();
                    }
                    else
                    {
                        //MessageBox.Show(rpta);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            PesquisaProduto();
        }
        public void DisableEdit()
        {
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;
            dgvPedido.Enabled = false;
            dgvRegistros.Enabled = false;
            txtSearch.Enabled = false;
            cbFornecedor.Enabled = false;
            txtObs.Enabled = false;
        }
        public void EnableEdit()
        {
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            dgvPedido.Enabled = true;
            dgvRegistros.Enabled = true;
            txtSearch.Enabled = true;
            cbFornecedor.Enabled = true;
            txtObs.Enabled = true;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            try
            {
                if (MessageBox.Show("Fechar Pedido de Compra", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rpta = BPedidosCompra.PedidoCompra_Update
                        (
                            Convert.ToInt32(lblPedido.Text),
                            Convert.ToInt32(cbFornecedor.SelectedValue),
                            Convert.ToInt32(UserLoginCache.IdUser),
                            txtObs.Text,
                            Convert.ToInt32(Supporte.Enums.StatusPedido.Fechado)
                        );
                }
                if (rpta.Equals("OK"))
                {
                    DisableEdit();
                    PedidoInfo();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            try
            {
                if (MessageBox.Show("Editar Pedido de Compra", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rpta = BPedidosCompra.PedidoCompra_Update
                        (
                            Convert.ToInt32(lblPedido.Text),
                            Convert.ToInt32(cbFornecedor.SelectedValue),
                            Convert.ToInt32(UserLoginCache.IdUser),
                            txtObs.Text,
                            Convert.ToInt32(Supporte.Enums.StatusPedido.Aberto)
                        );
                }
                if (rpta.Equals("OK"))
                {
                    EnableEdit();
                    PedidoInfo();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DisableEdit();
        }
        public void exportarcsv()
        {
            DataTable dt = new DataTable();
            dt = BPedidosCompra.PedidoCompra_Lista();
            var lines = new List<string>();

            string[] columnNames = dt.Columns
                .Cast<DataColumn>()
                .Select(column => column.ColumnName)
                .ToArray();

            var header = string.Join(",", columnNames.Select(name => $"\"{name}\""));
            lines.Add(header);

            var valueLines = dt.AsEnumerable()
                .Select(row => string.Join(",", row.ItemArray.Select(val => $"\"{val}\"")));

            lines.AddRange(valueLines);

            File.WriteAllLines("excel.csv", lines);
            Process.Start("excel.csv");
        }


        public class Employee
        {
            private byte[] m_image;
            private string m_name;
            private int m_id;
            private int m_age;

            //Employee Image
            public byte[] Image
            {
                get
                {
                    return m_image;
                }
                set
                {
                    m_image = value;
                }
            }
            //Employee Name
            public string Name
            {
                get
                {
                    return m_name;
                }
                set
                {
                    m_name = value;
                }
            }
            //Employee ID
            public int Id
            {
                get
                {
                    return m_id;
                }
                set
                {
                    m_id = value;
                }
            }
            //Employee Age
            public int Age
            {
                get
                {
                    return m_age;
                }
                set
                {
                    m_age = value;
                }
            }
        }

        private List<DadosExcel> GetEmployeeDetails()
        {
            DataTable dt = new DataTable();
            dt = BusinesConfig.PathImage();
            string imagePath = dt.Rows[0]["image_path"].ToString();

            DataTable dtR = new DataTable();
            dtR = BPedidosCompra.PedidoCompra_DadosExcel(Convert.ToInt32(lblPedido.Text));

            //Instantiate employee list
            List<DadosExcel> employeeList = new List<DadosExcel>();

            //Set the details of employee and into employee list

            for (int i = 0; i < dtR.Rows.Count; i++)
            {
                //Percorrer as imagens dentro da pasta
                byte[] image = File.ReadAllBytes(imagePath.ToString() + dtR.Rows[i]["image"].ToString());
                DadosExcel emp = new DadosExcel();
                emp.Foto = image;
                emp.Codigo = dtR.Rows[i]["codigo"].ToString();
                emp.Descricao = dtR.Rows[i]["descricao"].ToString();
                emp.QtdCaixa = Convert.ToInt32(dtR.Rows[i]["qtd_embalagem"].ToString());
                emp.ValorUnidade = Convert.ToDecimal(dtR.Rows[i]["preco_unidade"].ToString());
                emp.Quantidade = Convert.ToInt32(dtR.Rows[i]["quantidade"].ToString());
                emp.Total = Convert.ToDecimal(dtR.Rows[i]["Total"].ToString());
                emp.MetroCubico = Convert.ToDecimal(dtR.Rows[i]["metro_cubico"].ToString());
                emp.TotalCBM = Convert.ToDecimal(dtR.Rows[i]["TotalCBM"].ToString());
                emp.MinimoVenda = Convert.ToInt32(dtR.Rows[i]["embalagem"].ToString());
                emp.CodBarra = dtR.Rows[i]["ean"].ToString();
                emp.Medida = dtR.Rows[i]["medida"].ToString();
                emp.ObsItem = dtR.Rows[i]["obs_item"].ToString();
                employeeList.Add(emp);
            }

            //DadosExcel emp = new DadosExcel();
            //emp.Foto = image;
            //emp.Codigo = dtR.Rows[0]["codigo"].ToString();
            //emp.Descricao = dtR.Rows[0]["descricao"].ToString();
            //emp.QtdCaixa = Convert.ToInt32(dtR.Rows[0]["qtd_embalagem"].ToString());
            //emp.ValorUnidade = Convert.ToDecimal(dtR.Rows[0]["preco_unidade"].ToString());
            //emp.Obs = dtR.Rows[0]["observacao"].ToString();
            //employeeList.Add(emp);

            //Return the employee list
            return employeeList;
        }
        public void ExportarImage()
        {
            //Instantiate the spreadsheet creation engine
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Instantiate the Excel application object
                IApplication application = excelEngine.Excel;

                //Create a new workbook and add a worksheet
                IWorkbook workbook = application.Workbooks.Create(1);
                IWorksheet worksheet = workbook.Worksheets[0];

                //Add the header text and assign cell style
                worksheet["A3"].Text = "Foto";
                worksheet["B3"].Text = "Codigo";
                worksheet["C3"].Text = "Descricao";
                worksheet["D3"].Text = "QT./CX";
                worksheet["E3"].Text = "VL";
                worksheet["F3"].Text = "PEDIDO";
                worksheet["G3"].Text = "TOTAL"; // QT.CX * VL * PEDIDO
                worksheet["H3"].Text = "CBM/CX";
                worksheet["I3"].Text = "TOTAL\nCBM/CX"; // PEDIDO * CBM/CX
                //
                worksheet["J3"].Text = "QUANT/\nEMBALAGEM";
                worksheet["K3"].Text = "COD_BARRA";
                worksheet["L3"].Text = "MEDIDA";
                worksheet["M3"].Text = "OBS"; //observacao do item
                worksheet["A3:I3"].CellStyle.Font.Bold = true;
               // worksheet["J3:M3"].CellStyle.F = Color.Red;
              //  worksheet["J3:M3"].CellStyle.FillBackground = ExcelKnownColors.Pale_blue;
                worksheet["A4"].Text = "%DadosExcel.Foto";
                worksheet["B4"].Text = "%DadosExcel.Codigo";
                worksheet["C4"].Text = "%DadosExcel.Descricao";
                worksheet["D4"].Text = "%DadosExcel.QtdCaixa";
                worksheet["E4"].Text = "%DadosExcel.ValorUnidade";
                worksheet["F4"].Text = "%DadosExcel.Quantidade";
                worksheet["G4"].Text = "%DadosExcel.Total";
                worksheet["H4"].Text = "%DadosExcel.MetroCubico";
                worksheet["I4"].Text = "%DadosExcel.TotalCBM";
                worksheet["J4"].Text = "%DadosExcel.MinimoVenda";
                worksheet["K4"].Text = "%DadosExcel.CodBarra";
                worksheet["L4"].Text = "%DadosExcel.Medida";
                worksheet["M4"].Text = "%DadosExcel.ObsItem";


                //worksheet["B4"].Text = "%DadosExcel.Codigo";
                //worksheet["C4"].Text = "%DadosExcel.Descricao";
                //worksheet["D4"].Text = "%DadosExcel.QtdCaixa";
                //worksheet["A4"].Text = "%DadosExcel.Foto";
                //worksheet["E4"].Text = "%DadosExcel.ValorUnidade";
                //worksheet["F4"].Text = "%DadosExcel.Obs";

                //Create template marker processor
                ITemplateMarkersProcessor marker = workbook.CreateTemplateMarkersProcessor();

                //Add marker variable
                marker.AddVariable("DadosExcel", GetEmployeeDetails());

                //Apply markers
                marker.ApplyMarkers();

                //Autofit the columns
                worksheet["B1:D10"].AutofitColumns();

                //Save the workbook
                string file = "pedido_de_compra_" + lblPedido.Text + ".xlsx";
                workbook.SaveAs(file);
                Process.Start(file);
            }
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarImage();
        }
    }
}
