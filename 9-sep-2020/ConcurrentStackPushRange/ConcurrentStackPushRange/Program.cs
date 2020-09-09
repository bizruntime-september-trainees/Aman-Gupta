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
		int[] ints = { 1, 2, 3 };

		ConcurrentStack<int> stack = new ConcurrentStack<int>();
		stack.PushRange(ints);
		int count = stack.Count;
		Console.WriteLine(count);

	}
}