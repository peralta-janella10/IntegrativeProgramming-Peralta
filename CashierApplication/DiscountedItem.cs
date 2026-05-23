using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount) 
            : base(name, price, quantity)
        {
            item_discount = discount;
        }

        public double getTotalPrice()

        { 
            double discountValue = item_discount * 0.01;
            discounted_price = item_price - (item_price * discountValue);

            return discounted_price * item_quantity;
        }
            public new void setPayment (double amount)

        {
            payment_amount = amount;
            
        }
     
        public double getChange()
        {
            change = payment_amount - getTotalPrice();
            return change;


        }


    }
}
