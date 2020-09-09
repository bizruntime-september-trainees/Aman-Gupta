using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
public class Program
{
    public static void Main(string[] args)
    {
        //Data Source  
        List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
        //LINQ Query using Method Syntax  
        var MethodSyntax = integerList.Where(obj => obj > 5).ToList();
        //Execution  
        foreach (var item in MethodSyntax)
        {
            Console.Write(item + " ");
        }


    }
}

