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
    public partial class WebshopClient : Form, MyWebshopContract.IWebshopCallback, MyWebshopContract.IEventContractCallback
    {
        MyWebshopContract.WebshopClient proxy;
        MyWebshopContract.EventContractClient eventProxy;

        public WebshopClient()
        {
            InitializeComponent();
            MyWebshopContract.IWebshopCallback callback = this;
            InstanceContext context = new InstanceContext(callback);
            proxy = new MyWebshopContract.WebshopClient(context);

            MyWebshopContract.IEventContractCallback  eventCallback = this;
            InstanceContext eventContext = new InstanceContext(eventCallback);
            eventProxy = new MyWebshopContract.EventContractClient(eventContext);

            eventProxy.Subscribe(MyWebshopContract.EventType.updateListEvent);
            eventProxy.Subscribe(MyWebshopContract.EventType.outOfStockEvent);
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

        public void updateListEvent()
        {
            updateLists();
        }

        public void outOfStockEvent()
        {
            for(int i = 0; i < lbId.Items.Count; i++)
            {
                if(lbStock.Items[i].ToString() == "0")
                {
                    lbId.Items.Add(lbId.Items[i]);
                    lbPrice.Items.Add(lbPrice.Items[i]);
                    lbStock.Items.Add(lbStock.Items[i]);

                    lbId.Items.RemoveAt(i);
                    lbPrice.Items.RemoveAt(i);
                    lbStock.Items.RemoveAt(i);

                    return;
                }
            }
        }
    }
}
