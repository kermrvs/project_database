using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Диплом
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            mainPanel1.Visible = true;
            mainPanel1.BringToFront();
            mainPanel1.Enabled = true;
            deletefForm1.Enabled = false;
            findElement1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            findElement1.Visible = true;
            findElement1.BringToFront();
            findElement1.Enabled = true;
            mainPanel1.Enabled = false;
            deletefForm1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            deletefForm1.Visible = true;
            deletefForm1.BringToFront();
            deletefForm1.Enabled = true;
            findElement1.Enabled = false;
            mainPanel1.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void findElement1_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            editForm1.Visible = false;
            mainPanel1.Visible = false;
            findElement1.Visible = false;
            deletefForm1.Visible = false;
            userControl11.Visible = false;

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
            userControl11.Enabled = true;
            userControl11.Visible = true;
            userControl11.BringToFront();
            deletefForm1.Enabled = false;
            findElement1.Enabled = false;
            mainPanel1.Enabled = false;
        }

        

        private void button5_Click_1(object sender, EventArgs e)
        {
         
            editForm1.Visible = true;
            editForm1.BringToFront();
            userControl11.Enabled = false;
            userControl11.Visible = false;
            deletefForm1.Enabled = false;
            findElement1.Enabled = false;
            mainPanel1.Enabled = false;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            report1.Visible = true;
            report1.Enabled = true;
            report1.BringToFront();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
