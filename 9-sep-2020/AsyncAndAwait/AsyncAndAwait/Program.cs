using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Threading.Tasks;
    using System.Threading;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            DoAsyncWork obj = new DoAsyncWork();
            obj.CalculateSumAsync(10, 11);
            //Do Other processing
            Thread.Sleep(200);
            Console.WriteLine("Program Exiting");
        }
    }

    public class DoAsyncWork
    {
        public async void CalculateSumAsync(int i1, int i2)
        {
            int sum = await Task.Run(() => GetSum(i1, i2));
            Console.WriteLine("Value: " + sum);
        }

        public static int GetSum(int i1, int i2)
        {
            return i1 + i2;
        }
    }

}
