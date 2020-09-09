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
		ConcurrentStack<int> stack = new ConcurrentStack<int>();
		stack.Push(1);
		stack.Push(2);
		stack.Push(3);
		stack.Push(4);
		int[] array = stack.ToArray();
		foreach (int item in array)
		{
			Console.WriteLine(item);
		}
	}
}
