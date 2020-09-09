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
        dictionary.TryAdd("1", "First");
        dictionary.TryAdd("2", "Second");
        dictionary.TryAdd("3", "Third");
        dictionary.TryAdd("4", "Fourth");

        bool firstItemFound = dictionary.ContainsKey("1"); //Returns true
        Console.WriteLine(firstItemFound);
        bool fifthItemFound = dictionary.ContainsKey("5"); //Returns false
        Console.WriteLine(fifthItemFound);
    }
}