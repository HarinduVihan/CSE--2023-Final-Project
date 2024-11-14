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

namespace Final_Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create connection

            string cs = "Data Source=LAPTOP-63P4NJKI\\SQLEXPRESS; Initial Catalog=Finall_project; Integrated Security=True";

            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM Customers WHERE CID=@cid";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@cid", this.cid.Text);

            // select data using reader

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show(" This Customer ID is allready exist, Please try differnt CID");
            }

            else
            {
                dr.Close();
                if (this.cid.Text != "" && this.name.Text != "" && this.email.Text != "" && this.tel.Text != "" && this.add.Text != "")
                {
                    //Create a command

                    String sql1 = "INSERT INTO Customers  VALUES (@cid,@name,@email,@tel,@add)";
                    SqlCommand cmd1 = new SqlCommand(sql1, con);
                    cmd1.Parameters.AddWithValue("@cid", this.cid.Text);
                    cmd1.Parameters.AddWithValue("@name", this.name.Text);
                    cmd1.Parameters.AddWithValue("@email", this.email.Text);
                    cmd1.Parameters.AddWithValue("@tel", this.tel.Text);
                    cmd1.Parameters.AddWithValue("@add", this.add.Text);

                    //Execute command

                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Customer added");
                }
                else { MessageBox.Show("Must enter all details"); }
            }
            // disconnect
            con.Close();

            this.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-63P4NJKI\\SQLEXPRESS; Initial Catalog=Finall_project; Integrated Security=True";

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                string sql = "SELECT MAX(CID) FROM Customers";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            
                            if (int.TryParse(dr[0].ToString(), out int maxID))
                            {
                                int newID = maxID + 1;
                                this.cid.Text = newID.ToString();
                            }
                            else
                            {
                               
                                this.cid.Text = "1";
                            }
                        }
                        else
                        {
                           
                            this.cid.Text = "1";
                        }
                    }
                    
                }
                con.Close();

            }
        }
    }
}
