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
    public partial class MenuUI : Form
    {

        public MenuUI()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------------------------------

        private double CostOfPrice()
        {
            double sum = 0;

            for(int i = 0; i < gvOrder.Rows.Count; i++)
            {
                sum += (Convert.ToDouble(gvOrder.Rows[i].Cells[2].Value) * Convert.ToDouble(gvOrder.Rows[i].Cells[3].Value) );

            } // end of of loop

            return sum;

        } // end of CostOfPrice method

        //-----------------------------------------------------------------------------------

        private void AddCost()
        {
            double tax = Convert.ToDouble(txtTax.Text);

            double taxCal = (CostOfPrice() * tax) / 100;

            double total = tax + CostOfPrice();

            if (gvOrder.Rows.Count>0)
            {
                txtTotal.Text = (total).ToString();
                txtSubTotal.Text = (CostOfPrice()).ToString();

            } // end of if

        } // end of AddCost method

        //-----------------------------------------------------------------------------------

        private void MenuUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //-----------------------------------------------------------------------------------

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            TheCoffeeClubUI theCoffeeClubUI = new TheCoffeeClubUI();
            theCoffeeClubUI.Show();
        }

        //-----------------------------------------------------------------------------------

        private void MenuUI_Load(object sender, EventArgs e)
        {
            txtTax.Text = "1";

            //Check box
            CoffeeServer coffeeServer = new CoffeeServer();
           
            List<CoffeeModel> coffeeModels = coffeeServer.GetCoffeeList();

            foreach (var item in coffeeModels)
            {
                CheckBox chk = new CheckBox();
                chk.Width = 80;
                chk.Text = item.Coffee.ToString();
                chk.Name = item.Price.ToString();
                chk.CheckedChanged += new EventHandler(CheckBox_Checked);
                flwCheckBox.Controls.Add(chk);
            }

        } // end of MenuUI_Load

        
        int quantity = 1;
        int n=0;

        private void CheckBox_Checked(object sender, EventArgs e)
        {
            CheckBox chk = (sender as CheckBox);

            if(chk.Checked==false)
            {
                //MessageBox.Show("Please select");
            }
            else if(quantity<=0)
            {
                MessageBox.Show("Please enter quantity");
            }
            else
            {
                DataGridViewRow viewRow=new DataGridViewRow();

                viewRow.CreateCells(gvOrder);

                viewRow.Cells[0].Value = n;
                viewRow.Cells[1].Value = chk.Text;
                viewRow.Cells[2].Value = Convert.ToInt32(chk.Name);
                viewRow.Cells[3].Value = Convert.ToInt32(quantity);

                gvOrder.Rows.Add(viewRow);

                n++;

                AddCost();
            } 

        } // end of CheckBox

        //-----------------------------------------------------------------------------------

        private void btnResert_Click(object sender, EventArgs e)
        {
            txtTax.Text = "1";
            txtTotal.Text = String.Empty;
            txtSubTotal.Text = String.Empty;
            gvOrder.Rows.Clear();
            gvOrder.Refresh();

            foreach(Control control in flwCheckBox.Controls)
            {
                if (control is CheckBox)
                    ((CheckBox)(control)).Checked = false;
            }
        } // end of Resert button

        //-----------------------------------------------------------------------------------

        private void btnTotal_Click(object sender, EventArgs e)
        {
            AddCost();

        } // end of Total button

        //-----------------------------------------------------------------------------------

    } // end of MenuUI

} // end of TheCoffeeClub.UI
