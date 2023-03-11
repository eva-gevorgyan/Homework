using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XndirN2
{
    internal class Phone
    {
        public string name { get;set; }
        private int number { get; set; }
        public Phone()
        {
            
        }
        public Phone(string name)
        {
            this.name = name;
        }
        public Phone(string name, int number)
        {
            this.name = name;
            this.number = number;
        }
        public Phone(int number)
        {
            this.number = number;
        }
        public void call_print()
        {
            Console.WriteLine($"{name} is calling you");
        }
        public int number_print(int number)
        {
            return number;
        }
    }
}
