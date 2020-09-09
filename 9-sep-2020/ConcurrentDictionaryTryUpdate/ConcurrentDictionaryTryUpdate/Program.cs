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

        string newValue;

        bool returnTrue = dictionary.TryUpdate("1", "New Value", "First"); //Returns true
        dictionary.TryGetValue("1", out newValue);
        Console.WriteLine(newValue); //Print "New Value"

        bool returnsFalse = dictionary.TryUpdate("2", "New Value 2", "No Value"); //Returns false
        dictionary.TryGetValue("2", out newValue);  //Returns "Second" Old value
        Console.WriteLine(newValue);    //Print "Second"
    }
}


