using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LunchOrder.UI
{
    public partial class frmLunchOrder : Form
    {
        public frmLunchOrder()
        {
            InitializeComponent();
        }

        /* EVENTS */

        private void radHamburger_CheckedChanged(object sender, EventArgs e)
        {
            // change add-on info for hamburger
            grbAddOn.Text = "Add-on Items ($.75/each)";

            chkAdd1.Text = "Lettuce, Tomato, and Onions";
            chkAdd2.Text = "Mayonnaise and Mustard";
            chkAdd3.Text = "French Fries";

            clearChecks();
        }

        private void radPizza_CheckedChanged(object sender, EventArgs e)
        {
            // change add-on info for pizza
            grbAddOn.Text = "Add-on Items ($.50/each)";

            chkAdd1.Text = "Pepperoni";
            chkAdd2.Text = "Sausage";
            chkAdd3.Text = "Olives";

            clearChecks();
        }

        private void radSalad_CheckedChanged(object sender, EventArgs e)
        {
            // change add-on info for salad
            grbAddOn.Text = "Add-on Items ($.25/each)";

            chkAdd1.Text = "Croutons";
            chkAdd2.Text = "Bacon Bits";
            chkAdd3.Text = "Bread Sticks";

            clearChecks();
        }

        private void chkAdd1_CheckedChanged(object sender, EventArgs e)
        {
            // clear labels if main or add-on items change
            clearLabels();
        }

        private void chkAdd2_CheckedChanged(object sender, EventArgs e)
        {
            // clear labels if main or add-on items change
            clearLabels();
        }

        private void chkAdd3_CheckedChanged(object sender, EventArgs e)
        {
            // clear labels if main or add-on items change
            clearLabels();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // calculate purchase information
            float fsub = 0, ftax = 0, faddonprice = 0;

            // get main item and add on info
            if (radHamburger.Checked)
            {
                // add price for main item
                fsub += (float)6.95;
                // set addon price
                faddonprice = (float).75;
            }
            else if (radPizza.Checked)
            {
                // add price for main item
                fsub += (float)5.95;
                // set addon price
                faddonprice = (float).5;
            }
            else    // radSalad.checked
            {
                // add price for main item
                fsub += (float)4.95;
                // set addon price
                faddonprice = (float).25;
            }

            // add add-on price for each add-on selected
            if (chkAdd1.Checked)
            {
                fsub += faddonprice;
            }
            if (chkAdd2.Checked)
            {
                fsub += faddonprice;
            }
            if (chkAdd3.Checked)
            {
                fsub += faddonprice;
            }

            // calculate tax
            ftax = (float).0775 * fsub;

            // display totals in labels
            lblSubDisplay.Text          = fsub.ToString("c");
            lblTaxDisplay.Text          = ftax.ToString("c");
            lblOrderTotalDisplay.Text   = (fsub + ftax).ToString("c");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // quit app
            Application.Exit();
        }

        /* FUNCTIONS */

        private void clearChecks()
        {
            // remove checks in chk boxes for add-ons
            chkAdd1.Checked = false;
            chkAdd2.Checked = false;
            chkAdd3.Checked = false;

            clearLabels();
        }

        private void clearLabels()
        {
            // clear totals in labels
            lblSubDisplay.Text = String.Empty;
            lblTaxDisplay.Text = String.Empty;
            lblOrderTotalDisplay.Text = String.Empty;
        }


    }
}
