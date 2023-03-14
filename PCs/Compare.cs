using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCs
{
    public class UC1
    {
        public void one()
        {
            Console.WriteLine("Enter the two values that has to be compared\n");
            int  a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the two values that has to be compared\n");
            int  b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("The Entered numbers {0}, {1} are equal", a, b);
            }
            else if (a > b || a < b)
            {
                if(a>b)
                {
                    Console.WriteLine("The Number a={0} is greater than b={1}", a, b);
                }
                else { Console.WriteLine("The Number b={0}  is greater than a={1}", b, a); }
                
            }
            
        }
    }
}

