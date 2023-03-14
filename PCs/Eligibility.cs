using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PCs
{
    public class UC5
    {
        public void five() 
        {
            Console.WriteLine("To Check The Eligibilty please enter the obtained Marks as described subject-\n");
            Console.WriteLine("Maths=");
            int Mat = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Physics=");
            int Phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chemistry");
            int Chem = Convert.ToInt32(Console.ReadLine());
            int total= Mat+Chem+Phy;

            if (total >= 180)
            {
                if (Mat >= 65 && Chem >= 50 && Phy >= 55)
                {                                       
                  Console.WriteLine("Congragulations Your Eligible for Admission");                    
                }
                else if (Mat + total >= 140)
                {
                    Console.WriteLine("You are Eligible for Admission Under 2nd Criteria");
                }
                else
                {
                    Console.WriteLine("You are Not Eligible for Addmisions");
                }

            }
        
        
        
        
        
        
        
        }
    }
}
