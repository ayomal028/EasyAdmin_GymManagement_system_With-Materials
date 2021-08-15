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
    public partial class attendance : Form
    {
        public attendance()
        {
            InitializeComponent();
        }

        private void attendance_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.FromArgb(28, 65, 77);
                }
            }

        }

        private void lbl_role1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_newmemberForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
