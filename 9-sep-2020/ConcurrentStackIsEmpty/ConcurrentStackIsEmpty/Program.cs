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
		bool isEmpty = stack.IsEmpty;//returns True
		Console.WriteLine(isEmpty);
		stack.Push(1);
		isEmpty = stack.IsEmpty; //returns False
		Console.WriteLine(isEmpty);

	}
}
