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
		coll.Enqueue(1);
		coll.Enqueue(2);
		coll.Enqueue(3);
		coll.Enqueue(4);
		int item;
		bool isSuccessful = coll.TryDequeue(out item);
		Console.WriteLine(isSuccessful);
		Console.WriteLine(item);
		isSuccessful = coll.TryDequeue(out item);
		Console.WriteLine(isSuccessful);
		Console.WriteLine(item);
	}
}