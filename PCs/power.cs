using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PCs
{
    public class UC8
    {
        public void For1() 
        {
            Console.WriteLine("Enter the value of the power");

            {
                int p;

                double q;
                Console.WriteLine("\n=======================================");
                Console.WriteLine("\n n    2 to power n      2 to power -n");
                Console.WriteLine("\n=======================================");
                Console.WriteLine("Enter the number uptil you need the power to be multiplied ");
                int n = Convert.ToInt32(Console.ReadLine());
                p = 1;
                for (n = 0; n < 11; ++n)
                {
                    if (n == 0)
                        p = 1;
                    else
                        p = p * 2;
                    q = 1.0 / (double)p;
                    Console.WriteLine("\n {0}   {1}  {2}", n, p, q);
                }

        }    }
    }
}
