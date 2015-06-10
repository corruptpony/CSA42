using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace webshopclient
{
    public partial class WebshopClient : Form, MyWebshopContract.IWebshopCallback
    {
        MyWebshopContract.WebshopClient proxy;

        public WebshopClient()
        {
            InitializeComponent();
            MyWebshopContract.IWebshopCallback callback = this;
            InstanceContext context = new InstanceContext(callback);
            proxy = new MyWebshopContract.WebshopClient(context);
        }

        private void btnGetName_Click(object sender, EventArgs e)
        {
            lblName.Text = proxy.GetWebshopName();
        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            updateLists();
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            if (lbId.SelectedItem != null)
            {
                string info = proxy.GetProductInfo(lbId.SelectedItem.ToString());
                updateLists();
                MessageBox.Show(info);
            }
            else
            {
                MessageBox.Show("Please select a product Id first.");
            }  
        }

        private void btnBuyProduct_Click(object sender, EventArgs e)
        {
            if (lbId.SelectedItem != null)
            {
                bool bought = proxy.BuyProduct(lbId.SelectedItem.ToString());

                if(bought)
                {
                    updateLists();
                }
                else
                {
                    MessageBox.Show("out of stock");
                }
            }
            else
            {
                MessageBox.Show("Please select a product Id first.");
            }  
        }

        private void updateLists()
        {
            lbId.Items.Clear();
            lbPrice.Items.Clear();
            lbStock.Items.Clear();

            List<MyWebshopContract.Item> items = proxy.GetProductList();
            if (items != null)
            {
                foreach (MyWebshopContract.Item i in items)
                {
                    lbId.Items.Add(i.ProductId);
                    lbPrice.Items.Add(i.Price.ToString());
                    lbStock.Items.Add(i.Stock.ToString());
                }
            }
            else
            {
                MessageBox.Show("is null");
            }
        }

        public void productShipped(string productId, DateTime shippingMoment)
        {
            lblName.Text = "your order of " + productId + " was shipped at " + shippingMoment.ToString() + ".";
        }
    }

    /*public class CWebshopCallback : MyWebshopContract.IWebshopCallback
    {
        public void productShipped(string productId, DateTime shippingMoment)
        {
            MessageBox.Show("your order of " + productId + " was shipped at " + shippingMoment.ToString() + ".");
        }
    }*/
}
