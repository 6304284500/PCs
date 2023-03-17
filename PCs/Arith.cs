using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCs
{
    public class UC7
    {
        public void switch2()
        {
            Console.WriteLine("Enter The two values for Arithematic operation\n");
            int c = Convert.ToInt32(Console.ReadLine());    
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Option for Arithematic operation");
            int fact=Convert.ToInt32(Console.ReadLine()); 
            switch (fact)
            {
                case 0:
                   Console.WriteLine("The Sum of The entererd Two numbers{0}+{1}={2}",c,d,c+d);
                break;
                case 1:
                    Console.WriteLine("The subtraction of The entererd Two numbers{0}-{1}={2}", c, d, c - d);
                    break;
                case 2:
                    Console.WriteLine("The division of The entererd Two numbers{0}/{1}={2}", c, d, c/d);
                    break;
                case 3:
                    Console.WriteLine("The division of The entererd Two numbers{0}%{1}={2}", c, d, c % d);
                    break;
                default:
                    Console.WriteLine("Enter the coreect value");
                    break;
            }
       

        }
    }
}
