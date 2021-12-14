using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWWP
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelVKSubmenu.Visible = false;
            panelEKSubmenu.Visible = false;
            panelCustomersSubmenu.Visible = false;
            panelItemSubmenu.Visible = false;

        }


        private void hideSubMenu()
        {
            if (panelVKSubmenu.Visible == true) panelVKSubmenu.Visible = false;
            if (panelEKSubmenu.Visible == true) panelEKSubmenu.Visible = false;
            if (panelCustomersSubmenu.Visible == true) panelCustomersSubmenu.Visible = false;
            if (panelItemSubmenu.Visible == true) panelItemSubmenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void buttonVK_Click(object sender, EventArgs e)
        {
            showSubMenu(panelVKSubmenu);
        }
        #region VKSubMenu
        private void buttonVKOffer_Click(object sender, EventArgs e)
        {
            /*
            * code here
            */

            hideSubMenu();
            openCHildForm(new Form_VK_Offer());
        }

        private void buttonVKOrder_Click(object sender, EventArgs e)
        {
            /*
            * code here
            */

            hideSubMenu();
            openCHildForm(new Form_VK_Order());
        }

        private void buttonVKDeliveryNote_Click(object sender, EventArgs e)
        {
            /*
            * code here
            */

            hideSubMenu();
            openCHildForm(new Form_VK_DeliveryNote());
        }

        private void buttonVKBill_Click(object sender, EventArgs e)
        {
            /*
            * code here
            */

            hideSubMenu();
            openCHildForm(new Form_VK_Bill());
        }
        #endregion
        private void buttonEK_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEKSubmenu);
        }
        #region EKSubMenu
        private void buttonEKDemand_Click(object sender, EventArgs e)
        {
            /*
           * code here
           */

            hideSubMenu();
        }

        private void buttonEKPriceRequest_Click(object sender, EventArgs e)
        {
            /*
            * code here
            */

            hideSubMenu();
        }

        private void buttonEKOreder_Click(object sender, EventArgs e)
        {
            /*
         * code here
         */

            hideSubMenu();
        }

        private void buttonEKDeliveryNoteIn_Click(object sender, EventArgs e)
        {
            /*
         * code here
         */

            hideSubMenu();
        }

        private void buttonEKBillIn_Click(object sender, EventArgs e)
        {
            /*
         * code here
         */

            hideSubMenu();
        }
        #endregion
        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCustomersSubmenu);
        }
        #region CustomersSubMenu
        private void buttonCustomersCustomers_Click(object sender, EventArgs e)
        {
            /*
         * code here
         */
            openCHildForm(new Form_Customer_Customer());
            hideSubMenu();
        }

        private void buttonCustomersSupplier_Click(object sender, EventArgs e)
        {
            /*
         * code here
         */
            openCHildForm(new Form_Customer_Delivery());
            hideSubMenu();
        }

        private void buttonCustomersSupport_Click(object sender, EventArgs e)
        {
            /*
         * code here
         */
            openCHildForm(new Form_Customer_Partner());
            hideSubMenu();
        }

        private void buttonCustomersAll_Click(object sender, EventArgs e)
        {
            /*
         * code here
         */

            hideSubMenu();
        }
        #endregion
        private void buttonItems_Click(object sender, EventArgs e)
        {
            showSubMenu(panelItemSubmenu);
        }
        #region ItemSubMenu
        private void buttonItemItems_Click(object sender, EventArgs e)
        {
            /*
         * code here
         */

            hideSubMenu();
        }

        private void buttonItemWarehouse_Click(object sender, EventArgs e)
        {
            /*
         * code here
         */

            hideSubMenu();
        }

        private void buttonItemLists_Click(object sender, EventArgs e)
        {
            /*
         * code here
         */

            hideSubMenu();
        }

        private void buttonItemDatabase_Click(object sender, EventArgs e)
        {
            /*
         * code here
         */

            hideSubMenu();
        }
        #endregion
        private void buttonOptions_Click(object sender, EventArgs e)
        {
            /*
            * code here
            */

            hideSubMenu();
            openCHildForm(new Form_Options());
        }

        private Form activeForm = null;

        private void openCHildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();

                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
                childForm.BringToFront();
                childForm.Show();
        }
    }
}
