using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
public static class TaskProgram
{
    public static void Main()
    {
        Task t = Task.Run(() =>

        {
            for (int x = 0; x < 50; x++)
            {
                Console.Write("Hi ");
            }
        });
        t.Wait();
    }
}