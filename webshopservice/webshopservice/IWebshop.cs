using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWebshopContract
{
    [ServiceContract(Namespace = "MyWebshopContract")]
    public interface IWebshop
    {
        [OperationContract]
        string GetWebshopName();

        [OperationContract]
        List<Item> GetProductList();

        [OperationContract]
        string GetProductInfo(string ProductId);

        [OperationContract]
        bool BuyProduct(string ProductId);
    }

    [DataContract]
    public class Item
    {
        [DataMember]
        public string ProductId { get; set; }

        public string ProductInfo { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public int Stock { get; set; }

        public bool onSale { get; set; }
    }
}
