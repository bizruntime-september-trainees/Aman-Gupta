using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        //here we are creating the array Num type of int  
        int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine("Product of the element:");
        //Now we will calculate the Total Muliplication of the numbers by applying the Aggregate function  
        int ProductOfElement = Num.Where(obj => obj >= 5).Aggregate((a, b) => a * b);
        Console.WriteLine("Product is " + ProductOfElement); //Output 362880 ((((((((1*2)*3)*4)*5)*6)*7)*8)*9)  

        //create an array of string of the name charlist  
        string[] charlist = { "a", "b", "c", "d" };
        var concat = charlist.Aggregate((a, b) => a + ',' + b);//(((a,b),c),d)  
        Console.WriteLine("the Concatenated String: " + concat); // Output a,b,c,d  

    }
}