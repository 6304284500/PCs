using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCs
{
   public  class Reverse
    {
        public void while1() 
        {
            string rev;
            Console.WriteLine("Enter an Word to reverse");
             string myStr = Console.ReadLine();
            rev = "";
            Console.WriteLine("String is {0}", myStr);
            // find string length
            int len;
            len = myStr.Length - 1;
            while (len >= 0)
            {
                rev = rev + myStr[len];
                len--;
            }
            Console.WriteLine("Reversed String is {0}", rev);
            Console.ReadLine();
        }

    }
}
