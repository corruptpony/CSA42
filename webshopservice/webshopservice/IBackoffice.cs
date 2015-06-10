using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace MyWebshopContract
{
    [ServiceContract(Namespace = "server")]
    interface IBackoffice
    {
        [OperationContract]
        List<Order> GetOrderList();
        [OperationContract]
        bool ShipOrder(string ProductId);
    }

    [DataContract]
    public class Order
    {
        [DataMember]
        public string ProductId { get; set; }
        [DataMember]
        public DateTime Moment { get; set; }
        [DataMember]
        public IWebshopCallback WebshopCallback { get; set; }
    }
}
