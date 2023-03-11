using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XndirN3
{
    internal class B:T
    {
        public override void print()
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 10; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
