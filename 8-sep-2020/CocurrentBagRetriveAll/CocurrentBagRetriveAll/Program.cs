using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Threading;

namespace CocurrentBagRetriveAll
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            Task t1 = Task.Factory.StartNew(() =>
            {
                for (int i = 1; i < 10; i++)
                {
                    bag.Add(i);
                }
            });

            Task t2 = Task.Factory.StartNew(() =>
            {
                int i = 0;
                while (i != 4)
                {
                    foreach (var item in bag)
                    {
                        Console.WriteLine( item);
                    }
                 
                }

            });

            Task.WaitAll(t2);
        }
    }
}
