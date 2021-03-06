﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webshopclient.MyWebshopContract {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.datacontract.org/2004/07/MyWebshopContract")]
    [System.SerializableAttribute()]
    public partial class Item : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductIdField, value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stock {
            get {
                return this.StockField;
            }
            set {
                if ((this.StockField.Equals(value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EventType", Namespace="http://schemas.datacontract.org/2004/07/MyWebshopContract")]
    public enum EventType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        updateListEvent = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        outOfStockEvent = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="MyWebshopContract", ConfigurationName="MyWebshopContract.IWebshop", CallbackContract=typeof(webshopclient.MyWebshopContract.IWebshopCallback))]
    public interface IWebshop {
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/GetWebshopName", ReplyAction="MyWebshopContract/IWebshop/GetWebshopNameResponse")]
        string GetWebshopName();
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/GetWebshopName", ReplyAction="MyWebshopContract/IWebshop/GetWebshopNameResponse")]
        System.Threading.Tasks.Task<string> GetWebshopNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/GetProductList", ReplyAction="MyWebshopContract/IWebshop/GetProductListResponse")]
        System.Collections.Generic.List<webshopclient.MyWebshopContract.Item> GetProductList();
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/GetProductList", ReplyAction="MyWebshopContract/IWebshop/GetProductListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<webshopclient.MyWebshopContract.Item>> GetProductListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/GetProductInfo", ReplyAction="MyWebshopContract/IWebshop/GetProductInfoResponse")]
        string GetProductInfo(string ProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/GetProductInfo", ReplyAction="MyWebshopContract/IWebshop/GetProductInfoResponse")]
        System.Threading.Tasks.Task<string> GetProductInfoAsync(string ProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/BuyProduct", ReplyAction="MyWebshopContract/IWebshop/BuyProductResponse")]
        bool BuyProduct(string ProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/BuyProduct", ReplyAction="MyWebshopContract/IWebshop/BuyProductResponse")]
        System.Threading.Tasks.Task<bool> BuyProductAsync(string ProductId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWebshopCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/productShipped", ReplyAction="MyWebshopContract/IWebshop/productShippedResponse")]
        void productShipped(string productId, System.DateTime shippingMoment);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWebshopChannel : webshopclient.MyWebshopContract.IWebshop, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebshopClient : System.ServiceModel.DuplexClientBase<webshopclient.MyWebshopContract.IWebshop>, webshopclient.MyWebshopContract.IWebshop {
        
        public WebshopClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public WebshopClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public WebshopClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public WebshopClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public WebshopClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public string GetWebshopName() {
            return base.Channel.GetWebshopName();
        }
        
        public System.Threading.Tasks.Task<string> GetWebshopNameAsync() {
            return base.Channel.GetWebshopNameAsync();
        }
        
        public System.Collections.Generic.List<webshopclient.MyWebshopContract.Item> GetProductList() {
            return base.Channel.GetProductList();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<webshopclient.MyWebshopContract.Item>> GetProductListAsync() {
            return base.Channel.GetProductListAsync();
        }
        
        public string GetProductInfo(string ProductId) {
            return base.Channel.GetProductInfo(ProductId);
        }
        
        public System.Threading.Tasks.Task<string> GetProductInfoAsync(string ProductId) {
            return base.Channel.GetProductInfoAsync(ProductId);
        }
        
        public bool BuyProduct(string ProductId) {
            return base.Channel.BuyProduct(ProductId);
        }
        
        public System.Threading.Tasks.Task<bool> BuyProductAsync(string ProductId) {
            return base.Channel.BuyProductAsync(ProductId);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyWebshopContract.IEventContract", CallbackContract=typeof(webshopclient.MyWebshopContract.IEventContractCallback))]
    public interface IEventContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventContract/Subscribe", ReplyAction="http://tempuri.org/IEventContract/SubscribeResponse")]
        void Subscribe(webshopclient.MyWebshopContract.EventType mask);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventContract/Subscribe", ReplyAction="http://tempuri.org/IEventContract/SubscribeResponse")]
        System.Threading.Tasks.Task SubscribeAsync(webshopclient.MyWebshopContract.EventType mask);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventContract/Unsubscribe", ReplyAction="http://tempuri.org/IEventContract/UnsubscribeResponse")]
        void Unsubscribe(webshopclient.MyWebshopContract.EventType mask);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventContract/Unsubscribe", ReplyAction="http://tempuri.org/IEventContract/UnsubscribeResponse")]
        System.Threading.Tasks.Task UnsubscribeAsync(webshopclient.MyWebshopContract.EventType mask);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEventContractCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IEventContract/updateListEvent")]
        void updateListEvent();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IEventContract/outOfStockEvent")]
        void outOfStockEvent();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEventContractChannel : webshopclient.MyWebshopContract.IEventContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EventContractClient : System.ServiceModel.DuplexClientBase<webshopclient.MyWebshopContract.IEventContract>, webshopclient.MyWebshopContract.IEventContract {
        
        public EventContractClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public EventContractClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public EventContractClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public EventContractClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public EventContractClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Subscribe(webshopclient.MyWebshopContract.EventType mask) {
            base.Channel.Subscribe(mask);
        }
        
        public System.Threading.Tasks.Task SubscribeAsync(webshopclient.MyWebshopContract.EventType mask) {
            return base.Channel.SubscribeAsync(mask);
        }
        
        public void Unsubscribe(webshopclient.MyWebshopContract.EventType mask) {
            base.Channel.Unsubscribe(mask);
        }
        
        public System.Threading.Tasks.Task UnsubscribeAsync(webshopclient.MyWebshopContract.EventType mask) {
            return base.Channel.UnsubscribeAsync(mask);
        }
    }
}
