using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetProgram
{
	
	class OddNumber
	{

		 
		public static void Main()
		{

			HashSet<int> odd = new HashSet<int>();
				
			for (int i = 0; i < 5; i++)
			{
				odd.Add(2 * i + 1);
				
			}

			foreach (int i in odd)
			{
				Console.WriteLine(i);
				
			}
			Console.WriteLine("the count of number added: "+odd.Count);
		}
	}

}
