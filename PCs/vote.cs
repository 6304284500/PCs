using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCs
{
    internal class UC3
    {
        public void three()
        {
            Console.WriteLine("Enter your age for casting your vote");
            int age =Convert.ToInt16 (Console.ReadLine());

            if (age>=18)
            {
                Console.WriteLine("You are Eligible To Vote\n");
            }
            else
            {
                Console.WriteLine("You are Not Eligible To Vote\n");
            }
        }
    }
}
