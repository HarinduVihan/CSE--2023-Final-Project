using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int addp = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            ++addp;

            string cs = "Data Source=LAPTOP-63P4NJKI\\SQLEXPRESS; Initial Catalog=Finall_project; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //Create a command
            if (this.oid.Text != "" && this.cust.Text != "" && this.prd.Text != "")
            {
                String sql = "INSERT INTO Order1 VALUES(@Product,@Price,@Qty,@Total)";
            SqlCommand cmd = new SqlCommand(sql, con);

            int qty = Convert.ToInt32(this.qty.Value);
            Double price = Convert.ToDouble(this.price.Text);
            Double total = qty * price;
            double bill = 0;
            

            cmd.Parameters.AddWithValue("@Product", this.prd.Text);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@Qty",qty);
            cmd.Parameters.AddWithValue("@Total", total);


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                bill += Convert.ToDouble(dataGridView1.Rows[i].Cells["Total"].Value);
            }

            this.bill.Text = Convert.ToString(bill+total);

            //Execute command

             cmd.ExecuteNonQuery();

            // Create a command

            string sql2 = "SELECT * FROM Order1";
            SqlCommand com = new SqlCommand(sql2, con);

            //Execute command

            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet dataSet = new DataSet();
            dap.Fill(dataSet);

            this.dataGridView1.DataSource = dataSet.Tables[0];


            con.Close();
            }
            else { MessageBox.Show("Must enter all details"); }

        }

        private void cust_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // create connection

            string cs = "Data Source=LAPTOP-63P4NJKI\\SQLEXPRESS; Initial Catalog=Finall_project; Integrated Security=True";

            SqlConnection con = new SqlConnection(cs);

            con.Open();
                       

            // create a command

            string dt = "DELETE FROM Order1 ";
            SqlCommand dlt = new SqlCommand(dt, con);
            
            dlt.ExecuteNonQuery();

            string query = "SELECT Name FROM Customers";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandText = query;
            
            SqlDataReader drd = cmd.ExecuteReader();
            while (drd.Read())
            {
                cust.Items.Add(drd["Name"].ToString());
               
            }
            drd.Close();

            
            string query1 = "SELECT Name FROM Products";

                SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.CommandText = query1;
            
            SqlDataReader drd2 = cmd1.ExecuteReader();
            while (drd2.Read()) 
            {
                prd.Items.Add(drd2["Name"].ToString());

            }
            drd2.Close();

            // Create a command

            string sql2 = "SELECT * FROM Order1";
            SqlCommand com = new SqlCommand(sql2, con);

            //Execute command

            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet dataSet = new DataSet();
            dap.Fill(dataSet);

            this.dataGridView1.DataSource = dataSet.Tables[0];
                      
                string sql = "SELECT MAX(OID) FROM Bill";
                using (SqlCommand cmd2 = new SqlCommand(sql, con))
                {
                    using (SqlDataReader dr = cmd2.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                           
                            if (int.TryParse(dr[0].ToString(), out int maxID))
                            {
                                int newID = maxID + 1;
                                this.oid.Text = newID.ToString();
                            }
                            else
                            {
                                
                                this.oid.Text = "1";
                            }
                        }
                        else
                        {
                           
                            this.oid.Text = "1";
                        }
                    }
                }
            
            con.Close();
        }

        private void prd_SelectedIndexChanged(object sender, EventArgs e)
        {

            string cs = "Data Source=LAPTOP-63P4NJKI\\SQLEXPRESS; Initial Catalog=Finall_project; Integrated Security=True";

            SqlConnection con = new SqlConnection(cs);

            con.Open();

            string qu = "SELECT Price FROM Products WHERE Name=@nm";
            SqlCommand q = new SqlCommand(qu, con);

            q.Parameters.AddWithValue("@nm", this.prd.Text);
            
            
            SqlDataReader dr = q.ExecuteReader();
            dr.Read();
   
            this.price.Text = dr.GetValue(0).ToString();
            dr.Close();
            con.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (addp < 1) 
            {
                MessageBox.Show("Please add Order");
                return;
            }
            string cs = "Data Source=LAPTOP-63P4NJKI\\SQLEXPRESS; Initial Catalog=Finall_project; Integrated Security=True";

            SqlConnection con = new SqlConnection(cs);
            con.Open();
                //Create a command

                String sql1 = "INSERT INTO Bill VALUES (@Oid,@Customer,@Totall_bill)";
                SqlCommand cmd3 = new SqlCommand(sql1, con);
                cmd3.Parameters.AddWithValue("@Oid", this.oid.Text);
                cmd3.Parameters.AddWithValue("@Customer", this.cust.Text);
                cmd3.Parameters.AddWithValue("@Totall_Bill", this.bill.Text);

                //Execute command

                int ret = cmd3.ExecuteNonQuery();
                MessageBox.Show(ret + " Record(s) inserted");
                
      
            // disconnect
            con.Close();

            this.Close();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           order order = new order();
            
            Orep cr = new Orep();
            
            TextObject Textoid = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["Text10"];
            TextObject Textname = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["Text11"];

            
            Textoid.Text = oid.Text;
            Textname.Text = cust.Text;

            order.crystalReportViewer1.ReportSource = cr;

            order.Show();
        }
    }
}
