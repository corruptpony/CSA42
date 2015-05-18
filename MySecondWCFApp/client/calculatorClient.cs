using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using MyCalculatorContract;

namespace MyCalculatorService
{
    public partial class calculatorClient : Form
    {
        private MyCalculatorService.CalculatorClient proxy;

        public calculatorClient()
        {
            InitializeComponent();
            proxy = new MyCalculatorService.CalculatorClient();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbResult.Text = proxy.Add(Convert.ToDouble(tbN1.Text), Convert.ToDouble(tbN2.Text)).ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            tbResult.Text = proxy.Subtract(Convert.ToDouble(tbN1.Text), Convert.ToDouble(tbN2.Text)).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            tbResult.Text = proxy.Multiply(Convert.ToDouble(tbN1.Text), Convert.ToDouble(tbN2.Text)).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            tbResult.Text = proxy.Divide(Convert.ToDouble(tbN1.Text), Convert.ToDouble(tbN2.Text)).ToString();
        }
    }
}
