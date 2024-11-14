using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
        }

        private void order_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.RefreshReport();
        }
    }
}
