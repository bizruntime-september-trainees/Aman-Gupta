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
		List<int> ints = new List<int>();
		ints.Add(1);
		ints.Add(2);
		ints.Add(3);

		ConcurrentStack<int> stack = new ConcurrentStack<int>(ints);
		int count = stack.Count; //Returns 3
		foreach (var item in stack)
		{
			Console.WriteLine(item);
		}
		Console.WriteLine("count of stack element is: " + count);
	}
}