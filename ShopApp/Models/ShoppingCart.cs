using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class ShoppingCart
    {
        public List<Product> Products { get; set; }

        public ShoppingCart()
        {
            Products = new List<Product>();
        }

        public decimal GetPrice()
        {
           return Products.Sum(x => x.Price);
        }

        public void ClearCart()
        {
            Products.Clear();
        }

        public void ShowList(List<Product> list)
        {
            Console.WriteLine($"Number of elements: {list.Count}");
            foreach (Product item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
 }
