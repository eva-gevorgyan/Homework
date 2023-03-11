using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XndirN1
{
    internal class Unit
    {
        public string name { get; set; }
        public int price { get; set; }
        public double rating { get; set; }
        public Unit(string name, int price, double rating)
        {
            this.name = name;
            this.price = price;
            this.rating = rating;
        }
        public Unit(string name)
        {
            this.name = name;
        }
        public void InStock()
        {
            Console.WriteLine($"There are {name}");
        }
    }
}
