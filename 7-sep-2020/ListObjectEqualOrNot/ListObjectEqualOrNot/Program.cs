using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListObjectEqualOrNot
{
    class ListObjectEqualOrNotProgram
    {


        public static void Main(String[] args)
        {
            List<string> list1 = new List<string>();
 
            list1.Add("DS");
            list1.Add("C++");
            list1.Add("Java");
            list1.Add("JavaScript");
 
            List<int> list2 = new List<int>();
 
            list2.Add(78);
            list2.Add(44);
            list2.Add(27);
            list2.Add(98);
            list2.Add(74);

            Console.WriteLine(list1.Equals(list2));
 
            List<int> list3 = new List<int>(); 
            list3 = list2;

            Console.WriteLine(list3.Equals(list2));
        }

    }
}