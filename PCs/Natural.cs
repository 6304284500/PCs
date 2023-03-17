using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCs
{
    public class Natural
    {
        public void while2() 
        {
            int j=1, sum = 0;

            Console.Write("\n\n");
            Console.Write("Find the sum of first 10 natural numbers:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("The first 10 natural number are :\n");
           
            while (j <= 10)
            {
                sum = sum + j;
                j++;
                Console.Write("{0} ", j);
            }
            Console.Write("\nThe Sum is : {0}\n", sum);
        }
    }
}
