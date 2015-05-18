using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using MyCalculatorContract;

namespace service
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a hosting process of CalculatorService
            ServiceHost host = new ServiceHost(typeof(CCalculator));

            // define an endpoint for the service
            Type contract = typeof(ICalculator);
            WSHttpBinding binding = new WSHttpBinding();
            Uri address = new Uri("http://localhost:8000/calculatorservice");
            host.AddServiceEndpoint(contract, binding, address);

            // start hosting
            host.Open();

            // console info
            Console.WriteLine("The service is being hosted at address " + address);
            Console.WriteLine("Press <ENTER> to stop hosting.\n");
            Console.ReadLine();

            // stop hosting
            host.Close();
        }
    }
}
