using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Threading;
public class Program
{
    public static void Main(string[] args)
    {
        ConcurrentBag<int> bag = new ConcurrentBag<int>();

        Task t1 = Task.Factory.StartNew(() =>
        {
            for (int i = 1; i < 10; ++i)
            {
                bag.Add(i);

            }
        });

        Task t2 = Task.Factory.StartNew(() =>
        {

            foreach (var item in bag)
            {
                Console.WriteLine(item);



            }

        });

        Task.WaitAll(t1, t2);
    }
}