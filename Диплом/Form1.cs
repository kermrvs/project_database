using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Диплом
{
    public partial class Form1 : Form
    {
        private Point mouseoff;
        private Point mouseofff;
        private bool isMouseDown = false;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelLeft_MouseDown(object sender, MouseEventArgs e)
        {
            int x;
            int y;

            if (e.Button == MouseButtons.Left)
            {
                x = -e.X; //- SystemInformation.FrameBorderSize.Width;
                y = -e.Y; //- SystemInformation.FrameBorderSize.Height;
                mouseoff = new Point(x, y);
                isMouseDown = true;
            }
        }

        private void panelLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = MousePosition;
                mousePos.Offset(mouseoff.X, mouseoff.Y);
                Location = mousePos;
            }
        }

        private void panelLeft_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
       // private int xx;
        //private int yy;
        private void panelRight_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                int x, y;
                x = -e.X - panelLeft.Width; //- SystemInformation.FrameBorderSize.Width;
                y = -e.Y; //- SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height;
                mouseofff = new Point(x, y);
                isMouseDown = true;
            }
        }


        private void panelRight_MouseMove(object sender, MouseEventArgs e)
        {
            if(isMouseDown)
            {
                Point mousePoss = MousePosition;
                mousePoss.Offset(mouseofff.X,mouseofff.Y);
                Location = mousePoss;
            }
        }

        private void panelRight_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AboutProgram aboProg = new AboutProgram();
            aboProg.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\SQL-server2017\MSSQL14.SQLEXPRESS\MSSQL\DATA\Test_DB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = $"SELECT Name,Login from Login WHERE Name = '" + loginText.Text.Trim() + "' and  Login = '" + PassText.Text.Trim() + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            DataTable dtb1 = new DataTable();
            sda.Fill(dtb1);
            
            if (dtb1.Rows.Count == 1)
            {
                MainForm mainform = new MainForm();
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check your password and login.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void loginText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.Focus();
            }
        }
    }
}
