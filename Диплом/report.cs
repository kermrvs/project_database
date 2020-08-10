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
    public partial class report : UserControl
    {
        public report()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            this.ПрихідTableAdapter.Fill(this.Test_DBDataSet.Прихід);

            this.reportViewer1.RefreshReport();
        }

        private void report_Load(object sender, EventArgs e)
        {
            
        }
    }
}
