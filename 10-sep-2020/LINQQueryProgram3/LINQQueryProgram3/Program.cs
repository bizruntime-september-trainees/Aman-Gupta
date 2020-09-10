using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Programme2
{
    public static void Main(string[] args)
    {
        //create an array numarray of type int  
        int[] numarray = { 1, 6, 9, 10, 50, 60, 100, 200, 300 };
        /*write LINQ query to get the data from the  numarray where the value is greater than 10 and less than 200*/
        var result = from a in numarray
                     where a > 10 && a < 200
                     select a;
        foreach (int item in result)
        {
            Console.WriteLine(item);
        }
    }
}