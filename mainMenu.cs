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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }




        private void Btn_Member_MouseEnter(object sender, EventArgs e)
        {
            panel_member.Visible = true;
        }

        private void Btn_newMember_Click(object sender, EventArgs e)
        {
            newMember mainMenu = new newMember();
            mainMenu.Show();
            
        }

        private void Panel_menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void Panel_menu_MouseDown(object sender, MouseEventArgs e)
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

        private void Btn_exit_newmemberForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_viewMember_Click(object sender, EventArgs e)
        {
            viewMembers mainMenu = new viewMembers();
            this.Hide();
            mainMenu.ShowDialog();
            this.Show();
            
        }

        private void btn_newStaff_Click(object sender, EventArgs e)
        {
            newStaff mainMenu = new newStaff();
            this.Hide();
            mainMenu.ShowDialog();
            this.Show();


        }

        private void btn_viewStaff_Click(object sender, EventArgs e)
        {
            viewstaff mainMenu = new viewstaff();
            this.Hide();
            mainMenu.ShowDialog();
            this.Show();
        }

        private void btn_newItems_Click(object sender, EventArgs e)
        {
            newEquipment mainMenu = new newEquipment();
            this.Hide();
            mainMenu.ShowDialog();
            this.Show();
        }

        private void btn_viewInventory_Click(object sender, EventArgs e)
        {
            inventory mainMenu = new inventory();
            this.Hide();
            mainMenu.ShowDialog();
            this.Show();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            if(lbl_role.Text == "trainer")
            {
                btn_newMember.Enabled = false;
                btn_newStaff.Enabled = false;
                btn_viewStaff.Enabled = false;
                btn_newItems.Enabled = false;
                btn_Expences.Enabled = false;
            }
        }

        private void btn_Expences_Click(object sender, EventArgs e)
        {
            expences mainMenu = new expences();
            this.Hide();
            mainMenu.ShowDialog();
            this.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Attendance_Click(object sender, EventArgs e)
        {
            attendance mainMenu = new attendance();
            this.Hide();
            mainMenu.ShowDialog();
            this.Show();
        }
    }

   
}
