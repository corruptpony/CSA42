using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MyWebshopContract
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class CBackoffice : IBackoffice
    {
        public static List<Order> orders = new List<Order>();

        public void addOrder(string ProductId, IWebshopCallback callback)
        {
            Order order = new Order();
            order.ProductId = ProductId;
            order.Moment = DateTime.Now;
            order.WebshopCallback = callback;
            orders.Add(order);
        }

        public List<Order> GetOrderList()
        {
            return orders;
        }

        public bool ShipOrder(string ProductId)
        {
            foreach (Order o in orders)
            {
                if(o.ProductId == ProductId)
                {
                    orders.Remove(o);
                    o.WebshopCallback.productShipped(o.ProductId, DateTime.Now);
                    return true;
                }
            }

            return false;
        }
    }
}
