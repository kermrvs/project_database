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
using Excel = Microsoft.Office.Interop.Excel;

namespace Диплом
{
    public partial class DeletefForm : UserControl
    {
        public DeletefForm()
        {
            InitializeComponent();
        }
        string ConnectingString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\SQL-server2017\MSSQL14.SQLEXPRESS\MSSQL\DATA\Test_DB.mdf;Integrated Security=True;Connect Timeout=30";
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            if (textBox1.Text != "" && textBox2.Text != "" && richTextBox1.Text != "")
            {
                int s;
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    s = (int)dataGridView2.Rows[i].Cells[4].Value;
                    if (s == Convert.ToInt32(textBox2.Text))
                    {
                           SqlConnection sql = new SqlConnection(ConnectingString);
                           string sqlint = @"INSERT INTO Списання(Назва_техніки,U_ID,Дата,Причина) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + dateTimePicker1.Text + "','" + richTextBox1.Text + "')";
                           sql.Open();
                           SqlCommand sqcint = new SqlCommand(sqlint, sql);
                           sqcint.ExecuteNonQuery();
                           sql.Close();
                           Display();
                           if (comboBox1.Text == "Танк" || comboBox1.Text == "БМП")
                           {
                               string sqldel = @"DELETE from Склад_1 where U_ID = '" + textBox2.Text + "'";
                               sql.Open();
                               SqlCommand sqcdel = new SqlCommand(sqldel, sql);
                               sqcdel.ExecuteNonQuery();
                               sql.Close();
                           }
                           if (comboBox1.Text == "БТР" || comboBox1.Text == "МУ")
                           {
                               string sqldel = @"DELETE from Склад_2 where U_ID = '" + textBox2.Text + "'";
                               sql.Open();
                               SqlCommand sqcdel = new SqlCommand(sqldel, sql);
                               sqcdel.ExecuteNonQuery();
                               sql.Close();
                           }
                           if (comboBox1.Text == "ОТРК" || comboBox1.Text == "РСЗО" || comboBox1.Text == "САУ")
                           {
                               string sqldel = @"DELETE from Склад_3 where U_ID = '" + textBox2.Text + "'";
                               sql.Open();
                               SqlCommand sqcdel = new SqlCommand(sqldel, sql);
                               sqcdel.ExecuteNonQuery();
                               sql.Close();
                           }
                           if (comboBox1.Text == "ПВО" || comboBox1.Text == "ПРО")
                           {
                               string sqldel = @"DELETE from Склад_4 where U_ID = '" + textBox2.Text + "'";
                               sql.Open();
                               SqlCommand sqcdel = new SqlCommand(sqldel, sql);
                               sqcdel.ExecuteNonQuery();
                               sql.Close();
                           }
                           if (comboBox1.Text == "Дрібна зброя")
                           {
                               string sqldel = @"DELETE from Склад_5 where U_ID = '" + textBox2.Text + "'";
                               sql.Open();
                               SqlCommand sqcdel = new SqlCommand(sqldel, sql);
                               sqcdel.ExecuteNonQuery();
                               sql.Close();
                           }
                           if (comboBox1.Text == "Додаткова_техніка")
                           {
                               string sqldel = @"DELETE from Склад_дот_прил where U_ID = '" + textBox2.Text + "'";
                               sql.Open();
                               SqlCommand sqcdel = new SqlCommand(sqldel, sql);
                               sqcdel.ExecuteNonQuery();
                               sql.Close();
                           }
                           
                        
                        break;
                        

                    }
                    else
                    {

                        continue;
                        
                    }
                   



                }
            }
            if (comboBox1.Text == "Танк" || comboBox1.Text == "БМП")
            {
                SqlConnection sql = new SqlConnection(ConnectingString);
                string sqlcont = @"select * from Склад_1";
                sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlcont, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            if (comboBox1.Text == "БТР" || comboBox1.Text == "МУ")
            {
                SqlConnection sql = new SqlConnection(ConnectingString);
                string sqlcont = @"select * from Склад_2";
                sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlcont, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            if (comboBox1.Text == "ОТРК" || comboBox1.Text == "РСЗО" || comboBox1.Text == "САУ")
            {
                SqlConnection sql = new SqlConnection(ConnectingString);
                string sqlcont = @"select * from Склад_3";
                sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlcont, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            if (comboBox1.Text == "ПВО" || comboBox1.Text == "ПРО")
            {
                SqlConnection sql = new SqlConnection(ConnectingString);
                string sqlcont = @"select * from Склад_4";
                sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlcont, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            if (comboBox1.Text == "Дрібна зброя")
            {
                SqlConnection sql = new SqlConnection(ConnectingString);
                string sqlcont = @"select * from Склад_5";
                sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlcont, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            if (comboBox1.Text == "Додаткова_техніка")
            {
                SqlConnection sql = new SqlConnection(ConnectingString);
                string sqlcont = @"select * from Склад_дот_прил";
                sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlcont, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }

        }
        private void Display()
        {
            SqlConnection sql = new SqlConnection(ConnectingString);
            string sqlcont = @"select * from Списання";
            sql.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcont, sql);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button3.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            dateTimePicker1.Enabled = true;
            richTextBox1.Enabled = true;
            if (comboBox1.Text == "Танк" || comboBox1.Text == "БМП")
            {
                SqlConnection sql = new SqlConnection(ConnectingString);
                string sqlcont = @"select * from Склад_1";
                sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlcont, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            if (comboBox1.Text == "БТР" || comboBox1.Text == "МУ")
            {
                SqlConnection sql = new SqlConnection(ConnectingString);
                string sqlcont = @"select * from Склад_2";
                sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlcont, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            if (comboBox1.Text == "ОТРК" || comboBox1.Text == "РСЗО" || comboBox1.Text == "САУ")
            {
                SqlConnection sql = new SqlConnection(ConnectingString);
                string sqlcont = @"select * from Склад_3";
                sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlcont, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            if (comboBox1.Text == "ПВО" || comboBox1.Text == "ПРО")
            {
                SqlConnection sql = new SqlConnection(ConnectingString);
                string sqlcont = @"select * from Склад_4";
                sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlcont, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            if (comboBox1.Text == "Дрібна зброя")
            {
                SqlConnection sql = new SqlConnection(ConnectingString);
                string sqlcont = @"select * from Склад_5";
                sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlcont, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            if (comboBox1.Text == "Додаткова_техніка")
            {
                SqlConnection sql = new SqlConnection(ConnectingString);
                string sqlcont = @"select * from Склад_дот_прил";
                sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlcont, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if(e.KeyChar == (char) Keys.Back)
            {
                return;
            }
            e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Excel.Application ex = new Excel.Application();

            Excel.Workbook workbook = ex.Workbooks.Add();

            Excel.Worksheet worksheet = workbook.ActiveSheet;
            

            for (int i = 1; i < dataGridView1.RowCount + 1; i++)
            {
                for (int j = 1; j < dataGridView1.ColumnCount + 1; j++)
                {
                    worksheet.Rows[i].Columns[j] = dataGridView1.Rows[i - 1].Cells[j - 1].Value;
                }
            }
            worksheet.Cells[1, 1] = "Id";
            worksheet.Cells[1, 2] = "Назва";
            worksheet.Cells[1, 3] = "U_ID";
            worksheet.Cells[1, 4] = "Вид";
            worksheet.Cells[1, 5] = "Дата";
            worksheet.Cells[1, 6] = "Причина";
            
            
            ex.DisplayAlerts = true;
            workbook.SaveAs(@"C:\Users\андрей\source\repos\Диплом\Диплом\Списання.xlsx");
            ex.Quit();
        }
    }

}
