using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        CalculatorClient proxy;

        public Form1()
        {
            InitializeComponent();

            // instantiate a proxy to contact the service
            WSHttpBinding binding = new WSHttpBinding();
            Uri address = new Uri("http://localhost:8000/calculatorservice");
            EndpointAddress endpointAddress = new EndpointAddress(address);
            proxy = new CalculatorClient(binding, endpointAddress);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(tbN1.Text);
            double n2 = Convert.ToDouble(tbN2.Text);
            double result = proxy.Add(n1, n2);
            tbResult.Text = result.ToString();
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(tbN1.Text);
            double n2 = Convert.ToDouble(tbN2.Text);
            double result = proxy.Subtract(n1, n2);
            tbResult.Text = result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(tbN1.Text);
            double n2 = Convert.ToDouble(tbN2.Text);
            double result = proxy.Multiply(n1, n2);
            tbResult.Text = result.ToString();
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(tbN1.Text);
            double n2 = Convert.ToDouble(tbN2.Text);
            double result = proxy.Divide(n1, n2);
            tbResult.Text = result.ToString();
        }

        
    }
}
