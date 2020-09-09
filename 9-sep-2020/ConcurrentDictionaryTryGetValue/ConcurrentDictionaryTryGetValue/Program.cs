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
        bool firstItem = dict.TryAdd("1", "First");
        bool secondItem = dict.TryAdd("2", "Second");
        string itemValue1;
        string itemValue2;

        bool isItemExists1 = dict.TryGetValue("1", out itemValue1);  //returns true
        Console.WriteLine(itemValue1); //Print "First"

        bool isItemExists2 = dict.TryGetValue("3", out itemValue2);  //returns false
        Console.WriteLine(itemValue2); //Print blank
    }
}


