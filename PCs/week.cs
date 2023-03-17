using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PCs
{
    public class UC6
    {
        public void switch1()
        {
            Console.WriteLine("Enter the Value to the calender");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Its Sunday");
                    break;
                case 2:
                    Console.WriteLine("Its Monday");
                    break;
                case 3:
                    Console.WriteLine("Its Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Its Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Its Thursday");
                    break;
                case 6:
                    Console.WriteLine("Its Friday");
                    break;
                case 7:
                    Console.WriteLine("Its Saturday");
                    break;
                default:
                    Console.WriteLine("Enter the values between 1-7");
                    break;

            }
        }
    }
}
