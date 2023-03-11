using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XndirN1
{
    internal class Basket : Unit
    {
        public string user;
        public Basket(string user, string name, int price, double rating) : base(name, price, rating)
        {
            this.user = user;
        }
        public void HelloUser()
        {
            Console.WriteLine($"Hello, {user}");
        }
        public void PrintName()
        {
            Console.WriteLine($"In your basket is {name}");
        }
        public void PrintPrice()
        {
            Console.WriteLine($"The {name} price is {price}");
        }
        public void PrintRating()
        {
            Console.WriteLine($"The {name} rating is {rating}");
        }
    }
}
