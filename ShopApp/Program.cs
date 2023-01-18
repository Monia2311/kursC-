
using ShopApp.Models;

Console.WriteLine("*********************ShopApp*****************");

var shoppingCart = new ShoppingCart();
shoppingCart.Products.Add(new Product{ ProductName = "Mleko", Price = 50.00m });
shoppingCart.Products.Add(new Product { ProductName = "Chleb", Price = 40.00m });
shoppingCart.Products.Add(new Product { ProductName = "Kawa", Price = 60.00m });
shoppingCart.Products.Add(new Product { ProductName = "Miód", Price = 70.00m });
//Product.ShowList();
Console.WriteLine("Wybierz produkt z listy");
var price = Console.ReadLine();
shoppingCart.GetPrice();
Console.WriteLine("Koszt produktów: " + shoppingCart.GetPrice());
shoppingCart.ClearCart();
