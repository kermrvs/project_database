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

namespace Диплом
{
    public partial class EditForm : UserControl
    {
        public EditForm()
        {
            InitializeComponent();
        }
        string sqlconnect = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\SQL-server2017\MSSQL14.SQLEXPRESS\MSSQL\DATA\Test_DB.mdf;Integrated Security=True;Connect Timeout=30";
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "")
            {
                MessageBox.Show("Виберіть назву таблиці");
            }
            if (comboBox1.Text == "Склад_1")
            {
                string sqlzap = "SELECT * from Склад_1";
                SqlConnection sqlcon = new SqlConnection(sqlconnect);
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlcon.Close();
            }
            if (comboBox1.Text == "Склад_2")
            {
                string sqlzap = "SELECT * from Склад_2";
                SqlConnection sqlcon = new SqlConnection(sqlconnect);
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlcon.Close();
            }
            if (comboBox1.Text == "Склад_3")
            {
                string sqlzap = "SELECT * from Склад_3";
                SqlConnection sqlcon = new SqlConnection(sqlconnect);
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlcon.Close();
            }
            if (comboBox1.Text == "Склад_4")
            {
                string sqlzap = "SELECT * from Склад_4";
                SqlConnection sqlcon = new SqlConnection(sqlconnect);
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlcon.Close();
            }
            if (comboBox1.Text == "Склад_5")
            {
                string sqlzap = "SELECT * from Склад_5";
                SqlConnection sqlcon = new SqlConnection(sqlconnect);
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlcon.Close();
            }
            if (comboBox1.Text == "Склад_дот_приладів")
            {
                string sqlzap = "SELECT * from Склад_дот_прил";
                SqlConnection sqlcon = new SqlConnection(sqlconnect);
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlcon.Close();
            }
            if (comboBox1.Text == "Прихід")
            {
                string sqlzap = "SELECT * from Прихід";
                SqlConnection sqlcon = new SqlConnection(sqlconnect);
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
            if (comboBox1.Text == "Склад_1")
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Введіть ID по якуму потрібно видалити");
                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                    {
                       int s = (int)dataGridView1.Rows[i].Cells[0].Value;

                       if(s != Convert.ToInt32(textBox1.Text))
                       {
                            continue;
                       }
                       else
                       {
                            SqlConnection sqlcon1 = new SqlConnection(sqlconnect);
                            string sqlExpression = "DELETE  FROM Склад_1 WHERE Id ='" + textBox1.Text + "'";
                            sqlcon1.Open();
                            SqlCommand command = new SqlCommand(sqlExpression, sqlcon1);
                            command.ExecuteNonQuery();
                            sqlcon1.Close();
                        }
                    }
                }
                string sqlzap = "SELECT * from Склад_1";
                SqlConnection sqlcon = new SqlConnection(sqlconnect);
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlcon.Close();
            }
            if (comboBox1.Text == "Склад_2")
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Введіть ID по якуму потрібно видалити");
                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        int s = (int)dataGridView1.Rows[i].Cells[0].Value;

                        if (s != Convert.ToInt32(textBox1.Text))
                        {
                            continue;
                        }
                        else
                        {
                            SqlConnection sqlcon1 = new SqlConnection(sqlconnect);
                            string sqlExpression = "DELETE  FROM Склад_2 WHERE Id ='" + textBox1.Text + "'";
                            sqlcon1.Open();
                            SqlCommand command = new SqlCommand(sqlExpression, sqlcon1);
                            command.ExecuteNonQuery();
                            sqlcon1.Close();
                        }
                    }
                }
                string sqlzap = "SELECT * from Склад_2";
                SqlConnection sqlcon = new SqlConnection(sqlconnect);
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlcon.Close();
            }
            if (comboBox1.Text == "Склад_3")
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Введіть ID по якуму потрібно видалити");
                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        int s = (int)dataGridView1.Rows[i].Cells[0].Value;

                        if (s != Convert.ToInt32(textBox1.Text))
                        {
                            continue;
                        }
                        else
                        {
                            SqlConnection sqlcon1 = new SqlConnection(sqlconnect);
                            string sqlExpression = "DELETE  FROM Склад_3 WHERE Id ='" + textBox1.Text + "'";
                            sqlcon1.Open();
                            SqlCommand command = new SqlCommand(sqlExpression, sqlcon1);
                            command.ExecuteNonQuery();
                            sqlcon1.Close();
                        }
                    }
                }
                string sqlzap = "SELECT * from Склад_3";
                SqlConnection sqlcon = new SqlConnection(sqlconnect);
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlcon.Close();
            }
            if (comboBox1.Text == "Склад_4")
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Введіть ID по якуму потрібно видалити");
                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        int s = (int)dataGridView1.Rows[i].Cells[0].Value;

                        if (s != Convert.ToInt32(textBox1.Text))
                        {
                            continue;
                        }
                        else
                        {
                            SqlConnection sqlcon1 = new SqlConnection(sqlconnect);
                            string sqlExpression = "DELETE  FROM Склад_4 WHERE Id ='" + textBox1.Text + "'";
                            sqlcon1.Open();
                            SqlCommand command = new SqlCommand(sqlExpression, sqlcon1);
                            command.ExecuteNonQuery();
                            sqlcon1.Close();
                        }
                    }
                }
                string sqlzap = "SELECT * from Склад_4";
                SqlConnection sqlcon = new SqlConnection(sqlconnect);
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlcon.Close();
            }
            if (comboBox1.Text == "Склад_5")
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Введіть ID по якуму потрібно видалити");
                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        int s = (int)dataGridView1.Rows[i].Cells[0].Value;

                        if (s != Convert.ToInt32(textBox1.Text))
                        {
                            continue;
                        }
                        else
                        {
                            SqlConnection sqlcon1 = new SqlConnection(sqlconnect);
                            string sqlExpression = "DELETE  FROM Склад_5 WHERE Id ='" + textBox1.Text + "'";
                            sqlcon1.Open();
                            SqlCommand command = new SqlCommand(sqlExpression, sqlcon1);
                            command.ExecuteNonQuery();
                            sqlcon1.Close();
                        }
                    }
                }
                string sqlzap = "SELECT * from Склад_5";
                SqlConnection sqlcon = new SqlConnection(sqlconnect);
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlcon.Close();
            }
            if (comboBox1.Text == "Склад_дот_приладів")
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Введіть ID по якуму потрібно видалити");
                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        int s = (int)dataGridView1.Rows[i].Cells[0].Value;

                        if (s != Convert.ToInt32(textBox1.Text))
                        {
                            continue;
                        }
                        else
                        {
                            SqlConnection sqlcon1 = new SqlConnection(sqlconnect);
                            string sqlExpression = "DELETE  FROM Склад_дот_прил WHERE Id ='" + textBox1.Text + "'";
                            sqlcon1.Open();
                            SqlCommand command = new SqlCommand(sqlExpression, sqlcon1);
                            command.ExecuteNonQuery();
                            sqlcon1.Close();
                        }
                    }
                }
                string sqlzap = "SELECT * from Склад_дот_прил";
                SqlConnection sqlcon = new SqlConnection(sqlconnect);
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlzap, sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlcon.Close();
            }
            


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (e.KeyChar == '.')
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
