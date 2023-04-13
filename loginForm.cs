using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem;
using MySql.Data.MySqlClient;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UTS_Kelompok9
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MYDB db = new MYDB();

            string username = txtUsername.Text;
            string password = txtPass.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(
                "SELECT * FROM users WHERE username= @usn AND password= @pass", db.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value=password;    

            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {
                Form1 menuUtama = new Form1();
                loginForm lgn = new loginForm();

                this.Hide();
                menuUtama.Show();
                
            }
            else
            {
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your username to login", "empty username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your password to login", "empty password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wrong username or password", "Wrong data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

                /*  if (txtUsername.Text == "admin" && txtPass.Text == "123")
                  {
                      Form1 aplikasi = new Form1();
                      loginForm lgn = new loginForm();
                      this.Hide();
                      aplikasi.Show();
                      lgn.Close();
                  }
                  else
                  {
                      MessageBox.Show("Enter username and password correctly",
                          "Wrong username or password",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
                  }*/
            }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPass.Text != "")
            {
                btnLogin.BackColor = Color.Green;
            }
            else
            {
                btnLogin.BackColor = Color.Red;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPass.Text != "")
            {
                btnLogin.BackColor = Color.Green;
            }
            else
            {
                btnLogin.BackColor = Color.Red;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (show.Checked)
            {
                txtPass.UseSystemPasswordChar = true;
            }
            else if (!show.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }         
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
                      
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            
        }
        

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if(txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
           // txtPass.UseSystemPasswordChar = true;
        }

        private void show_CheckStateChanged(object sender, EventArgs e)
        {

        }
    }
}
