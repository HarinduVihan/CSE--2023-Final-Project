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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            // create connection

            string cs = "Data Source=LAPTOP-63P4NJKI\\SQLEXPRESS; Initial Catalog=Finall_project; Integrated Security=True";

            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM Products WHERE PID=@pid";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@pid", this.pid.Text);
            
            // select data using reader

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show(" This Product ID is allready exist, Please try differnt PID");
            }
            
            else
            {
                dr.Close();
                //Create a command
                if (this.pid.Text != "" && this.name.Text != "" && this.price.Text != "")
                {
                    String sql1 = "INSERT INTO Products VALUES (@pid,@name,@price)";
                    SqlCommand cmd1 = new SqlCommand(sql1, con);

                    cmd1.Parameters.AddWithValue("@pid", this.pid.Text);
                    cmd1.Parameters.AddWithValue("@name", this.name.Text);
                    cmd1.Parameters.AddWithValue("@price", this.price.Text);

                    //Execute command

                    cmd1.ExecuteNonQuery();
                    MessageBox.Show(" Record added successfully");
                }
                else { MessageBox.Show("Must enter all details"); }
            }
            this.Close();
            Form3 form3 = new Form3();
            form3.Show();
            // disconnect
            con.Close();
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-63P4NJKI\\SQLEXPRESS; Initial Catalog=Finall_project; Integrated Security=True";

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                string sql = "SELECT MAX(PID) FROM Products";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            // Check if the value is convertible to int
                            if (int.TryParse(dr[0].ToString(), out int maxID))
                            {
                                int newID = maxID + 1;
                                this.pid.Text = newID.ToString();
                            }
                            else
                            {
                                // Handle the case where the value is not a valid integer
                                this.pid.Text = "1";
                            }
                        }
                        else
                        {
                            // Handle the case where there are no records in the table
                            this.pid.Text = "1";
                        }
                    }
                }
                con.Close();
            }
        }
    }
}
