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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Addprd = new Form3(); 
            Addprd.Show();
            
        }

        private void editProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_products edit_Products = new Edit_products();
            edit_Products.Show();
        }

        private void deleteProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_products delete_Products = new delete_products();
            delete_Products.Show();
        }

        private void addCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Addcustomers = new Form4();
            Addcustomers.Show();
        }

        private void editCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editcust editcust = new Editcust();
            editcust.Show();
        }

        private void deleteCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delcust deletecust = new delcust();
            deletecust.Show();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 New = new Form5();
            New.Show();
        }

        private void orderReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.Show();
        }

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PR pR = new PR();
            pR.Show();
        }
    }
}
