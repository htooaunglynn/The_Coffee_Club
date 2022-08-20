using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCoffeeClub.UI
{
    public partial class OwnerDashBoardUI : Form
    {
        

        public OwnerDashBoardUI()
        {
            InitializeComponent();
        }

        

        private void OwnerDashBoardUI_Load(object sender, EventArgs e)
        {
           
        }

        private void resToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OwnerRegistrationUI ownerRegistrationUI = new OwnerRegistrationUI();
            ownerRegistrationUI.MdiParent = this;
            ownerRegistrationUI.Show();
        }

        private void OwnerDashBoardUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OwnerItemControlUI ownerItemControlUI = new OwnerItemControlUI();
            ownerItemControlUI.MdiParent= this;
            ownerItemControlUI.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure logout?","Logout",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes)
            {
                this.Hide();
                OwnerLoginUI ownerLoginUI = new OwnerLoginUI();
                ownerLoginUI.Show();
            } // end of dialogResult (if)

        } // end of logoutToolStripMenuItem_Click

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OwnerControl ownerControl= new OwnerControl();
            ownerControl.MdiParent= this;
            ownerControl.Show();
        }
    } // end of OwnerDashBoardUI class

} // end of TheCoffeeClub namespace
