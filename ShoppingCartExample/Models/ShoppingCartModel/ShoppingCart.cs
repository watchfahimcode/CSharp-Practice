using ShoppingCartExample.Models.ProductsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartExample.Models.ShoppingCartModel
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            CartItems = new List<CartItem>();
        }

        public DateTime Date { get; set; }
        public List<CartItem> CartItems { get; set; }
        public int DiscountPercentage { get; set; }
        public int VATPercentage { get; set; }

        public double DeliveryCharge { get; set; }

        public double GetTotalProductPrice()
        {
            if (CartItems == null)
            {
                return 0;
            }

            if(CartItems.Count == 0)
            {
                return 0; 
            }

            double totalProductPrice = 0;

            foreach (CartItem item in CartItems)
            {
                totalProductPrice += item.GetTotalPrice();
            }

            return totalProductPrice;


        }

        public double GetDiscountAmount()
        {
            return GetTotalProductPrice() * (DiscountPercentage/100.0);
        }

        public double GetVATAmount()
        {
            return GetTotalProductPrice() * (VATPercentage / 100.0);
        }

        public double GetTotalPrice()
        {
            return GetTotalProductPrice()+DeliveryCharge+GetVATAmount()-GetDiscountAmount();
        }

        public bool AddProduct(Product product, int qty)
        {

            if (CartItems == null)
            {
                return false; 
            }

            bool isProductExists = false;
            foreach (CartItem item in CartItems)
            {
                if(item.Product.ProductNo ==product.ProductNo)
                {
                    item.Qty += qty;
                    isProductExists = true;
                    return true;
                }
            }

            
           var cartItem = new CartItem(product, qty);
            CartItems.Add(cartItem);
            return true; 
            
        }


        public string GetVoucher()
        {
            string message = "";

            message += $"Date: {Date.ToShortDateString()}" + Environment.NewLine;
            foreach(CartItem item in CartItems)
            {
                message += item.GetCartItemInfo() +Environment.NewLine;
            }
            message += $"--------------------------------------------------------------" + Environment.NewLine; ;
            message += $"Product Price: {GetTotalProductPrice()}" + Environment.NewLine;
            message += $"VAT Amount: {GetVATAmount()}" + Environment.NewLine;
            message += $"Delivery Charge: {DeliveryCharge}" + Environment.NewLine;
            message += $"Discount Amount: {GetDiscountAmount()}" + Environment.NewLine;
            message += $"--------------------------------------------------------------" + Environment.NewLine; ;
            message += $"Total: {GetTotalPrice()}" + Environment.NewLine;

            return message; 
        }
    }
}
