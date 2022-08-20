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
    public partial class OwnerRegistrationUI : Form
    {
        private void Resert()
        {
            txtId.Text = String.Empty;
            txtUserName.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtComfirmPassword.Text = String.Empty;
        }

        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------

        public OwnerRegistrationUI()
        {
            InitializeComponent();
        }

        private void OwnerRegistrationUI_Load(object sender, EventArgs e)
        {
           
        }

        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------

        private void OwnerRegistrationUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        
        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                string password = txtPassword.Text;
                string comfirmPassword = txtPassword.Text;

                if (password.Equals(comfirmPassword))
                {
                    OwnerModel ownerModel = new OwnerModel();

                    ownerModel.Id = Convert.ToInt32(txtId.Text);
                    ownerModel.UserName = txtUserName.Text;
                    ownerModel.Email = txtEmail.Text;
                    ownerModel.Password = txtPassword.Text;
                    ownerModel.ComfirmPassword = txtComfirmPassword.Text;

                    OwnerServer ownerServer = new OwnerServer();

                    ownerServer.OwnerRegistration(ownerModel);

                    MessageBox.Show($"\nCommands completed successfully. \nCompletion time: {DateTime.Now}\n", "Success", MessageBoxButtons.OK);

                } // end of password.Equals(comfirmPassword) (if)

                else
                {
                    MessageBox.Show("Password and Comfirm do not match .", "Error occur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } // end of (else)

            } // end of try

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            } // end of catch

            Resert();

        }  // end of btnRegistration_Click

        private void txtCancel_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    } // end of OwnerRegistrationUI

} // end of namespace
