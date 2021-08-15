using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;
using MySql.Data.MySqlClient;

namespace EasyAdmin.gym_management_system
{
    public partial class viewMembers : Form
    {
        public viewMembers()
        {
            InitializeComponent();
            displayData();
        }

        private void BunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_exit_newmemberForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      public void displayData()
        {
            string connection = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            string displayQuery = "SELECT * FROM membertable";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(displayQuery, con);
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();

            try
            {
                myAdapter.SelectCommand = cmd;
                DataTable memberTable = new DataTable();
                myAdapter.Fill(memberTable);

                //create the binding source
                BindingSource bSource = new BindingSource();
                bSource.DataSource = memberTable;
                dgv_members.DataSource = bSource;
                myAdapter.Update(memberTable);

            }catch(Exception ex)
            {
                MessageBox.Show("unable to display data dur to " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            string searchQuery = "SELECT * FROM membertable WHERE memberID =" +txt_member_search.Text;
            MySqlConnection con1 = new MySqlConnection(conString);
            MySqlCommand cmd1 = new MySqlCommand(searchQuery, con1);
            MySqlDataReader reader;
            //int count = 0;

            if (txt_member_search.Text == "")
            {
                MessageBox.Show("enter Member ID!");
            }
            else
            {
                con1.Open();
                reader = cmd1.ExecuteReader();

                if (reader.Read())
                {
                    txt_memberName_delete.Text = (reader["firstname"].ToString());
                    txt_memberlastName_delete.Text = (reader["lastname"].ToString());
                    txt_MemberAddress_delete.Text = (reader["address"].ToString());
                    txt_MNIC_delete.Text = (reader["NIC"].ToString());
                    txt_Mphone_delete.Text = (reader["phone"].ToString());
                    txt_MBirthDay_delete.Text = (reader["birthday"].ToString());
                    txt_MBloodgroup_delete.Text = (reader["bloodgroup"].ToString());
                    txt_mHeight_delete.Text = (reader["height"].ToString());
                    txt_mWeight_delete.Text = (reader["weight"].ToString());
                    txt_MPlan_delete.Text = (reader["plantype"].ToString());
                    txt_memberDisabilities_delete.Text = (reader["disabilities"].ToString());
                }
            }
           
        }

        private void btn_member_Delete_Click(object sender, EventArgs e)
        {

            string conString = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            string deleteQuery = "DELETE FROM membertable WHERE memberID ='"+ txt_member_search.Text + "' " ;
            MySqlConnection con1 = new MySqlConnection(conString);
            MySqlCommand cmd1 = new MySqlCommand(deleteQuery, con1);
            MySqlDataReader reader;
            //int count = 0;
            try {

                con1.Open();
                reader = cmd1.ExecuteReader();
                MessageBox.Show("Member record deleted Successfully!");
                displayData();

                txt_MBirthDay_delete.Text = "";
                txt_MBloodgroup_delete.Text = "";
                txt_MemberAddress_delete.Text = "";
                txt_memberDisabilities_delete.Text = "";
                txt_memberlastName_delete.Text = "";
                txt_memberName_delete.Text = "";
                txt_member_search.Text = "";
                txt_mHeight_delete.Text = "";
                txt_MNIC_delete.Text = "";
                txt_Mphone_delete.Text = "";
                txt_MPlan_delete.Text = "";
                txt_mWeight_delete.Text = "";

            } catch(Exception ex)
            {
                MessageBox.Show("Unable to delete member due to" + ex);
            }
        }

        private void viewMembers_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void viewMembers_MouseDown(object sender, MouseEventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Barcode barcode = new Barcode();
            Color foreColor = Color.Black;
            Color backColor = Color.Transparent;
            Image img = barcode.Encode(TYPE.CODE39Extended, txt_MNIC_delete.Text, foreColor, backColor, (int)(pbox_barcode.Width * 0.8), (int)(pbox_barcode.Height * 0.8));
            pbox_barcode.Image = img;

        }

        private void btn_saveBarcode_Click(object sender, EventArgs e)
        {
            if (pbox_barcode.Image == null)
                return;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    pbox_barcode.Image.Save(saveFileDialog.FileName);
            }
        }

        private void btn_clear_member_Click(object sender, EventArgs e)
        {
            txt_MBirthDay_delete.Text = "";
            txt_MBloodgroup_delete.Text = "";
            txt_MemberAddress_delete.Text = "";
            txt_memberDisabilities_delete.Text = "";
            txt_memberlastName_delete.Text = "";
            txt_memberName_delete.Text = "";
            txt_member_search.Text = "";
            txt_mHeight_delete.Text = "";
            txt_MNIC_delete.Text = "";
            txt_Mphone_delete.Text = "";
            txt_MPlan_delete.Text = "";
            txt_mWeight_delete.Text = "";
            
            if(pbox_barcode.Image != null)
            {
                pbox_barcode.Image.Dispose();
                pbox_barcode.Image = null;
            }
            

        }

        private void viewMembers_Load(object sender, EventArgs e)
        {
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.FromArgb(28, 65, 77);
                }
            }

           /* string conString = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            string searchboxQuery = "SELECT firstname FROM membertable";
            MySqlConnection con1 = new MySqlConnection(conString);
            MySqlCommand cmd1 = new MySqlCommand(searchboxQuery, con1);
            MySqlDataReader reader;

            try
            {
                con1.Open();
                reader = cmd1.ExecuteReader();

                AutoCompleteStringCollection memberCollection = new AutoCompleteStringCollection();

                while (reader.Read())
                {
                    memberCollection.Add(reader.GetString(0));
                }

                txt_member_search.AutoCompleteCustomSource = memberCollection;

            }catch(Exception ex)
            {
                MessageBox.Show("Unable to complete action due to :" + ex);
            }*/
        }

        private void txt_member_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
