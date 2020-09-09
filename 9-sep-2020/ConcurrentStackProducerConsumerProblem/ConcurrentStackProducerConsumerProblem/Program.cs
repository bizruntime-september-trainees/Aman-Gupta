using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Threading;
public class Program
{
	static ConcurrentStack<int> stack = new ConcurrentStack<int>();
	static int maxItems = 10;
	static AutoResetEvent autoEvent1 = new AutoResetEvent(false);
	static AutoResetEvent autoEvent2 = new AutoResetEvent(false);

	public static void Main(string[] args)
	{
		Task t1 = Task.Factory.StartNew(() =>
		{
			for (int i = 0; i < maxItems; i++)
			{
				stack.Push(i);
				autoEvent1.Set();
				autoEvent2.WaitOne();
			}
		});

		Task t2 = Task.Factory.StartNew(() =>
		{
			int item;

			for (int i = 0; i < maxItems; i++)
			{
				autoEvent1.WaitOne();
				if (stack.TryPop(out item))
				{
					Console.WriteLine(item);
				}
				autoEvent2.Set();
			}
		});

		Task.WaitAll(t1, t2);
		autoEvent1.Close();
		autoEvent2.Close();
	}
}