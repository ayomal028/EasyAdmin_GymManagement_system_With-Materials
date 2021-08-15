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
    public partial class viewstaff : Form
    {
        public viewstaff()
        {
            InitializeComponent();
            DisplayStaffData();
        }

        public void DisplayStaffData()
        {

            string connection = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            string displayQuery = "SELECT * FROM stafftable";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand Scmd = new MySqlCommand(displayQuery, con);
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();

            try
            {
                myAdapter.SelectCommand = Scmd;
                DataTable staffTable = new DataTable();
                myAdapter.Fill(staffTable);

                //create the binding source
                BindingSource bSource = new BindingSource();
                bSource.DataSource = staffTable;
                dgv_Staff.DataSource = bSource;
                myAdapter.Update(staffTable);

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

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void btn_StaffSearch_delete_Click(object sender, EventArgs e)
        {
            string conString = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            string searchQuery = "SELECT * FROM stafftable WHERE staffID =" + txt_staff_search.Text;
            MySqlConnection con1 = new MySqlConnection(conString);
            MySqlCommand cmd1 = new MySqlCommand(searchQuery, con1);
            MySqlDataReader reader;
            //int count = 0;

            if (txt_staff_search.Text == "")
            {
                MessageBox.Show("enter Staff ID!");
            }
            else
            {
                con1.Open();
                reader = cmd1.ExecuteReader();

                if (reader.Read())
                {
                    txt_staffName_delete.Text = (reader["firstname"].ToString());
                    txt_staffLastName_delete.Text = (reader["lastname"].ToString());
                    txt_staffAddress_delete.Text = (reader["address"].ToString());
                    txr_staffNic_delete.Text = (reader["NIC"].ToString());
                    txt_Staffphone_delete.Text = (reader["phone"].ToString());
                    txt_StaffBday_delete.Text = (reader["birthday"].ToString());
                    txt_stafftype_delete.Text = (reader["stafftype"].ToString());

                }
            }
        }

        private void btn_staff_Delete_Click(object sender, EventArgs e)
        {
            string conString = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            string deleteQuery = "DELETE FROM stafftable WHERE staffID ='" + txt_staff_search.Text + "' ";
            MySqlConnection con1 = new MySqlConnection(conString);
            MySqlCommand cmd1 = new MySqlCommand(deleteQuery, con1);
            MySqlDataReader reader;
            //int count = 0;
            try
            {

                con1.Open();
                reader = cmd1.ExecuteReader();
                MessageBox.Show("Staff record deleted Successfully!");
                DisplayStaffData();

                txt_staff_search.Text = "";
                txt_staffName_delete.Text = "";
                txt_staffLastName_delete.Text = "";
                txt_staffAddress_delete.Text = "";
                txt_StaffBday_delete.Text = "";
                txt_Staffphone_delete.Text = "";
                txr_staffNic_delete.Text = "";
                txt_stafftype_delete.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete Staff member due to" + ex);
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

        private void viewstaff_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void viewstaff_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btn_clear_staff_Click(object sender, EventArgs e)
        {
            txt_staff_search.Text = "";
            txt_staffName_delete.Text = "";
            txt_staffLastName_delete.Text = "";
            txt_staffAddress_delete.Text = "";
            txt_StaffBday_delete.Text = "";
            txt_Staffphone_delete.Text = "";
            txr_staffNic_delete.Text = "";
            txt_stafftype_delete.Text = "";
        }
    }
}
