using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Threading;
public class Program
{
    public static void Main(string[] args)
    {
        ConcurrentBag<int> bag = new ConcurrentBag<int>();
        AutoResetEvent autoEvent1 = new AutoResetEvent(false);

        Task t1 = Task.Factory.StartNew(() =>
        {
            for (int i = 1; i <= 4; ++i)
            {
                bag.Add(i);
            }
            //wait for second thread to add its items
            autoEvent1.WaitOne();

            while (bag.IsEmpty == false)
            {
                int item;
                if (bag.TryTake(out item))
                {
                    Console.WriteLine(item);
                }
            }
        });


        Task t2 = Task.Factory.StartNew(() =>
        {
            for (int i = 5; i <= 7; ++i)
            {
                bag.Add(i);
            }
            autoEvent1.Set();
        });

        t1.Wait();
    }
}