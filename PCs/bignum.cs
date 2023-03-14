using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCs
{
   
        public class UC4
        {
            public void four()
            {
                Console.WriteLine("Enter the three numbers to start comparison\n");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                int num3 = Convert.ToInt32(Console.ReadLine());

                if (num1 > num2)
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine("Number 1- \t" + num1 + "   is greater than Number 2- \t" + num2 + " and Number 3-" + num3 + " ");
                    }
                    else
                    {
                        Console.WriteLine("Number 2 is \t" + num2 + " greater than Number 1 \t" + num1 + " and Number 3 \t " + num3 + " ");
                    }

                }
                else if (num2 > num1)
                {
                    if (num2 > num3)
                    {
                        Console.WriteLine("Number 2\t " + num2 + "  +   is greater than Number 1 \t" + num1 + " and Number 3 \t" + num3 + "");
                    }
                    else
                    {
                        Console.WriteLine("Number 3 \t " + num3 + "   is greater than Number 2 \t" + num2 + "and Number 1\t" + num1 + "");
                    }
                }
                else if (num3 > num1)
                {
                    if (num3 > num2)
                    {
                        Console.WriteLine("Number 3 \t" + num3 + "   is greater than Number 2 \t" + num2 + " and Number 1 \t" + num3 + "");
                    }
                    else
                    {
                        Console.WriteLine("Number 1  \t" + num1 + "    is greater than Number 2 \t" + num2 + " and Number 3 \t" + num3 + "");
                    }
                }
            }
        }
 }

