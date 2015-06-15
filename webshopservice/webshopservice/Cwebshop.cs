using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MyWebshopContract
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class CWebshop : IWebshop, IEventContract
    {
        //item database
        private static Database db;

        //events
        public static Action m_updateLists = delegate { };
        public static Action m_outOfStock = delegate { };

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
                        FireEvent(EventType.updateListEvent);

                        if(i.Stock == 0)
                        {
                            FireEvent(EventType.outOfStockEvent);
                        }
                        return true;
                    }
                }
            }

            return false;
        }

        public void Subscribe(EventType mask)
        {
            IEvent subscriber = OperationContext.Current.GetCallbackChannel<IEvent>();

            if ((mask & EventType.updateListEvent) == EventType.updateListEvent)
            {
                m_updateLists += subscriber.updateListEvent;
            }
            else if((mask & EventType.outOfStockEvent) == EventType.outOfStockEvent)
            {
                m_outOfStock += subscriber.outOfStockEvent;
            }
        }

        public void Unsubscribe(EventType mask)
        {
            IEvent subscriber = OperationContext.Current.GetCallbackChannel<IEvent>();

            if ((mask & EventType.updateListEvent) == EventType.updateListEvent)
            {
                m_updateLists -= subscriber.updateListEvent;
            }
            else if ((mask & EventType.outOfStockEvent) == EventType.outOfStockEvent)
            {
                m_outOfStock -= subscriber.outOfStockEvent;
            }
        }

        public static void FireEvent(EventType eventType)
        {
            switch(eventType)
            {
                case EventType.updateListEvent:
                    m_updateLists();
                    break;
                case EventType.outOfStockEvent:
                    m_outOfStock();
                    break;
            }
        }
    }
}
