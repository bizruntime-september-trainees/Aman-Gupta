﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main(string[] args)
	{
		//Create an array 'a' type of int having the values 1 to 9  
		int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		Console.WriteLine("The Max value in the given array is:");
		/*Min() function is applied on the array 'a' to find the minimum number from the array*/
		var MethodSyntax = a.Select(x => x).Max();
		Console.WriteLine("The Max Number is: " + MethodSyntax);
	}
}
