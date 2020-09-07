using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetContains
{
    class ProgramContain
    {

  
        public static void Main()
        { 
            HashSet<string> mySet = new HashSet<string>();
            
            mySet.Add("DS");
            mySet.Add("C++");
            mySet.Add("Java");
            mySet.Add("JavaScript");
            
            if (mySet.Contains("Java"))
                Console.WriteLine("Required Element is present");
            else
                Console.WriteLine("Required Element is not present");
        }
    }
}
