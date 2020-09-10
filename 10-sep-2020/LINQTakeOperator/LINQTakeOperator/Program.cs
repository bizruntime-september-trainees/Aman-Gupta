using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        //create an array countries of string type with the initialized array  
        string[] countries = { "India", "USA", "Russia", "China", "Australia", "Argentina" };
        //here take() method will return the value from the String array upto three numbers.  
        var result = countries.Take(3);
        foreach (string s in result)
        {
            Console.WriteLine(s);
        }
    }
}