﻿namespace Диплом
{
    partial class report
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Test_DBDataSet = new Диплом.Test_DBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ПрихідBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ПрихідTableAdapter = new Диплом.Test_DBDataSetTableAdapters.ПрихідTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Test_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ПрихідBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Test_DBDataSet
            // 
            this.Test_DBDataSet.DataSetName = "Test_DBDataSet";
            this.Test_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Top;
            reportDataSource2.Name = "Vehicles";
            reportDataSource2.Value = this.ПрихідBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Диплом.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(900, 543);
            this.reportViewer1.TabIndex = 0;
            // 
            // ПрихідBindingSource
            // 
            this.ПрихідBindingSource.DataMember = "Прихід";
            this.ПрихідBindingSource.DataSource = this.Test_DBDataSet;
            // 
            // ПрихідTableAdapter
            // 
            this.ПрихідTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(776, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report";
            this.Size = new System.Drawing.Size(900, 600);
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Test_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ПрихідBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ПрихідBindingSource;
        private Test_DBDataSet Test_DBDataSet;
        private Test_DBDataSetTableAdapters.ПрихідTableAdapter ПрихідTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}
