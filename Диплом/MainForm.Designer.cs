namespace Диплом
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.findElement1 = new Диплом.FindElement();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.test_DBDataSet1 = new Диплом.Test_DBDataSet();
            this.report1 = new Диплом.report();
            this.editForm1 = new Диплом.EditForm();
            this.userControl11 = new Диплом.UserControl1();
            this.deletefForm1 = new Диплом.DeletefForm();
            this.mainPanel1 = new Диплом.MainPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_DBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.DarkRed;
            this.button6.Location = new System.Drawing.Point(0, 271);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 50);
            this.button6.TabIndex = 8;
            this.button6.Text = "Звіт";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_2);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.DarkRed;
            this.button5.Location = new System.Drawing.Point(0, 224);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 50);
            this.button5.TabIndex = 7;
            this.button5.Text = "Видалення";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.DarkRed;
            this.button3.Location = new System.Drawing.Point(0, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 50);
            this.button3.TabIndex = 5;
            this.button3.Text = "Графіки";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.DarkRed;
            this.button4.Location = new System.Drawing.Point(0, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "Списання";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // findElement1
            // 
            this.findElement1.Enabled = false;
            this.findElement1.Location = new System.Drawing.Point(192, 0);
            this.findElement1.Name = "findElement1";
            this.findElement1.Size = new System.Drawing.Size(900, 600);
            this.findElement1.TabIndex = 2;
            this.findElement1.Load += new System.EventHandler(this.findElement1_Load);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(0, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Пошук по складам";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(0, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Прихід";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // test_DBDataSet1
            // 
            this.test_DBDataSet1.DataSetName = "Test_DBDataSet";
            this.test_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report1
            // 
            this.report1.Location = new System.Drawing.Point(192, 0);
            this.report1.Name = "report1";
            this.report1.Size = new System.Drawing.Size(900, 600);
            this.report1.TabIndex = 6;
            this.report1.Visible = false;
            // 
            // editForm1
            // 
            this.editForm1.Location = new System.Drawing.Point(192, 0);
            this.editForm1.Name = "editForm1";
            this.editForm1.Size = new System.Drawing.Size(900, 600);
            this.editForm1.TabIndex = 5;
            // 
            // userControl11
            // 
            this.userControl11.Enabled = false;
            this.userControl11.Location = new System.Drawing.Point(192, -3);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(900, 600);
            this.userControl11.TabIndex = 4;
            this.userControl11.Visible = false;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // deletefForm1
            // 
            this.deletefForm1.Enabled = false;
            this.deletefForm1.Location = new System.Drawing.Point(192, -3);
            this.deletefForm1.Name = "deletefForm1";
            this.deletefForm1.Size = new System.Drawing.Size(900, 600);
            this.deletefForm1.TabIndex = 3;
            // 
            // mainPanel1
            // 
            this.mainPanel1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.mainPanel1.Enabled = false;
            this.mainPanel1.Location = new System.Drawing.Point(192, 3);
            this.mainPanel1.Name = "mainPanel1";
            this.mainPanel1.Size = new System.Drawing.Size(900, 600);
            this.mainPanel1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 600);
            this.Controls.Add(this.report1);
            this.Controls.Add(this.editForm1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.deletefForm1);
            this.Controls.Add(this.findElement1);
            this.Controls.Add(this.mainPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_DBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MainPanel mainPanel1;
        private System.Windows.Forms.Button button2;
        private FindElement findElement1;
        private System.Windows.Forms.Button button4;
        private DeletefForm deletefForm1;
        private System.Windows.Forms.Button button3;
        private UserControl1 userControl11;
        private System.Windows.Forms.Button button5;
        private EditForm editForm1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button6;
        private Test_DBDataSet test_DBDataSet1;
        private report report1;
    }  
}