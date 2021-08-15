using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EasyAdmin.gym_management_system
{
    public partial class ownerRegis : Form
    {
        public ownerRegis()
        {
            InitializeComponent();
        }

        private void BunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void Btn_exitRegForm_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            registration_and_login ownerRegis = new registration_and_login();
           this.Hide();
            ownerRegis.ShowDialog();
           this.Close();
        }

        private void OwnerRegis_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void OwnerRegis_MouseDown(object sender, MouseEventArgs e)
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

        private void btn_Register_Click(object sender, EventArgs e)
        {
            
            string connection = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            //insert query
            string insertUserQuery = "INSERT INTO usertable (userName,firstname,lastname,address,NIC,phone,usertype,password) values ('" + this.txt_regUsername.Text + "','" + this.txt_fName.Text + "','" + this.txt_Lname.Text + "','" + this.txt_Address.Text + "','" + this.txt_NIC.Text + "','" + this.txt_Phone.Text + "','" + this.dropdown_usertype_regis.selectedValue.ToString() + "','" + this.txt_RegPassword.Text + "')";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(insertUserQuery,con);
            MySqlDataReader dataReader;
            //,'" + this.dtp_userDOB.Text.ToString() + "'

            try
            {
                if(txt_regUsername.Text == "")
                {
                    MessageBox.Show(" please fill the required field!");
                    txt_regUsername.Focus();
                }
                else if(txt_fName.Text == "")
                {
                    MessageBox.Show(" please fill the required field!");
                    txt_fName.Focus();
                }
                else if (txt_Lname.Text == "")
                {
                    MessageBox.Show(" please fill the required field!");
                    txt_Lname.Focus();
                }
                else if (txt_Phone.Text == "")
                {
                    MessageBox.Show(" please fill the required field!");
                    txt_Phone.Focus();
                }
                else if (txt_NIC.Text == "")
                {
                    MessageBox.Show(" please fill the required field!");
                    txt_NIC.Focus();
                }
                else if (txt_Address.Text == "")
                {
                    MessageBox.Show(" please fill the required field!");
                    txt_Address.Focus();
                }
                else if (txt_RegPassword.Text == "")
                {
                    MessageBox.Show(" please fill the required field!");
                    txt_RegPassword.Focus();
                }
                else if (txt_RegCPassword.Text == "")
                {
                    MessageBox.Show(" please fill the required field!");
                    txt_RegCPassword.Focus();
                }
                else
                {
                    con.Open();
                    dataReader = cmd.ExecuteReader();

                    MessageBox.Show("User registration successful!");

                    txt_fName.Text = "";
                    txt_Lname.Text = "";
                    txt_Address.Text = "";
                    txt_NIC.Text = "";
                    txt_Phone.Text = "";
                    txt_RegPassword.Text = "";
                    txt_RegCPassword.Text = "";
                    txt_regUsername.Text = "";
                }             
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("registration unsuccessful due to " + ex);
            }
                


          
        }

        private void txt_RegCPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if(txt_RegPassword.Text == txt_RegCPassword.Text)
            {
                lbl_match.ForeColor = Color.Green;
                lbl_match.Text = "Matched!";
            }
            else
            {
                lbl_match.ForeColor = Color.Red;
                lbl_match.Text = "Miss Match!";
            }
        }

        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txt_regUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_fName.Focus();
            }
        }

        private void txt_fName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Lname.Focus();
            }
        }

        private void txt_Lname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Phone.Focus();
            }
        }

        private void txt_Phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_NIC.Focus();
            }
        }

        private void txt_NIC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Address.Focus();
            }
        }

        private void txt_Address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_RegPassword.Focus();
            }
        }

        private void txt_RegPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_RegCPassword.Focus();
            }
        }
    }
}
