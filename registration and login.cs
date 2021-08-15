using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyAdmin.gym_management_system
{
    public partial class registration_and_login : Form
    {
        public registration_and_login()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_userName_Enter(object sender, EventArgs e)
        {
            if(txt_userName.Text == "Username")
            {
                txt_userName.Text = "";
                txt_userName.ForeColor = Color.White;
            }
        }

        private void Txt_userName_Leave(object sender, EventArgs e)
        {
            if (txt_userName.Text == "")
            {
                txt_userName.Text = "Username";
                txt_userName.ForeColor = Color.Silver;
            }
        }

        private void Txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Password")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.White;
            }
        }

        private void Txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_userName.Text == "")
            {
                txt_userName.Text = "Password";
                txt_userName.ForeColor = Color.Silver;
            }
        }

      

        private void Registration_and_login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void Registration_and_login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            
            string conString = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            string LoginQuery = "SELECT * FROM usertable WHERE userName='" + txt_userName.Text + "'and usertype ='" + dropdown_usertype_login.selectedValue.ToString() + "'and password = '" + txt_password.Text + "'  ";
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(LoginQuery, con);
            MySqlDataReader reader;
            //int count = 0;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string log = reader[7].ToString();

                        if(log == "owner")
                        {
                            mainMenu mdi = new mainMenu();   
                            mdi.lbl_role.Text = dropdown_usertype_login.selectedValue;
                            this.Hide();
                            mdi.ShowDialog();
                            this.Hide();

                            
                        }
                        else if(log == "trainer")
                        {
                            mainMenu mdi = new mainMenu();
                            mdi.lbl_role.Text = dropdown_usertype_login.selectedValue;
                            this.Hide();
                            mdi.ShowDialog();
                            this.Hide();

                           
                            
                        }
                        else
                        {
                            MessageBox.Show("Please try again");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Invalid username,password or user type!");
                }

                txt_userName.Text = "";
                txt_password.Text = "";
                

            }catch(Exception ex)
            {
                MessageBox.Show("unable to get the values due to " + ex);
            }
        }

        private void btn_showPword_Click(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = false;
        }

        private void txt_userName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
