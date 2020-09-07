using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListExample
{
    class SortedListProgram
    {
        static public void Main()
        {
 
            SortedList my_slist1 = new SortedList();
 
            my_slist1.Add(102, "This");
            my_slist1.Add(107, "Is");
            my_slist1.Add(104, "SortedList");
            my_slist1.Add(101, "Tutorial");

            foreach (DictionaryEntry pair in my_slist1)
            {
                Console.WriteLine("key and value"+
                          pair.Key +" :"+ pair.Value);
            }
            Console.WriteLine();
 
            SortedList my_slist2 = new SortedList() {
                                  { "b.ac", 234 },
                                  { "1.11", 395 },
                                  { "101", 405 },
                                  { "1167", 100 }};

            foreach (DictionaryEntry pair in my_slist2)
            {
                Console.WriteLine("key and value"+
                          pair.Key+ " :"+pair.Value);
            }
        }
    }
}
