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
    public partial class TheCoffeeClubUI : Form
    {
        
        //=================================================================================================

        public TheCoffeeClubUI()
        {
            InitializeComponent();
        }

        //=================================================================================================

        private void TheCoffeeClubUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //=================================================================================================

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuUI menuUI = new MenuUI();
            menuUI.Show();
        }

        //=================================================================================================

        private void btnNewOwner_Click(object sender, EventArgs e)
        {
            this.Hide();

            OwnerLoginUI ownerLoginUI = new OwnerLoginUI();
            ownerLoginUI.Show();
        }

        //=================================================================================================

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //=================================================================================================


    } // end of class TheCoffeeClubUI 
} // end of namespace
