// See https://aka.ms/new-console-template for more information


using ShoppingCartExample.Models.ProductsModel;
using ShoppingCartExample.Models.ShoppingCartModel;

var product = new Product()
{
    ProductNo = "HP9288",
    Name = "HP Laptop",
    Description = "Laptop Description",
    SalesPrice = 70000
};

var product2 = new Product()
{
    ProductNo = "IPhone8129",
    Name = "IPhone ",
    Description = "Iphone Description",
    SalesPrice = 120000

};

ShoppingCart shoppingCart = new ShoppingCart();

shoppingCart.AddProduct(product, 2);
shoppingCart.AddProduct(product, 1);
shoppingCart.AddProduct(product2, 1);

shoppingCart.DiscountPercentage = 15;
shoppingCart.VATPercentage = 10;
shoppingCart.DeliveryCharge = 60; 

var voucherInfo = shoppingCart.GetVoucher(); 




Console.WriteLine(voucherInfo);
