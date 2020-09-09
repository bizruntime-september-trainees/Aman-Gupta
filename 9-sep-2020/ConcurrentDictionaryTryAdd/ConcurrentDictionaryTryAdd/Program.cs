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
        ConcurrentDictionary<string, string> dict = new ConcurrentDictionary<string, string>();
        dict.TryAdd("1", "First");
        dict.TryAdd("2", "Second");
        foreach (var item in dict)
        {
            Console.WriteLine(item.Key + "-" + item.Value);
        }
    }

}
