using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffeeClub.DAO;
using TheCoffeeClub.Model;

namespace TheCoffeeClub.UI
{
    public partial class OwnerLoginUI : Form
    {
        public OwnerLoginUI()
        {
            InitializeComponent();
        }

        private void OwnerLoginUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName=txtUserName.Text;
            string password=txtPassword.Text;

            OwnerServer ownerServer = new OwnerServer();
            OwnerModel ownerModel = ownerServer.GetOwnerListByUserNameAndPassword(userName, password);

            if(ownerModel != null)
            {
                this.Hide();
                OwnerDashBoardUI ownerDashBoardUI = new OwnerDashBoardUI();
                ownerDashBoardUI.Show();

            } // end of ownerModel (if)

            else
            {
                MessageBox.Show("Invalid owner!","Error occur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        } // end of btnLogin_Click

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = txtPassword.Text = String.Empty;

            this.Hide();
            TheCoffeeClubUI theCoffeeClubUI = new TheCoffeeClubUI();
            theCoffeeClubUI.Show();
        } // end of btnCancel

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
