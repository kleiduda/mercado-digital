using Syncfusion.XlsIO;
using System.Collections.Generic;
using System.IO;

namespace ExportDataTableWithImagesToExcel
{
    class Program
    {
        static void Main(string[] args)
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
                worksheet["A3"].Text = "FOTO";
                worksheet["B3"].Text = "Descricao";
                worksheet["C3"].Text = "QT.CX";
                worksheet["D3"].Text = "Vl";
                worksheet["E3"].Text = "CBM/CX";
                worksheet["F3"].Text = "QUANT / EMBALAGEM";
                worksheet["G3"].Text = "COD_BARRA";
                worksheet["H3"].Text = "MEDIDA";
                worksheet["I3"].Text = "OBS";
                worksheet["A3:DI"].CellStyle.Font.Bold = true;

                worksheet["B4"].Text = "%Employee.Name";
                worksheet["C4"].Text = "%Employee.Id";
                worksheet["D4"].Text = "%Employee.Age";
                worksheet["A4"].Text = "%Employee.Image";

                //Create template marker processor
                ITemplateMarkersProcessor marker = workbook.CreateTemplateMarkersProcessor();

                //Add marker variable
                marker.AddVariable("Employee", GetEmployeeDetails());

                //Apply markers
                marker.ApplyMarkers();

                //Autofit the columns
                worksheet["B1:D10"].AutofitColumns();

                //Save the workbook
                workbook.SaveAs("Output.xlsx");

                System.Diagnostics.Process.Start("Output.xlsx");
            }
        }
        private static List<Employee> GetEmployeeDetails()
        {
            //Get the images from folder
            byte[] image1 = File.ReadAllBytes(@"../../Data/Man1.jpg");
            byte[] image2 = File.ReadAllBytes(@"../../Data/Man2.png");
            byte[] image3 = File.ReadAllBytes(@"../../Data/Woman1.jpg");

            //Instantiate employee list
            List<Employee> employeeList = new List<Employee>();

            //Set the details of employee and into employee list
            Employee emp = new Employee();
            emp.Image = image1;
            emp.Name = "Andy Bernard";
            emp.Id = 1011;
            emp.Age = 35;
            employeeList.Add(emp);

            //Set the details of employee and into employee list
            emp = new Employee();
            emp.Image = image2;
            emp.Name = "Karen Fillippelli";
            emp.Id = 1012;
            emp.Age = 26;
            employeeList.Add(emp);

            //Set the details of employee and into employee list
            emp = new Employee();
            emp.Image = image3;
            emp.Name = "Patricia Mckenna";
            emp.Id = 1013;
            emp.Age = 28;
            employeeList.Add(emp);

            //Return the employee list
            return employeeList;
        }
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
}