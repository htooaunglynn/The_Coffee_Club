using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffeeClub.DAO;
using TheCoffeeClub.Model;

namespace TheCoffeeClub.UI
{
    public partial class OwnerItemControlUI : Form
    {

        public OwnerItemControlUI()
        {
            InitializeComponent();
        }

        private void OwnerItemControlUI_Load(object sender, EventArgs e)
        {
            CoffeeServer coffeeServer = new CoffeeServer();

            gvCoffeeList.DataSource = coffeeServer.GetCoffeeList(); 
        }

        private void OwnerItemControlUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------

        private void Researt()
        {
            txtCoffee.Text = "";
            txtPrice.Text = "";
            txtNo.Text = "";
            txtQty.Text = "1";
        }

        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CoffeeModel model=new CoffeeModel();

            CoffeeServer coffeeServer = new CoffeeServer();

            try
            {
                model.No = Convert.ToInt32(txtNo.Text);
                model.Coffee = txtCoffee.Text;
                model.Price = Convert.ToInt32(txtPrice.Text);
                model.Qty = Convert.ToInt32(txtQty.Text);

                coffeeServer.UpdateCoffee(model);
                MessageBox.Show($"\nCommands completed successfully. \nCompletion time: {DateTime.Now}\n", "Update successed",MessageBoxButtons.OK);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Update failed {error.Message}","Error occur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            gvCoffeeList.DataSource = coffeeServer.GetCoffeeList();

            Researt();
        }

        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("are you sure to delete?", "Deleting data", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                CoffeeModel model = new CoffeeModel();   

                CoffeeServer coffeeServer = new CoffeeServer();

                try
                {
                    model.No = Convert.ToInt32(txtNo.Text);

                    coffeeServer.DeleteCoffee(model);

                    MessageBox.Show($"\nCommands completed successfully. \nCompletion time: {DateTime.Now}\n","Delete success",MessageBoxButtons.OK);
                }
                catch (Exception error)
                {
                    MessageBox.Show($"Delete failed {error.Message}", "Error occur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                gvCoffeeList.DataSource = coffeeServer.GetCoffeeList();

                Researt();
            }
        }

        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------
        
        private void btnInsert_Click(object sender, EventArgs e)
        {
            CoffeeModel model = new CoffeeModel();

            CoffeeServer coffeeServer = new CoffeeServer();

            try
            {
                model.No = Convert.ToInt32(txtNo.Text);
                model.Coffee = txtCoffee.Text;
                model.Price = Convert.ToInt32(txtPrice.Text);
                model.Qty = Convert.ToInt32(txtQty.Text);

                coffeeServer.InsertCoffee(model);

                MessageBox.Show($"\nCommands completed successfully. \nCompletion time: {DateTime.Now}\n","Insert success",MessageBoxButtons.OK);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Insert failed {error.Message}", "Error occur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            gvCoffeeList.DataSource = coffeeServer.GetCoffeeList();

            Researt();
        }

        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------
    }
}
