using System;
using System.Windows.Forms;

namespace Vaccines
{
    public partial class Vaccines : Form
    {
        int years;
        String FirstName, LastName, EGN, outstr;

        private void Form3_Load(object sender, EventArgs e)
        {
            outstr = FirstName + "-" + LastName + "-" + EGN + "-" + years.ToString() + "-";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            if (years >= 1 && years <= 6)
            {
                radioButton1.Checked = true;
                outstr += radioButton1.Text + ";";
            }
            else if (years >= 7 && years <= 12)
            {
                radioButton2.Checked = true;
                outstr += radioButton2.Text + ";";
            }
            else if (years >= 13 && years <= 18)
            {
                radioButton3.Checked = true;
                outstr += radioButton3.Text + ";";
            }

            listBox1.Items.Add(outstr);
        }

        public Vaccines(int _years, String _FirstName, String _LastName, String _EGN)
        {
            years = _years;
            FirstName = _FirstName;
            LastName = _LastName;
            EGN = _EGN;
            InitializeComponent();
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "E:\\Vaccines\\Vaccines\\bin\\Debug\\Vaccines.xlsx";

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;

            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];

            Range cellRange = ws.Range["A1:D1"];

            string[] data = new[] { FirstName, LastName, EGN, outstr };
            cellRange.set_Value(XlRangeValueDataType.xlRangeValueDefault, data);

            wb.SaveAs(filePath);
            wb.Close();

            //Process.Start(filePath);

            MessageBox.Show("Записано във файл Vaccines.xlsx");
        }*/

        /*private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }


            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[1, 1] = "Име";
            xlWorkSheet.Cells[1, 2] = "Фамилия";
            xlWorkSheet.Cells[1, 3] = "Години";
            xlWorkSheet.Cells[1, 4] = "ЕГН";


            xlWorkBook.SaveAs("d:\\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file d:\\csharp-Excel.xls");
    }*/
        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "E:\\Vaccines\\assets\\files\\Vaccines.xlsx";
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook sheet = excel.Workbooks.Open(filePath);
            Microsoft.Office.Interop.Excel.Worksheet x = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
            Microsoft.Office.Interop.Excel.Range userRange = x.UsedRange;

            int add = userRange.Rows.Count + 1;

            x.Cells[1, 1] = "Име";
            x.Cells[1, 2] = "Фамилия";
            x.Cells[1, 3] = "Години";
            x.Cells[1, 4] = "ЕГН";

            x.Cells[add, 1] = FirstName;
            x.Cells[add, 2] = LastName;
            x.Cells[add, 3] = years;
            x.Cells[add, 4] = EGN;


            //x.Cells[add, 1] = outstr;

            sheet.Close(true, Type.Missing, Type.Missing);
            excel.Quit();

            MessageBox.Show("Записано във файл Vaccines.xlsx");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
