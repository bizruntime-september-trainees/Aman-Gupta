using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Programme2
{
    public static void Main(string[] args)
    {
        //create an array of type string  
        string[] array = { "Vaishali", "Shalu", "Akshay", "Akki" };

        var result = from a in array
                         // where a.ToLowerInvariant().StartsWith("s")
                     where a.StartsWith("S")
                     select a;
        //foreach loop is used to print the output which is in the result  
        foreach (string item in result)
        {
            Console.WriteLine(item);
        }
    }
}