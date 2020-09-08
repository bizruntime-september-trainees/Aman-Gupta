using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace ConcurrentBagCollection
{
    class Program
    {
        static void Main(string[] args)
        {
           /* List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);

            ConcurrentBag<int> bag = new ConcurrentBag<int>(ints);
            int count = bag.Count;
            Console.WriteLine(count);*/

            int[] arr = { 1, 2, 3 };

            ConcurrentBag<int> bag1 = new ConcurrentBag<int>();
            foreach (var item in arr)
            {
                bag1.Add(item);
            }
            int count1 = bag1.Count();
            Console.WriteLine(count1);
        }
    }
}
