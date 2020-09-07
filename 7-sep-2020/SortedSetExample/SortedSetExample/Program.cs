using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSetExample
{
    public class SortedSetProgram
    {
        static public void Main()
        {
 
            SortedSet<int> my_Set = new SortedSet<int>();

    
            my_Set.Add(101);
            my_Set.Add(1001);
            my_Set.Add(10001);
            my_Set.Add(100001);
 
            if (my_Set.Contains(101) == true)
            {
                Console.WriteLine("Element is available..!");
            }

            else
            {
                Console.WriteLine("Element is not available..!");
            }
        }
    }
}
