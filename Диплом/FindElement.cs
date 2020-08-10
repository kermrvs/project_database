using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

using System.IO;

namespace Диплом
{
    public partial class FindElement : UserControl
    {
        public FindElement()
        {
            InitializeComponent();
        }
        string connectingstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\SQL-server2017\MSSQL14.SQLEXPRESS\MSSQL\DATA\Test_DB.mdf;Integrated Security=True;Connect Timeout=30";
        private void button1_Click(object sender, EventArgs e)
        {
            
                if (ListBox.Text == "Склад№1(танки та БМП)")
                {
                    string sqlzap = "SELECT * from Склад_1";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
                if (ListBox.Text == "Склад№2(БТР і МУ)")
                {
                    string sqlzap = "SELECT * from Склад_2";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
                if (ListBox.Text == "Склад№3(ОТРК, РСЗО і САУ)")
                {
                    string sqlzap = "SELECT * from Склад_3";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
                if (ListBox.Text == "Склад№4(ПВО і ПРС)")
                {
                    string sqlzap = "SELECT * from Склад_4";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
                if (ListBox.Text == "Склад№5(Дрібна зброя)")
                {
                    string sqlzap = "SELECT * from Склад_5";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
                if (ListBox.Text == "Склад_дот_приладів")
                {
                    string sqlzap = "SELECT * from Склад_дот_прил";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(NameTextBox.Text == "" && IDTextBOX.Text == "" && KindBox.Text == "")
            {
                MessageBox.Show("Введіть значення для пошуку");
            }
            if(NameTextBox.Text != "" && IDTextBOX.Text == "" && KindBox.Text == "")
            {
                if (ListBox.Text == "Склад№1(танки та БМП)")
                {
                    string sqlzap = "SELECT * from Склад_1 where Назва_техніки = '" + NameTextBox.Text + "'";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
                if (ListBox.Text == "Склад№2(БТР і МУ)")
                {
                    string sqlzap = "SELECT * from Склад_2 where Назва_техніки = '" + NameTextBox.Text + "'";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
                if (ListBox.Text == "Склад№3(ОТРК, РСЗО і САУ)")
                {
                    string sqlzap = "SELECT * from Склад_3 where Назва_техніки = '" + NameTextBox.Text + "'";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
                if (ListBox.Text == "Склад№4(ПВО і ПРС)")
                {
                    string sqlzap = "SELECT * from Склад_4 where Назва_техніки = '" + NameTextBox.Text + "'";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
                if (ListBox.Text == "Склад№5(Дрібна зброя)")
                {
                    string sqlzap = "SELECT * from Склад_5 where Назва_техніки = '" + NameTextBox.Text + "'";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
                if (ListBox.Text == "Склад_дот_приладів")
                {
                    string sqlzap = "SELECT * from Склад_дот_прил where Назва_техніки = '" + NameTextBox.Text + "'";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
            }
            if(IDTextBOX.Text != "" && NameTextBox.Text == "" && KindBox.Text == "")
            {
                if (ListBox.Text == "Склад№1(танки та БМП)")
                {
                    string sqlzap = "SELECT * from Склад_1 where U_ID = '" + IDTextBOX.Text + "'";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
                if (ListBox.Text == "Склад№2(БТР і МУ)")
                {
                    string sqlzap = "SELECT * from Склад_2 where U_ID = '" + IDTextBOX.Text + "'";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
                if (ListBox.Text == "Склад№3(ОТРК, РСЗО і САУ)")
                {
                    string sqlzap = "SELECT * from Склад_3 where U_ID = '" + IDTextBOX.Text + "'";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
                if (ListBox.Text == "Склад№4(ПВО і ПРС)")
                {
                    string sqlzap = "SELECT * from Склад_4 where U_ID = '" + IDTextBOX.Text + "'";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
                if (ListBox.Text == "Склад№5(Дрібна зброя)")
                {
                    string sqlzap = "SELECT * from Склад_5 where U_ID = '" + IDTextBOX.Text + "'";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
                if (ListBox.Text == "Склад_дот_приладів")
                {
                    string sqlzap = "SELECT * from Склад_дот_прил where U_ID = '" + IDTextBOX.Text + "'";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
            
            
            }
            if(KindBox.Text != "" && IDTextBOX.Text == "" && NameTextBox.Text == "")
            {
                if (ListBox.Text == "Склад№1(танки та БМП)")
                {
                    string sqlzap = "SELECT * from Склад_1 where Вид = '" + KindBox.Text + "'";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
                if (ListBox.Text == "Склад№2(БТР і МУ)")
                {
                    string sqlzap = "SELECT * from Склад_2 where Вид = '" + KindBox.Text + "'";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
                if (ListBox.Text == "Склад№3(ОТРК, РСЗО і САУ)")
                {
                    string sqlzap = "SELECT * from Склад_3 where Вид = '" + KindBox.Text + "'";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
                if (ListBox.Text == "Склад№4(ПВО і ПРС)")
                {
                    string sqlzap = "SELECT * from Склад_4 where Вид = '" + KindBox.Text + "'";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
                if (ListBox.Text == "Склад№5(Дрібна зброя)")
                {
                    string sqlzap = "SELECT * from Склад_5 where Вид = '" + KindBox.Text + "'";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
                if (ListBox.Text == "Склад_дот_приладів")
                {
                    string sqlzap = "SELECT * from Склад_дот_прил where Вид = '" + KindBox.Text + "'";
                    SqlConnection sqlcon = new SqlConnection(connectingstring);
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
            }
            
        }

        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            KindBox.Enabled = false;
            IDTextBOX.Enabled = false;

        }

        private void NameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (NameTextBox.Text == "")
            {
                KindBox.Enabled = true;
                IDTextBOX.Enabled = true;
            }
        }

        private void IDTextBOX_KeyDown(object sender, KeyEventArgs e)
        {
            KindBox.Enabled = false;
            NameTextBox.Enabled = false;
        }

        private void IDTextBOX_KeyUp(object sender, KeyEventArgs e)
        {
            if (IDTextBOX.Text == "")
            {
                KindBox.Enabled = true;
                NameTextBox.Enabled = true;
            }
        }

        private void KindBox_KeyDown(object sender, KeyEventArgs e)
        {
            IDTextBOX.Enabled = false;
            NameTextBox.Enabled = false;
        }

        private void KindBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (KindBox.Text == "")
            {
                IDTextBOX.Enabled = true;
                NameTextBox.Enabled = true;
            }
        }
        bool des = true;
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (des)
            {
                if (ListBox.Text == "Склад№1(танки та БМП)")
                {
                    dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
                    des = false;
                }
                else
                {
                    dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
                    des = true;
                }
                if (ListBox.Text == "Склад№2(БТР і МУ)")
            {
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
            }
            else
            {
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
                des = false;
            }
            if (ListBox.Text == "Склад№3(ОТРК, РСЗО і САУ)")
            {
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
            }
            else
            {
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
                des = false;
            }
            if (ListBox.Text == "Склад№4(ПВО і ПРС)")
            {
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
            }
            else
            {
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
                des = false;
            }
            if (ListBox.Text == "Склад№5(Дрібна зброя)")
            {
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
            }
            else
            {
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
                des = false;
            }
            if (ListBox.Text == "Склад_дот_приладів")
            {
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);
            }
            else
            {
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
                des = false;
            }
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveIntoExel();
        }
        void SaveIntoExel()
        {
            Excel.Application ex = new Excel.Application();
            
            Excel.Workbook workbook = ex.Workbooks.Add();
            
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            
            

            for (int i = 2; i < dataGridView1.RowCount + 1; i++)
            {
                for (int j = 1; j < dataGridView1.ColumnCount + 1; j++)
                {
                        
                    worksheet.Rows[i].Columns[j] = dataGridView1.Rows[i - 1].Cells[j - 1].Value;
                }
            }
            if (ListBox.Text == "Склад№1(танки та БМП)")
            {
                worksheet.Cells[1, 1] = "Id";
                worksheet.Cells[1, 2] = "Назва";
                worksheet.Cells[1, 3] = "Вид";
                worksheet.Cells[1, 4] = "Озброєння";
                worksheet.Cells[1, 5] = "U_ID";
                ex.DisplayAlerts = true;
                workbook.SaveAs(@"C:\Users\андрей\source\repos\Диплом\Диплом\Склад_1.xlsx");
                ex.Quit();
            }
            if (ListBox.Text == "Склад№2(БТР і МУ)")
            {
                worksheet.Cells[1, 1] = "Id";
                worksheet.Cells[1, 2] = "Назва";
                worksheet.Cells[1, 3] = "Вид";
                worksheet.Cells[1, 4] = "Озброєння";
                worksheet.Cells[1, 5] = "U_ID";
                ex.DisplayAlerts = true;
                workbook.SaveAs(@"C:\Users\андрей\source\repos\Диплом\Диплом\Склад_2.xlsx");
                ex.Quit();
            }
            if (ListBox.Text == "Склад№3(ОТРК, РСЗО і САУ)")
            {
                worksheet.Cells[1, 1] = "Id";
                worksheet.Cells[1, 2] = "Назва";
                worksheet.Cells[1, 3] = "Вид";
                worksheet.Cells[1, 4] = "Озброєння";
                worksheet.Cells[1, 5] = "U_ID";
                ex.DisplayAlerts = true;
                workbook.SaveAs(@"C:\Users\андрей\source\repos\Диплом\Диплом\Склад_3.xlsx");
                ex.Quit();
            }
            if (ListBox.Text == "Склад№4(ПВО і ПРС)")
            {
                worksheet.Cells[1, 1] = "Id";
                worksheet.Cells[1, 2] = "Назва";
                worksheet.Cells[1, 3] = "Вид";
                worksheet.Cells[1, 4] = "Озброєння";
                worksheet.Cells[1, 5] = "U_ID";
                ex.DisplayAlerts = true;
                workbook.SaveAs(@"C:\Users\андрей\source\repos\Диплом\Диплом\Склад_4.xlsx");
                ex.Quit();
            }
            if (ListBox.Text == "Склад№5(Дрібна зброя)")
            {
                worksheet.Cells[1, 1] = "Id";
                worksheet.Cells[1, 2] = "Назва";
                worksheet.Cells[1, 3] = "Вид";
                worksheet.Cells[1, 4] = "Калібр";
                worksheet.Cells[1, 5] = "U_ID";
                ex.DisplayAlerts = true;
                workbook.SaveAs(@"C:\Users\андрей\source\repos\Диплом\Диплом\Склад_5.xlsx");
                ex.Quit();
            }
            if (ListBox.Text == "Склад_дот_приладів")
            {
                worksheet.Cells[1, 1] = "Id";
                worksheet.Cells[1, 2] = "Назва";
                worksheet.Cells[1, 3] = "призначення";
                worksheet.Cells[1, 4] = "U_ID";
                ex.DisplayAlerts = true;
                workbook.SaveAs(@"C:\Users\андрей\source\repos\Диплом\Диплом\Склад_6.xlsx");
                ex.Quit();
            }
        }

        private void IDTextBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            e.Handled = true;
        }
    }     
    
}
