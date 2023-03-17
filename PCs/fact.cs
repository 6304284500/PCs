using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCs
{
    public  class fact
    {
        public void For2()
        {
            Console.WriteLine("Enter the number that you want the factorial of");
            int k = Convert.ToInt32(Console.ReadLine());
            int i, fact=1;
            for (i = 1 ;  i<= k  ; ++i) 
            {
                fact = fact * i;
                
                Console.WriteLine("i.e {0}X{1}",k,i);
            }
            Console.WriteLine("The Factorial of a given Number {0} is = {1} ",k,fact);

        }

    }
}
