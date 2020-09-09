using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Threading;
public class Program
{
    public static void Main(string[] args)
    {
        ConcurrentDictionary<string, string> dictionary = new ConcurrentDictionary<string, string>();


        Task t1 = Task.Factory.StartNew(() =>
        {
            for (int i = 0; i < 100; ++i)
            {
                dictionary.TryAdd(i.ToString(), i.ToString());
            }
        });


        Task t2 = Task.Factory.StartNew(() =>
        {

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + "-" + item.Value);

            }
        });

        Task.WaitAll(t1, t2);
    }
}


