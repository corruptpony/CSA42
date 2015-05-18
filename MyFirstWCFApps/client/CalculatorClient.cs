using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using MyCalculatorContract;

namespace client
{
    public interface ICalculatorChannel : ICalculator, IClientChannel
    {
    }

    public partial class CalculatorClient : ClientBase<ICalculator>, ICalculator
    {
        public CalculatorClient()
        {
        }

        public CalculatorClient(string endpointConfigurationName)
            : base(endpointConfigurationName)
        {
        }

        public CalculatorClient(string endpointConfigurationName, string remoteAddress)
            : base(endpointConfigurationName, remoteAddress)
        {
        }

        public CalculatorClient(string endpointConfigurationName, EndpointAddress remoteAddres)
            : base(endpointConfigurationName, remoteAddres)
        {
        }

        public CalculatorClient(System.ServiceModel.Channels.Binding binding, EndpointAddress remoteAddress)
            : base(binding, remoteAddress)
        {
        }

        public double Add(double n1, double n2)
        {
            return base.Channel.Add(n1, n2);
        }
        public double Subtract(double n1, double n2)
        {
            return base.Channel.Subtract(n1, n2);
        }
        public double Multiply(double n1, double n2)
        {
            return base.Channel.Multiply(n1, n2);
        }
        public double Divide(double n1, double n2)
        {
            return base.Channel.Divide(n1, n2);
        }
    }
}
