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
		ConcurrentQueue<int> coll = new ConcurrentQueue<int>(ints);
		int count = coll.Count;
		Console.WriteLine(count);
	}
}