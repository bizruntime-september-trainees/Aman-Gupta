using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        IEnumerable<int> result = from numbers in Num
                                  where numbers > 3
                                  select numbers;
        //Execution  
        foreach (var item in result)
        {
            Console.Write(item + " ");
        }
    }
}
