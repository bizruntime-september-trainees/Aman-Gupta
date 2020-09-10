using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        //create array of string type countries with the initialization  
        string[] countries = { "US", "UK", "India", "Russia", "China", "Australia", "Argentina" };
        /*skip method is used to with the IEnumerable to return the value which skip the third element of the array*/
        var result = countries.Skip(3);
        //foreach loop is used to print the element of the array  
        foreach (string s in result)
        {
            Console.WriteLine(s);
        }
    }
}