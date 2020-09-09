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
        bool firstItem = dict.TryAdd("1", "First");  //returns true
        Console.WriteLine(firstItem);
        bool secondItem = dict.TryAdd("2", "Second");  //returns  true
        Console.WriteLine(secondItem);
        bool thirdItem = dict.TryAdd("1", "Third"); //returns false;
        Console.WriteLine(thirdItem);
    }
}


