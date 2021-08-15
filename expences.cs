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
    public partial class expences : Form
    {
        public expences()
        {
            InitializeComponent();
            displayExpences();
        }

        public void displayExpences()
        {
            string connection = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            string displayQuery = "SELECT * FROM expencestable";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(displayQuery, con);
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();

            try
            {
                myAdapter.SelectCommand = cmd;
                DataTable expencestable = new DataTable();
                myAdapter.Fill(expencestable);

                //create the binding source
                BindingSource bSource = new BindingSource();
                bSource.DataSource = expencestable;
                dgv_expences.DataSource = bSource;
                myAdapter.Update(expencestable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("unable to display data dur to " + ex);
            }
        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btn_expence_Add_Click(object sender, EventArgs e)
        {
            string connection = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            //insert quer
            string insertExpenceQuery = "INSERT INTO expencestable (Extype,datescheduled,amount,description)  values ('" + this.dpdown_expences.SelectedItem.ToString() + "','" + this.dtp_expences.Text + "','" + this.txt_expences_amount.Text + "','" + this.txt_expences_description.Text + "')";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(insertExpenceQuery, con);
            MySqlDataReader dataReader;
            //,'" + this.dtp_userDOB.Text.ToString() + "'

            try
            {
               
                    con.Open();
                    dataReader = cmd.ExecuteReader();

                    MessageBox.Show("Added the Expence successfully!");
                displayExpences();

                    dpdown_expences.Text = "";
                    dtp_expences.Text = "";
                    txt_expences_amount.Text = "";
                    txt_expences_description.Text = "";
                
                             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Expence Add unsuccessful due to " + ex);
            }
        }

        private void btn_expence_update_Click(object sender, EventArgs e)
        {
            string conString = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            string updateQuery = "UPDATE expencestable SET Extype='" + dpdown_expences.SelectedItem.ToString() + "',datescheduled='" +dtp_expences.Text + "',amount='" + txt_expences_amount.Text + "',description='" + txt_expences_description.Text + "' WHERE expenceID = '"+txt_expence_search.Text+"' ";
            MySqlConnection con2 = new MySqlConnection(conString);
            MySqlCommand cmd2 = new MySqlCommand(updateQuery, con2);
            MySqlDataReader mReader;

            try
            {
                    con2.Open();
                    mReader = cmd2.ExecuteReader();
                    MessageBox.Show("expence record updated successfully!");
                displayExpences();

                    dpdown_expences.Text = "";
                    dtp_expences.Text = "";
                    txt_expences_amount.Text = "";
                    txt_expences_description.Text = "";
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update expence record due to " + ex);
            }
        }

        private void btn_expencesSearch_Click(object sender, EventArgs e)
        {
            string conString = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            string searchQuery = "SELECT * FROM expencestable WHERE expenceID =" + txt_expence_search.Text;
            MySqlConnection con1 = new MySqlConnection(conString);
            MySqlCommand cmd1 = new MySqlCommand(searchQuery, con1);
            MySqlDataReader reader;
            //int count = 0;

            if(txt_expence_search.Text == "")
            {
                MessageBox.Show("enter expense ID!");
            }
            else
            {
                con1.Open();
                reader = cmd1.ExecuteReader();

                if (reader.Read())
                {
                    dpdown_expences.Text = (reader["Extype"].ToString());
                    dtp_expences.Text = (reader["datescheduled"].ToString());
                    txt_expences_amount.Text = (reader["amount"].ToString());
                    txt_expences_description.Text = (reader["description"].ToString());


                }
            }   
        }

        private void btn_expence_delete_Click(object sender, EventArgs e)
        {
            string conString = "datasource=localhost;port=3306;username=root;password=#Ktnhmau21;database=easy admin database";
            string deleteQuery = "DELETE FROM expencestable WHERE expenceID ='" + txt_expence_search.Text + "' ";
            MySqlConnection con1 = new MySqlConnection(conString);
            MySqlCommand cmd1 = new MySqlCommand(deleteQuery, con1);
            MySqlDataReader reader;
            //int count = 0;
            try
            {
               
                    con1.Open();
                    reader = cmd1.ExecuteReader();
                    MessageBox.Show("expence record deleted Successfully!");
                displayExpences();

                txt_expence_search.Text = "";
                txt_expences_amount.Text = "";
                txt_expences_description.Text = "";
                dpdown_expences.Text = "";
                dtp_expences.Text = "";



            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete expence record due to" + ex);
            }
        }

        private void btn_expence_clear_Click(object sender, EventArgs e)
        {
            txt_expence_search.Text = "";
            txt_expences_amount.Text = "";
            txt_expences_description.Text = "";
            dpdown_expences.Text = "";
            dtp_expences.Text = "";
        }

        private void btn_exit_expencesForm_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void expences_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void expences_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void txt_expence_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txt_expence_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_expences_amount.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txt_expences_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_expences_description.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
