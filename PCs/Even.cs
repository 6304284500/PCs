using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCs
{
    internal class UC2
    {
        public void two()
        {
            Console.WriteLine("Enter a Number to check weather Even or Odd");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num%2==0)
            { Console.WriteLine("The given Number={0} is an Even number", num); }
            else  
            { Console.WriteLine("The given Number={0} is an Odd number", num); }

            
        }
    }
}
