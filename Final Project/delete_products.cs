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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Final_Project
{
    public partial class delete_products : Form
    {
        public delete_products()
        {
            InitializeComponent();
        }

        bool iselection = false;
        bool ddown = false;
        string combotext;

        private void Delete_Click(object sender, EventArgs e)
        {
            // create connection

            string cs = "Data Source=LAPTOP-63P4NJKI\\SQLEXPRESS; Initial Catalog=Finall_project; Integrated Security=True";

            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //Create a command

            string sql = "DELETE FROM Products WHERE PID=@pid";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@PID", this.pidtext.Text);


            int ret = cmd.ExecuteNonQuery();
            MessageBox.Show(ret + " recorde(s) deleted");
            
            pidtext.Clear();
            name.Clear();
            price.Clear();
            
            con.Close();

            this.Close();
            delete_products delete_Products = new delete_products();
            delete_Products.Show();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {

            if (iselection)
            {
                return;
            }
            ddown = true;
            comboBox1.SelectedIndex = -1;
            ddown = false;
        }

        private void delete_products_Load(object sender, EventArgs e)
        {
            // create connection

            string cs = @"Data Source=LAPTOP-63P4NJKI\SQLEXPRESS;Initial Catalog=Finall_project;Integrated Security=True";

            SqlConnection con = new SqlConnection(cs);
            con.Open();


            string query = "SELECT PID FROM Products";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter adpt = new SqlDataAdapter(cmd);

            var dt = new DataTable();

            adpt.Fill(dt);

            List<string> pids = dt.AsEnumerable().Select(row => row.Field<string>("PID")).ToList();

            Shared1.PIDs = pids;

            foreach (var item in pids)
            {
                this.comboBox1.Items.Add(item);
            }

            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            combotext = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            iselection = true;

            // create connection
            string cs = "Data Source=LAPTOP-63P4NJKI\\SQLEXPRESS; Initial Catalog=Finall_project; Integrated Security=True";

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                // Create a command
                string query = "SELECT Name, Price FROM Products WHERE PID=@pid";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@pid", this.comboBox1.GetItemText(this.comboBox1.SelectedItem));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        this.name.Text = reader["Name"].ToString();
                        this.price.Text = reader["Price"].ToString();
                    }
                }

                con.Close();
            }

            this.pidtext.Text = combotext;
            iselection = false;
        }

        private void pidtext_TextChanged(object sender, EventArgs e)
        {

            if (iselection || ddown)
            {
                return;
            }
            string searchText = this.pidtext.Text;

            for (int i = comboBox1.Items.Count - 1; i >= 0; i--)
            {
                comboBox1.Items.RemoveAt(i);
            }

            if (searchText.Length > 0)
            {
                List<string> list = new List<string>();

                foreach (string pid in Shared1.PIDs)
                {
                    if (pid.Contains(searchText))
                    {
                        list.Add(pid);
                    }
                }
                comboBox1.Items.AddRange(list.ToArray());
                this.comboBox1.DroppedDown = true;
            }
            else
            {
                this.comboBox1.Items.AddRange(Shared1.PIDs.ToArray());
            }
        }
    }
}
