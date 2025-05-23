﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create connection

            string cs = "Data Source=LAPTOP-63P4NJKI\\SQLEXPRESS; Initial Catalog=Finall_project; Integrated Security=True";

            SqlConnection con = new SqlConnection(cs);
            con.Open();

            // command

            string sql = "SELECT * FROM Users WHERE User_name=@un AND Password=@pw";
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.Parameters.AddWithValue("@un", this.name.Text);
            cmd.Parameters.AddWithValue("@pw", this.pass.Text);

            // select data using reader

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read()) 
            {
            Form2 home = new Form2();
                home.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show(" Incorrect User name or Password Please try again");
            }

            //disconnect
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

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sign_up_Click(object sender, EventArgs e)
        {
            Sign_up sign_Up = new Sign_up();
            sign_Up.Show();
            this.Hide();
        }
    }
}
