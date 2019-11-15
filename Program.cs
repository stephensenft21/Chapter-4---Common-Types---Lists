using System.Security.Cryptography;
using System;
using System.Collections.Generic;

namespace listinfo
{
    class Program
    {
        static void Main(string[] args)
        {
        List<int> cohorts = new List<int>(); 
        cohorts.Add(34);
        cohorts.Add(35);
        cohorts.Add(36);
        cohorts.Add(37);
        //Another way we can init this list
        List<int> classes = new List<int>()
        {
         34,
         35,
         36,
         37,

        };

        classes.Remove(34);
        classes.Add(38);
        
        foreach(int nssClass in cohorts){
            
            if(nssClass == 35)
            {
            Console.WriteLine($"The Best Cohort: {nssClass}");
            }
            else
            {
                Console.WriteLine($"A Perfectly fine Cohort: {nssClass}");
            }

        }


        }
    
    }
}
