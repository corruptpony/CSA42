using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MyWebshopContract
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class CWebshop : IWebshop
    {
        private static Database db;

        public string GetWebshopName()
        {
            return "Jaeqx ICT bookverlening";
        }

        public List<Item> GetProductList()
        {
            if(db == null)
            {
                db = new Database();
            }
            return db.getItems();
        }

        public string GetProductInfo(string ProductId)
        {
            foreach(Item i in db.getItems())
            {
                if(i.ProductId == ProductId)
                {
                    return i.ProductInfo;
                }
            }

            return "";
        }

        public bool BuyProduct(string ProductId)
        {
            foreach(Item i in db.getItems())
            {
                if(i.ProductId == ProductId)
                {
                    if(i.Stock > 0 && i.onSale)
                    {
                        i.Stock--;
                        IWebshopCallback callback = OperationContext.Current.GetCallbackChannel<IWebshopCallback>();
                        CBackoffice backend = new CBackoffice();
                        backend.addOrder(ProductId, callback);
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
