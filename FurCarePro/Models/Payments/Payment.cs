using FurCarePro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurCarePro.Models.Payments
{
    public class Payment : IPayment
    {
        public decimal Amount { get; set; }

        public string Method { get; set; }

        public void ProcessPayment()
        {
            MessageBox.Show(
                "Payment Processed");
        }
    }
}