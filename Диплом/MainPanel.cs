using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace Диплом
{
    public partial class MainPanel : UserControl
    {
        public MainPanel()
        {
            InitializeComponent();
            
        }
        bool ok = false;
        string connectString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\SQL-server2017\MSSQL14.SQLEXPRESS\MSSQL\DATA\Test_DB.mdf;Integrated Security=True;Connect Timeout=30";
        //string coonecti = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\андрей\source\repos\Диплом\Диплом\диплом.mdf;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Введите даные во все поля");
            }
            
            int s;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                s = (int)dataGridView1.Rows[i].Cells[6].Value;
                
                if(textBox6.Text == "")
                {
                    MessageBox.Show("Введіть значення");
                    break;
                }
                if (s == Convert.ToInt32(textBox6.Text))
                {
                    MessageBox.Show("Техника с таким кодом уже есть");
                    ok = false;
                    break;
                }
                if(s != Convert.ToInt32(textBox6.Text))
                {
                    ok = true;
                    continue;
                }

                

            }
            if (ok)
            {
                string sql = "INSERT INTO Прихід(Назва_техніки,Вид,Дата,Куда,Озброєння,U_ID) VALUES ('" + textBox1.Text + "','" + comboBox2.Text + "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                SqlConnection SQLCon = new SqlConnection(connectString);
                SQLCon.Open();
                SqlCommand sqlcom = new SqlCommand(sql, SQLCon);
                sqlcom.ExecuteNonQuery();
                SQLCon.Close();



                if (comboBox2.Text == "Танк" || comboBox2.Text == "БМП")
                {

                    string sqlstring = "INSERT INTO Склад_1(Назва_техніки, Вид, Озброєння, U_ID) VALUES ('" + textBox1.Text + "','" + comboBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                    SqlConnection sqlconst1 = new SqlConnection(connectString);
                    sqlconst1.Open();
                    SqlCommand sqlcomst = new SqlCommand(sqlstring, sqlconst1);
                    sqlcomst.ExecuteNonQuery();
                    sqlconst1.Close();
                    Display();


                }


                if (comboBox2.Text == "БТР" || comboBox2.Text == "МУ")
                {

                    string sqlstring = "INSERT INTO Склад_2 (Назва_техніки, Вид, Озброєння, U_ID) VALUES ('" + textBox1.Text + "','" + comboBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                    SqlConnection sqlconst2 = new SqlConnection(connectString);
                    sqlconst2.Open();
                    SqlCommand sqlcomst = new SqlCommand(sqlstring, sqlconst2);
                    sqlcomst.ExecuteNonQuery();
                    sqlconst2.Close();
                    Display();

                }
                if (comboBox2.Text == "ОТРК" || comboBox2.Text == "РСЗО" || comboBox2.Text == "CАУ" || comboBox2.Text == "АУ")
                {

                    string sqlstring = "INSERT INTO Склад_3 (Назва_техніки, Вид, Озброєння, U_ID) VALUES ('" + textBox1.Text + "','" + comboBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                    SqlConnection sqlconst3 = new SqlConnection(connectString);
                    sqlconst3.Open();
                    SqlCommand sqlcomst = new SqlCommand(sqlstring, sqlconst3);
                    sqlcomst.ExecuteNonQuery();
                    sqlconst3.Close();
                    Display();

                }
                if (comboBox2.Text == "ПВО" || comboBox2.Text == "ПРО")
                {

                    string sqlstring = "INSERT INTO Склад_4 (Назва_техніки, Вид, Озброєння, U_ID) VALUES ('" + textBox1.Text + "','" + comboBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                    SqlConnection sqlconst4 = new SqlConnection(connectString);
                    sqlconst4.Open();
                    SqlCommand sqlcomst = new SqlCommand(sqlstring, sqlconst4);
                    sqlcomst.ExecuteNonQuery();
                    sqlconst4.Close();
                    Display();

                }
                if (comboBox2.Text == "Легка зброя")
                {

                    string sqlstring = "INSERT INTO Склад_5 (Назва_техніки, Вид, Калібр, U_ID) VALUES ('" + textBox1.Text + "','" + comboBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                    SqlConnection sqlconst5 = new SqlConnection(connectString);
                    sqlconst5.Open();
                    SqlCommand sqlcomst = new SqlCommand(sqlstring, sqlconst5);
                    sqlcomst.ExecuteNonQuery();
                    sqlconst5.Close();
                    Display();

                }
                if (comboBox2.Text == "Додаткове обладнання")
                {

                    string sqlstring = "INSERT INTO Склад_дот_прил (Назва_техніки, Призначення, U_ID) VALUES ('" + textBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                    SqlConnection sqlconst6 = new SqlConnection(connectString);
                    sqlconst6.Open();
                    SqlCommand sqlcomst = new SqlCommand(sqlstring, sqlconst6);
                    sqlcomst.ExecuteNonQuery();
                    sqlconst6.Close();
                    Display();

                }
                
            }
            ok = false;
            




        }
        private void Display()
        {
            SqlConnection SQLCon = new SqlConnection(connectString);
            string sql = "SELECT * from Прихід";
            SQLCon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, SQLCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
                SqlConnection sqlcon = new SqlConnection(connectString);
                if(textBox7.Text == "" && textBox8.Text == "")
                {
                MessageBox.Show("Введіть  назву або вид техніки", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (textBox7.Text != "" && textBox8.Text == "")
                {
                
                string sql = "SELECT * FROM Прихід WHERE Назва_техніки = '" + textBox7.Text + "' ";
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sql, sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
                
                    if (dataGridView2.Rows.Count == 0)
                    {
                    MessageBox.Show("Не правильно введено або немає такої техніки", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                    return;
                    }
                    sqlcon.Close();
                }
                if(textBox7.Text == "" &&  textBox8.Text != "")
                {
                string sql = "SELECT * from Прихід where Вид = '" + textBox8.Text +"'";
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sql, sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
               
                    if (dataGridView2.Rows.Count == 0)
                    {
                    MessageBox.Show("Не правильно введено або немає такої техніки", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        return;
                    }
                    sqlcon.Close();
                }
            
            if (textBox7.Text != "" && textBox8.Text != "")
            {
                string sql = "SELECT * from Прихід where Назва_техніки = '" + textBox7.Text + "' and Вид = '" + textBox8.Text + "'";
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sql, sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
               
                if (dataGridView2.Rows.Count == 0)
                {
                    MessageBox.Show("Не правильно введено або немає такої техніки", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                else
                {
                    return;
                }
                sqlcon.Close();
            }
            

        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            e.Handled = true;
            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if(e.KeyChar == '.')
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            e.Handled = true;             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display();
            button1.Enabled = true;
            textBox1.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            dateTimePicker1.Enabled = true;
            
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if(textBox7.Text != "" || textBox8.Text != "")
            {
                button2.Enabled = true;

            }
            if (textBox7.Text == "" && textBox8.Text == "")
            {
                button2.Enabled = false;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            Excel.Application ex = new Excel.Application();

            Excel.Workbook workbook = ex.Workbooks.Add();

            Excel.Worksheet worksheet = workbook.ActiveSheet;
            worksheet.Name = "Hello";

            for (int i = 1; i < dataGridView1.RowCount + 1; i++)
            {
                for (int j = 1; j < dataGridView1.ColumnCount + 1; j++)
                {
                    worksheet.Rows[i].Columns[j] = dataGridView1.Rows[i - 1].Cells[j - 1].Value;
                }
            }
            worksheet.Cells[1, 1] = "Id";
            worksheet.Cells[1, 2] = "Назва";
            worksheet.Cells[1, 3] = "Вид";
            worksheet.Cells[1, 4] = "Дата";
            worksheet.Cells[1, 5] = "Куда";
            worksheet.Cells[1, 6] = "Озброєння";
            worksheet.Cells[1, 7] = "U_ID";
            ex.DisplayAlerts = true;
            workbook.SaveAs(@"C:\Users\андрей\source\repos\Диплом\Диплом\Прихід.xlsx");
            ex.Quit();
        }
    }
}
