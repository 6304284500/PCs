using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCs
{
    public class sums
    {
        public void UC9()
        {
            Console.WriteLine("Enter the number to find the sum of squares within its sequence");
            int n = Convert.ToInt32(Console.ReadLine ());
            int sum = 0;

            //calculating sum of squares from 1 to n
            for (int i = 1; i <= n; i++)
                sum += i * i;

            Console.WriteLine("Sum is: " + sum);
        } 
    }
}

