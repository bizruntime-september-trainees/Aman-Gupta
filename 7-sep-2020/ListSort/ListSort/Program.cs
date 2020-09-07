using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSortProgram
{
    class ListSortProgram
    {

        static public void Main()
        {

            List<int> my_list = new List<int>();
            my_list.Add(496);
            my_list.Add(1000);
            my_list.Add(100);
            my_list.Add(10);
            my_list.Add(10000);
            my_list.Add(10000000);
            my_list.Add(1000000);
            my_list.Add(100000);
            my_list.Add(0000);
            
            Console.WriteLine("UnSorted List:");
            foreach (int a in my_list)
            {
                Console.WriteLine(a);
            }

            // After Sort method 
            my_list.Sort();
            Console.WriteLine("Sorted List:");
            foreach (int a in my_list)
            {
                Console.WriteLine(a);
            }
        }
    }

}
