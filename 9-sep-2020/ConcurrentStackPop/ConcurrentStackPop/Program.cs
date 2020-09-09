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
		int item;
		bool isSuccess = stack.TryPop(out item); //isSuccess = True, item = 2
		Console.WriteLine(item);
		isSuccess = stack.TryPop(out item);//isSuccess = True, item = 1
		Console.WriteLine(item);

	}
}
