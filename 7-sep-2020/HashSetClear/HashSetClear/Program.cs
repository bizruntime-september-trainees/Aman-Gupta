using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetClear
{
    class ProgramClear
    {

    
        public static void Main()
        {

             
            HashSet<int> mySet = new HashSet<int>(); 
            for (int i = 1; i <= 10; i++)
            {
                mySet.Add(i * 2);
            } 
            Console.WriteLine(mySet.Count); 
            mySet.Clear(); 
            Console.WriteLine(mySet.Count);
        }
    }
}
