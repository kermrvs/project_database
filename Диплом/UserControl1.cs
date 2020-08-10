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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        string sqlcon = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\SQL-server2017\MSSQL14.SQLEXPRESS\MSSQL\DATA\Test_DB.mdf;Integrated Security=True;Connect Timeout=30";
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Склади"].Points.Clear();
            SqlConnection sql = new SqlConnection(sqlcon);
            string query = "select * from Склад_1";
            string query1 = "select * from Склад_2";
            string query2 = "select * from Склад_3";
            string query3 = "select * from Склад_4";
            string query4 = "select * from Склад_дот_прил";
            
            if (checkBox1.Checked == true)
            {
                SqlDataAdapter sda = new SqlDataAdapter(query,sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                
                chart1.Series["Склади"].Points.AddXY("Склад№1", dt.Rows.Count);
            }
            if (checkBox2.Checked == true)
            {
                SqlDataAdapter sda = new SqlDataAdapter(query1, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                
                chart1.Series["Склади"].Points.AddXY("Склад№2", dt.Rows.Count);
            }
            if (checkBox3.Checked == true)
            {
                SqlDataAdapter sda = new SqlDataAdapter(query2, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                
                chart1.Series["Склади"].Points.AddXY("Склад№3", dt.Rows.Count);
            }
            if (checkBox4.Checked == true)
            {
                SqlDataAdapter sda = new SqlDataAdapter(query3, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                
                chart1.Series["Склади"].Points.AddXY("Склад№4", dt.Rows.Count);
            }
            if (checkBox5.Checked == true)
            {
                SqlDataAdapter sda = new SqlDataAdapter(query4, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                
                chart1.Series["Склади"].Points.AddXY("Склад_дот_прил", dt.Rows.Count);
            }
            
           
           

        }

        
    }
}
