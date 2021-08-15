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
    public partial class newEquipment : Form
    {
        public newEquipment()
        {
            InitializeComponent();
        }

        private void btn_exit_newStaffForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_itemUpdate_search_Click(object sender, EventArgs e)
        {
            string conString = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            string searchQuery = "SELECT * FROM inventorytable WHERE equipmentID =" + txt_item_search_member.Text;
            MySqlConnection con1 = new MySqlConnection(conString);
            MySqlCommand cmd1 = new MySqlCommand(searchQuery, con1);
            MySqlDataReader reader;
            //int count = 0;

            if (txt_item_search_member.Text == "")
            {
                MessageBox.Show("Please enter the Equipment ID!");
            }
            else
            {
                con1.Open();
                reader = cmd1.ExecuteReader();

                if (reader.Read())
                {
                    txt_newEquip_category.Text = (reader["catagory"].ToString());
                    txt_newEquip_Name.Text = (reader["name"].ToString());
                    txt_newEquip_Quantity.Text = (reader["quantity"].ToString());
                    txt_newEquip_Seller.Text = (reader["seller"].ToString());
                    txt_newEquip_price.Text = (reader["price"].ToString());


                }
            }

          
        }

        private void btn_upadateItem_Click(object sender, EventArgs e)
        {
            string conString = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            string updateQuery = "UPDATE inventorytable SET catagory='" + txt_newEquip_category.Text + "',name='" + txt_newEquip_Name.Text + "',quantity='" + txt_newEquip_Quantity.Text + "',seller='" + txt_newEquip_Seller.Text + "',datepurchased='" + dtp_newEquip_Date.Text + "',price='" + txt_newEquip_price.Text + "' WHERE equipmentID='" + txt_item_search_member.Text + "' ";
            MySqlConnection con2 = new MySqlConnection(conString);
            MySqlCommand cmd2 = new MySqlCommand(updateQuery, con2);
            MySqlDataReader mReader;

            try
            {
                if (txt_newEquip_category.Text == "")
                {
                    MessageBox.Show("please edit the field if you wish to update an item!");
                    txt_newEquip_category.Focus();
                }
                else if (txt_newEquip_Name.Text == "")
                {
                    MessageBox.Show("please edit the field if you wish to update an item!");
                    txt_newEquip_Name.Focus();
                }
                else if (txt_newEquip_Quantity.Text == "")
                {
                    MessageBox.Show("please edit the field if you wish to update an item!");
                    txt_newEquip_Quantity.Focus();
                }
                else if (txt_newEquip_Seller.Text == "")
                {
                    MessageBox.Show("please edit the field if you wish to update an item!");
                    txt_newEquip_Seller.Focus();
                }
                else if (txt_newEquip_price.Text == "")
                {
                    MessageBox.Show("please edit the field if you wish to update an item!");
                    txt_newEquip_price.Focus();
                }
                else
                {
                    con2.Open();
                    mReader = cmd2.ExecuteReader();
                    MessageBox.Show("Item record updated successfully!");

                    txt_item_search_member.Text = "";
                    txt_newEquip_category.Text = "";
                    txt_newEquip_Name.Text = "";
                    txt_newEquip_Quantity.Text = "";
                    txt_newEquip_Seller.Text = "";
                    txt_newEquip_price.Text = "";
                }
               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update Item record due to " + ex);
            }
        }

        private void btn_AddEquip_Click(object sender, EventArgs e)
        {
            string connection = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            //insert query
            string insertUserQuery = "INSERT INTO inventorytable (catagory,name,quantity,seller,datepurchased,price)  values ('" + this.txt_newEquip_category.Text + "','" + this.txt_newEquip_Name.Text + "','" + this.txt_newEquip_Quantity.Text + "','" + this.txt_newEquip_Seller.Text + "','" + this.dtp_newEquip_Date.Text + "','" + this.txt_newEquip_price.Text + "')";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(insertUserQuery, con);
            MySqlDataReader dataReader;
            //,'" + this.dtp_userDOB.Text.ToString() + "'

            try
            {
                if (txt_newEquip_category.Text == "")
                {
                    MessageBox.Show("please fill the required fields!");
                    txt_newEquip_category.Focus();
                }
                else if (txt_newEquip_Name.Text == "")
                {
                    MessageBox.Show("please fill the required fields!");
                    txt_newEquip_Name.Focus();
                }
                else if (txt_newEquip_Quantity.Text == "")
                {
                    MessageBox.Show("please fill the required fields!");
                    txt_newEquip_Quantity.Focus();
                }
                else if (txt_newEquip_Seller.Text == "")
                {
                    MessageBox.Show("please fill the required fields!");
                    txt_newEquip_Seller.Focus();
                }
                else if (txt_newEquip_price.Text == "")
                {
                    MessageBox.Show("please fill the required fields!");
                    txt_newEquip_price.Focus();
                }
                else
                {
                    con.Open();
                    dataReader = cmd.ExecuteReader();

                    MessageBox.Show("Added Equipment to the inventory successfully!");

                    txt_newEquip_category.Text = "";
                    txt_newEquip_Name.Text = "";
                    txt_newEquip_Quantity.Text = "";
                    txt_newEquip_Seller.Text = "";
                    txt_newEquip_price.Text = "";
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Equipment Add unsuccessful due to " + ex);
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

        private void txt_newEquip_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txt_item_search_member_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txt_item_search_member_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_newEquip_category.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txt_newEquip_category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_newEquip_Name.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txt_newEquip_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_newEquip_Quantity.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txt_newEquip_Quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txt_newEquip_Seller.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txt_newEquip_Seller_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_newEquip_price.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
