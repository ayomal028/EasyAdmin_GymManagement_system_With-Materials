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
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
            DisplayInventory();
        }

        public void DisplayInventory()
        {

            string connection = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            string displayQuery = "SELECT * FROM inventorytable ";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand Icmd = new MySqlCommand(displayQuery, con);
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();

            try
            {
                myAdapter.SelectCommand = Icmd;
                DataTable inventorytable = new DataTable();
                myAdapter.Fill(inventorytable);

                //create the binding source
                BindingSource bSource = new BindingSource();
                bSource.DataSource = inventorytable;
                dgv_inventory.DataSource = bSource;
                myAdapter.Update(inventorytable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("unable to display data dur to " + ex);
            }
        }
        private void btn_exit_newmemberForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ItemSearch_delete_Click(object sender, EventArgs e)
        {
            string conString = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            string searchQuery = "SELECT * FROM inventorytable WHERE equipmentID =" + txt_item_search.Text;
            MySqlConnection con1 = new MySqlConnection(conString);
            MySqlCommand cmd1 = new MySqlCommand(searchQuery, con1);
            MySqlDataReader reader;
            //int count = 0;

            if (txt_item_search.Text == "")
            {
                MessageBox.Show("enter Equipment ID!");
            }
            else
            {
                con1.Open();
                reader = cmd1.ExecuteReader();

                if (reader.Read())
                {
                    txt_itemCategory_delete.Text = (reader["catagory"].ToString());
                    txt_itemName_delete.Text = (reader["name"].ToString());
                    txt_itemQuantity_delete.Text = (reader["quantity"].ToString());
                    txt_itemSeller_delete.Text = (reader["seller"].ToString());
                    txt_itemDate_delete.Text = (reader["datepurchased"].ToString());
                    txt_itemPrice_delete.Text = (reader["price"].ToString());

                }
            }  
        }

        private void btn_item_Delete_Click(object sender, EventArgs e)
        {

            string conString = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            string deleteQuery = "DELETE FROM inventorytable WHERE equipmentID ='" + txt_item_search.Text + "' ";
            MySqlConnection con1 = new MySqlConnection(conString);
            MySqlCommand cmd1 = new MySqlCommand(deleteQuery, con1);
            MySqlDataReader reader;
            
            try
            {

                con1.Open();
                reader = cmd1.ExecuteReader();
                MessageBox.Show("equipment record deleted Successfully!");
                DisplayInventory();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete item record due to" + ex);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            lastPoint = new Point(e.X, e.Y);
        }

        private void inventory_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void inventory_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btn_clear_item_Click(object sender, EventArgs e)
        {
            txt_itemCategory_delete.Text = "";
            txt_itemDate_delete.Text = "";
            txt_itemName_delete.Text = "";
            txt_itemPrice_delete.Text = "";
            txt_itemQuantity_delete.Text = "";
            txt_itemSeller_delete.Text = "";
            txt_item_search.Text = "";
            
        }

        private void txt_item_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
