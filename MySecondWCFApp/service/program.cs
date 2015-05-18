using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace service
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a hosting process of CalculatorService
            ServiceHost host = new ServiceHost(typeof(CCalculator));

            // start hosting
            host.Open();

            // console info
            Console.WriteLine("The service is being hosted");
            Console.WriteLine("Press <ENTER> to stop hosting.\n");
            Console.ReadLine();

            // stop hosting
            host.Close();
        }
    }
}
