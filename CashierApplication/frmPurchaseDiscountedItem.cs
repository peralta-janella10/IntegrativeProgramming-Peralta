using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
      

        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string name = txtItem.Text;
            double price = Convert.ToDouble(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            double discount = Convert.ToDouble(txtDiscount.Text);

            DiscountedItem di = new DiscountedItem(name, price, quantity, discount);
            TotalAmount.Text = di.getTotalPrice().ToString("F2");
        }

        private void Total_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtItem.Text;
            double price = Convert.ToDouble(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            double discount = Convert.ToDouble(txtDiscount.Text);
            double payment = Convert.ToDouble(txtPayment.Text);

            DiscountedItem di = new DiscountedItem(name, price, quantity, discount);
            di.setPayment(payment);
            Change.Text = di.getChange().ToString("F2");
        }
    }
}
