using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        //Array countries is created of string type.  
        string[] countries = { "US", "UK", "Russia", "China", "Australia", "Argentina" };
        /*TakeWhile operator is used which will print the values until the specified condition is satisfied.*/
        var result = countries.TakeWhile(x => x.StartsWith("U"));
        //foreach loop will print the value of the result  
        foreach (string s in result)
        {
            Console.WriteLine(s);
        }
    }
}