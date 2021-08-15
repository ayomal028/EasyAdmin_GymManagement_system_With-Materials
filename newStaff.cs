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
    public partial class newStaff : Form
    {
        public newStaff()
        {
            InitializeComponent();
        }

        private void btn_exit_newStaffForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SubmitNewStaff_Click(object sender, EventArgs e)
        {
            string connection = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            //insert query
            string insertUserQuery = "INSERT INTO stafftable (firstname,lastname,address,birthday,NIC,phone,stafftype)  values ('" + this.txt_newStaff_Fname.Text + "','" + this.txt_newStaff_lastName.Text + "','" + this.txt_newStaff_address.Text + "','" + this.dtp_newStaff_birthday.Text + "','" + this.txt_newStaff_NIC.Text + "','" + this.txt_newStaff_phone.Text + "','"+this.dpDown_stafftype.SelectedItem+"')";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(insertUserQuery, con);
            MySqlDataReader dataReader;
            //,'" + this.dtp_userDOB.Text.ToString() + "'

            try
            {
                if (txt_newStaff_Fname.Text == "")
                {
                    MessageBox.Show("please fill the required field!");
                    txt_newStaff_Fname.Focus();
                }
                else if (txt_newStaff_address.Text == "")
                {
                    MessageBox.Show("please fill the required field!");
                    txt_newStaff_address.Focus();
                }
                else if (txt_newStaff_NIC.Text == "")
                {
                    MessageBox.Show("please fill the required field!");
                    txt_newStaff_NIC.Focus();
                }
                else if (txt_newStaff_phone.Text == "")
                {
                    MessageBox.Show("please fill the required field!");
                    txt_newStaff_phone.Focus();
                }
                else
                {
                    con.Open();
                    dataReader = cmd.ExecuteReader();

                    MessageBox.Show("Added Staff Member successfully!");

                    txt_newStaff_Fname.Text = "";
                    txt_newStaff_lastName.Text = "";
                    txt_newStaff_address.Text = "";
                    txt_newStaff_NIC.Text = "";
                    txt_newStaff_phone.Text = "";
                }
                
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Staff Add unsuccessful due to " + ex);
            }
        }

        private void btn_searchEdit_staff_Click(object sender, EventArgs e)
        {
            string conString = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            string searchQuery = "SELECT * FROM stafftable WHERE staffID =" + txt_update_search_staff.Text;
            MySqlConnection con1 = new MySqlConnection(conString);
            MySqlCommand cmd1 = new MySqlCommand(searchQuery, con1);
            MySqlDataReader reader;
            //int count = 0;

            if (txt_update_search_staff.Text == "")
            {
                MessageBox.Show("Please enter ID of the staff member!");
            }
            else
            {
                con1.Open();
                reader = cmd1.ExecuteReader();

                if (reader.Read())
                {
                    txt_newStaff_Fname.Text = (reader["firstname"].ToString());
                    txt_newStaff_lastName.Text = (reader["lastname"].ToString());
                    txt_newStaff_address.Text = (reader["address"].ToString());
                    txt_newStaff_NIC.Text = (reader["NIC"].ToString());
                    txt_newStaff_phone.Text = (reader["phone"].ToString());
                    dpDown_stafftype.Text = (reader["stafftype"].ToString());


                }
            }

            
        }

        private void btn_upadateStaff_Click(object sender, EventArgs e)
        {
            string conString = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            string updateQuery = "UPDATE stafftable SET firstname='" + txt_newStaff_Fname.Text + "',lastname='" + txt_newStaff_lastName.Text + "',address='" + txt_newStaff_address.Text + "',birthday='" + dtp_newStaff_birthday.Text + "',NIC='" + txt_newStaff_NIC.Text + "',phone='" + txt_newStaff_phone.Text + "' WHERE staffID='" + txt_update_search_staff.Text + "' ";
            MySqlConnection con2 = new MySqlConnection(conString);
            MySqlCommand cmd2 = new MySqlCommand(updateQuery, con2);
            MySqlDataReader mReader;

            try
            {
                if (txt_newStaff_Fname.Text == "")
                {
                    MessageBox.Show("please make changes to the required fields if you want to update a Staff member!");
                    txt_newStaff_Fname.Focus();
                }
                else if (txt_newStaff_address.Text == "")
                {
                    MessageBox.Show("please make changes to the required fields if you want to update a Staff member!");
                    txt_newStaff_address.Focus();
                }
                else if (txt_newStaff_NIC.Text == "")
                {
                    MessageBox.Show("please make changes to the required fields if you want to update a Staff member!");
                    txt_newStaff_NIC.Focus();
                }
                else if (txt_newStaff_phone.Text == "")
                {
                    MessageBox.Show("please make changes to the required fields if you want to update a Staff member!");
                    txt_newStaff_phone.Focus();
                }
                else
                {
                    con2.Open();
                    mReader = cmd2.ExecuteReader();
                    MessageBox.Show("Staff record updated successfully!");

                    txt_update_search_staff.Text = "";
                    txt_newStaff_Fname.Text = "";
                    txt_newStaff_lastName.Text = "";
                    txt_newStaff_address.Text = "";
                    txt_newStaff_NIC.Text = "";
                    dtp_newStaff_birthday.Text = "";
                    txt_newStaff_phone.Text = "";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update Staff record due to " + ex);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void txt_update_search_staff_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txt_newStaff_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txt_update_search_staff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_newStaff_Fname.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txt_newStaff_Fname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_newStaff_lastName.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txt_newStaff_lastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_newStaff_address.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txt_newStaff_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_newStaff_NIC.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        

        private void txt_newStaff_NIC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_newStaff_phone.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
