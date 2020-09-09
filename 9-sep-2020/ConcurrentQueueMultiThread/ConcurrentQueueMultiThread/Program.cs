using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Threading;
public class Program
{

	public static void Main(string[] args)
	{
		ConcurrentQueue<int> coll = new ConcurrentQueue<int>();
		Task t1 = Task.Factory.StartNew(() =>
		{
			for (int i = 0; i < 100; i++)
			{
				coll.Enqueue(i);
			}
		});

		Task t2 = Task.Factory.StartNew(() =>
		{
			foreach (var item in coll)
			{
				Console.WriteLine(item);
			}
		});
		Task.WaitAll(t1, t2);

	}
}