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
    public partial class newMember : Form
    {
        public newMember()
        {
            InitializeComponent();
        }

        

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btn_SubmitNewMember_Click(object sender, EventArgs e)
        {
            string connection = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            //insert quer
            string insertUserQuery = "INSERT INTO membertable (firstname,lastname,address,birthday,NIC,phone,bloodgroup,height,weight,plantype,disabilities)  values ('" + this.txt_newMemebr_Fname.Text + "','" + this.txt_newMember_lastName.Text + "','" + this.txt_newmember_address.Text + "','" + this.dtp_newMember_birthday.Text + "','" + this.txt_newMember_NIC.Text + "','" + this.txt_newMember_phone.Text + "','" + this.dpDown_member_bldgrp.selectedValue.ToString() + "','" + this.txt_newMember_height.Text + "','"+this.txt_newMember_weight.Text+"','"+dpDown_newMember_mPlan.selectedValue.ToString()+"','"+this.txt_memberDisabilities.Text+"')";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(insertUserQuery, con);
            MySqlDataReader dataReader;
            //,'" + this.dtp_userDOB.Text.ToString() + "'

            try { 

                if(txt_newMemebr_Fname.Text == "")
                {
                    MessageBox.Show("please fill the required field!");
                    txt_newMemebr_Fname.Focus();
                }
                else  if (txt_newmember_address.Text == "")
                {
                    MessageBox.Show("please fill the required field!");
                    txt_newmember_address.Focus();
                }
                else if (txt_newMember_NIC.Text == "")
                {
                    MessageBox.Show("please fill the required field!");
                    txt_newMember_NIC.Focus();
                }
                else if (txt_newMember_phone.Text == "")
                {
                    MessageBox.Show("please fill the required field!");
                    txt_newMember_phone.Focus();
                }
                else if (txt_newMember_height.Text == "")
                {
                    MessageBox.Show("please fill the required field!");
                    txt_newMember_height.Focus();
                }
                else if (txt_newMember_weight.Text == "")
                {
                    MessageBox.Show("please fill the required field!");
                    txt_newMember_weight.Focus();
                }
                else
                {
                    con.Open();
                    dataReader = cmd.ExecuteReader();
                    MessageBox.Show("Added the member successfully!");


                    txt_newMemebr_Fname.Text = "";
                    txt_newMember_lastName.Text = "";
                    txt_newmember_address.Text = "";
                    dtp_newMember_birthday.Text = "";
                    txt_newMember_NIC.Text = "";
                    txt_newMember_phone.Text = "";
                    txt_newMember_height.Text = "";
                    txt_newMember_weight.Text = "";
                    txt_memberDisabilities.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Member Add unsuccessful due to " + ex);
            }
        }

        private void btn_upadateMember_Click(object sender, EventArgs e)
        {
           string conString = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
           string updateQuery = "UPDATE membertable SET firstname='"+txt_newMemebr_Fname.Text+"',lastname='"+txt_newMember_lastName.Text +"',address='"+txt_newmember_address.Text+"',birthday='"+dtp_newMember_birthday.Text+"',NIC='"+txt_newMember_NIC.Text+"',phone='"+txt_newMember_phone.Text+"',bloodgroup ='"+dpDown_member_bldgrp.selectedValue.ToString()+"',height='"+txt_newMember_height.Text+"',weight='"+txt_newMember_weight.Text+"',plantype='"+dpDown_newMember_mPlan.selectedValue.ToString()+"',disabilities='"+txt_memberDisabilities.Text+"' WHERE memberID='"+txt_update_search_member.Text+"' ";
           MySqlConnection con2 = new MySqlConnection(conString);
           MySqlCommand cmd2 = new MySqlCommand(updateQuery, con2);
           MySqlDataReader mReader;

           try
           {

                if (txt_newMemebr_Fname.Text == "")
                {
                    MessageBox.Show("please edit the required field if you want to update the member!");
                    txt_newMemebr_Fname.Focus();
                }              
                else if (txt_newmember_address.Text == "")
                {
                    MessageBox.Show("please edit the required field if you want to update the member!");
                    txt_newmember_address.Focus();
                }
                else if (txt_newMember_NIC.Text == "")
                {
                    MessageBox.Show("please edit the required field if you want to update the member!");
                    txt_newMember_NIC.Focus();
                }
                else if (txt_newMember_phone.Text == "")
                {
                    MessageBox.Show("please edit the required field if you want to update the member!");
                    txt_newMember_phone.Focus();
                }
                else if (txt_newMember_height.Text == "")
                {
                    MessageBox.Show("please edit the required field if you want to update the member!");
                    txt_newMember_height.Focus();
                }
                else if (txt_newMember_weight.Text == "")
                {
                    MessageBox.Show("please edit the required field if you want to update the member!");
                    txt_newMember_weight.Focus();
                }
                else
                {
                    con2.Open();
                    mReader = cmd2.ExecuteReader();
                    MessageBox.Show("Member record updated successfully!");

                    txt_update_search_member.Text = "";
                    txt_newMemebr_Fname.Text = "";
                    txt_newMember_lastName.Text = "";
                    txt_newmember_address.Text = "";
                    dtp_newMember_birthday.Text = "";
                    txt_newMember_NIC.Text = "";
                    txt_newMember_phone.Text = "";
                    txt_newMember_height.Text = "";
                    txt_newMember_weight.Text = "";
                    txt_memberDisabilities.Text = "";
                }
            

            }
            catch(Exception ex)
           {
               MessageBox.Show("Unable to update member record due to " + ex);
           }
        }

        private void btn_updatemember_search_Click(object sender, EventArgs e)
        {
           string conString = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
           string searchQuery = "SELECT * FROM membertable WHERE memberID =" + (txt_update_search_member.Text);
           MySqlConnection con1 = new MySqlConnection(conString);
           MySqlCommand cmd1 = new MySqlCommand(searchQuery, con1);
           MySqlDataReader reader;
           //int count = 0;

            if(txt_update_search_member.Text == "")
            {
                MessageBox.Show("Please enter ID of the member!");
            }
            else
            {
                con1.Open();
                reader = cmd1.ExecuteReader();

                if (reader.Read())
                {
                    txt_newMemebr_Fname.Text = (reader["firstname"].ToString());
                    txt_newMember_lastName.Text = (reader["lastname"].ToString());
                    txt_newmember_address.Text = (reader["address"].ToString());
                    txt_newMember_NIC.Text = (reader["NIC"].ToString());
                    txt_newMember_phone.Text = (reader["phone"].ToString());
                    txt_newMember_height.Text = (reader["height"].ToString());
                    txt_newMember_weight.Text = (reader["weight"].ToString());
                    txt_memberDisabilities.Text = (reader["disabilities"].ToString());
                }
            }

           
        }

        private void txt_newMember_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!char.IsDigit(ch) && ch != 8 && ch !=46)
            {
                e.Handled = true;
               
            }
        }

        private void txt_newMember_height_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
               
            }
        }

        private void txt_newMember_weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                label1.Text = "not valid";
            }
        }

        private void txt_update_search_member_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txt_update_search_member_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_newMemebr_Fname.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txt_newMemebr_Fname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_newMember_lastName.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txt_newMember_lastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_newmember_address.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txt_newmember_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_newMember_NIC.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txt_newMember_NIC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txt_newMember_phone.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txt_newMember_phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_newMember_height.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txt_newMember_height_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_newMember_weight.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txt_newMember_weight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_memberDisabilities.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        
    }
}
