using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Programme2
{
    public static void Main(string[] args)
    {
        //create a string 'str1'   
        string str1 = "Welcome to Java T Point.Com";
        //here StringSplitOptions.RemoveEmptyEntries() is used to remove the spaces between the words.  
        var result = from s in str1.ToLowerInvariant().Split(new char[] { 't' })
                     select s;
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();
    }
}