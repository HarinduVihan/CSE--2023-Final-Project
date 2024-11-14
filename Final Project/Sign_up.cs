using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            // create connection

            string cs = "Data Source=LAPTOP-63P4NJKI\\SQLEXPRESS; Initial Catalog=Finall_project; Integrated Security=True";

            SqlConnection con = new SqlConnection(cs);
            con.Open();


            string sql = "SELECT * FROM Users WHERE User_name=@User_name";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@User_name", this.name.Text);

            // select data using reader

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show(" This User name is allready exist, Please try differnt User name");
            }

            else
            {
                dr.Close();
                //Create a command
                if (this.name.Text != "" && this.pass.Text != "")
                {
                    String sql1 = "INSERT INTO Users VALUES (@User_name,@Password)";
                    SqlCommand cmd1 = new SqlCommand(sql1, con);
                    cmd1.Parameters.AddWithValue("@User_name", this.name.Text);
                    cmd1.Parameters.AddWithValue("@Password", this.pass.Text);
                    //Execute command
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Account Created; You have Signed in");

                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Close();
                }
                else { MessageBox.Show("Must enter all details"); }
            }
            // disconnect
            con.Close();
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (pass.PasswordChar == (char)0)
            {
                pass.PasswordChar = '*';
            }
            else
            {
                pass.PasswordChar = (char)0;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
