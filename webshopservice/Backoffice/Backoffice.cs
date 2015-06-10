using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backoffice
{
    public partial class Backoffice : Form
    {
        server.BackofficeClient proxy;

        public Backoffice()
        {
            InitializeComponent();
            proxy = new server.BackofficeClient();
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            if(lbId.SelectedItem != null)
            {
                string product = lbId.SelectedItem.ToString();
                if (product != null)
                {
                    bool succes = proxy.ShipOrder(product);

                    if (succes)
                    {
                        int index = lbId.SelectedIndex;
                        lbId.Items.RemoveAt(index);
                        lbTime.Items.RemoveAt(index);
                        lblShipped.Text = product + " was shipped at " + DateTime.Now.ToString();
                    }
                    else
                    {
                        lblShipped.Text = "no valid order selected";
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lbId.Items.Clear();
            lbTime.Items.Clear();
            List<server.Order> orders = proxy.GetOrderList();
            if(orders.Count > 0)
            {
                foreach (server.Order o in orders)
                {
                    lbId.Items.Add(o.ProductId);
                    lbTime.Items.Add(o.Moment);
                }
            }            
        }
    }
}
