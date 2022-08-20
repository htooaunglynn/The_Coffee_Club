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
    public partial class OwnerControl : Form
    {
        private void NewRefresh()
        {
            OwnerServer ownerServer = new OwnerServer();

            gvOwnerListControl.DataSource = ownerServer.GetOwnerList();

            Resert();
        }

        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------

        public OwnerControl()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------

        private void OwnerControl_Load(object sender, EventArgs e)
        {
            OwnerServer ownerServer = new OwnerServer();

            gvOwnerListControl.DataSource = ownerServer.GetOwnerList();

            //gvOwnerListControl.Columns[3].Visible = false;
            //gvOwnerListControl.Columns[4].Visible = false;
        }

        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OwnerServer ownerServer = new OwnerServer();

            try
            {
                string password = txtPassword.Text;
                string comfirmPassword = txtPassword.Text;

                if(password.Equals(comfirmPassword))
                {
                    OwnerModel ownerModel = new OwnerModel();

                    ownerModel.Id = Convert.ToInt32(txtId.Text);
                    ownerModel.UserName = txtUserName.Text;
                    ownerModel.Email = txtEmail.Text;
                    ownerModel.Password = txtPassword.Text;
                    ownerModel.ComfirmPassword = txtComfirmPassword.Text;

                    
                    ownerServer.OwnerUpdate(ownerModel);
                    MessageBox.Show($"\nCommands completed successfully. \nCompletion time: {DateTime.Now}\n", "Update successed", MessageBoxButtons.OK);
                } // end of if

                else
                {
                    MessageBox.Show("Password and Comfirm do not match .", "Error occur!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } // end of (else)

            } // end of try
            catch (Exception error)
            {
                MessageBox.Show($"Update failed {error.Message}", "Error occur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            } // end of catch 

            NewRefresh();

        } // end  of btnUpdate_Click

        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }

        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("are you sure to delete?", "Deleting data", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                OwnerModel ownerModel = new OwnerModel();
                OwnerServer ownerServer = new OwnerServer();

                try
                {
                    ownerModel.Id = Convert.ToInt32(txtId.Text);
                    ownerServer.OwnerDelete(ownerModel);
                    MessageBox.Show($"\nCommands completed successfully. \nCompletion time: {DateTime.Now}\n", "Delete success", MessageBoxButtons.OK);

                }
                catch (Exception error)
                {
                    MessageBox.Show($"Delete failed {error.Message}", "Error occur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } // end of catch

                NewRefresh();

            } // end of if
        }

        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OwnerServer ownerServer = new OwnerServer();

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

                    ownerServer.OwnerAdd(ownerModel);
                    MessageBox.Show($"\nCommands completed successfully. \nCompletion time: {DateTime.Now}\n", "Success", MessageBoxButtons.OK);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Update failed {error.Message}", "Error occur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            NewRefresh();
        }
    } // end of OwnerControlUI class

} // end of Update
