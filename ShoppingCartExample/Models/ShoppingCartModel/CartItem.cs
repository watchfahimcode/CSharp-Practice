using ShoppingCartExample.Models.ProductsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartExample.Models.ShoppingCartModel
{
    public class CartItem
    {
        public CartItem()
        {
            
        }

        public CartItem(Product product, int qty)
        {
            this.Product = product;
            this.Qty = qty;
        }
        public Product Product { get; set; }
        public int Qty { get; set; }

        public double GetProductPrice()
        {
            return Product.SalesPrice;
        }

        public double GetTotalPrice()
        {
            return Product.SalesPrice * Qty;
        }

        public string GetCartItemInfo()
        {
            string message = $"Product: {Product.ProductNo}-{Product.Name} Unit Price: {Product.SalesPrice} Qty:{Qty}";
            return message; 
        }

    }
}
