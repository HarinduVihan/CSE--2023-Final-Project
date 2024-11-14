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
    public partial class delcust : Form
    {
        public delcust()
        {
            InitializeComponent();
        }
        bool iselection = false;
        bool ddown = false;
        string combotext;
        private void button1_Click(object sender, EventArgs e)
        {
            // create connection

            string cs = "Data Source=LAPTOP-63P4NJKI\\SQLEXPRESS; Initial Catalog=Finall_project; Integrated Security=True";

            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //Create a command

            string sql = "DELETE FROM Customers WHERE CID=@cid";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@cid", this.cid.Text);


            int ret = cmd.ExecuteNonQuery();
            MessageBox.Show(ret + " recorde(s) deleted");

            
            cid.Clear();
            name.Clear();
            email.Clear();
            tel.Clear();  
            add.Clear();

            con.Close();

            this.Close();
            delcust delcust = new delcust();
            delcust.Show();
        }

        private void cid_TextChanged(object sender, EventArgs e)
        {
            if (iselection || ddown)
            {
                return;
            }
            string searchText = this.cid.Text;

            for (int i = comboBox1.Items.Count - 1; i >= 0; i--)
            {
                comboBox1.Items.RemoveAt(i);
            }

            if (searchText.Length > 0)
            {
                List<string> list = new List<string>();

                foreach (string cid in Shared1.CIDs)
                {
                    if (cid.Contains(searchText))
                    {
                        list.Add(cid);
                    }
                }
                comboBox1.Items.AddRange(list.ToArray());
                this.comboBox1.DroppedDown = true;
            }
            else
            {
                this.comboBox1.Items.AddRange(Shared1.CIDs.ToArray());
            }
        }

        private void delcust_Load(object sender, EventArgs e)
        {
            // create connection

            string cs = @"Data Source=LAPTOP-63P4NJKI\SQLEXPRESS;Initial Catalog=Finall_project;Integrated Security=True";

            SqlConnection con = new SqlConnection(cs);
            con.Open();


            string query = "SELECT CID FROM Customers";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter adpt = new SqlDataAdapter(cmd);

            var dt = new DataTable();

            adpt.Fill(dt);

            List<string> cids = dt.AsEnumerable().Select(row => row.Field<string>("CID")).ToList();

            Shared1.CIDs = cids;

            foreach (var item in cids)
            {
                this.comboBox1.Items.Add(item);
            }

            con.Close();
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
                string query = "SELECT Name,Email,tel,Address FROM Customers WHERE CID=@cid";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@cid", this.comboBox1.GetItemText(this.comboBox1.SelectedItem));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        this.name.Text = reader["Name"].ToString();
                        this.email.Text = reader["Email"].ToString();
                        this.tel.Text = reader["tel"].ToString();
                        this.add.Text = reader["Address"].ToString();

                    }
                }

                con.Close();
            }

            this.cid.Text = combotext;
            iselection = false;
        }
    }
}
