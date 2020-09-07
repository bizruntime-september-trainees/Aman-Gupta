using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRemove
{
    class ListRemoveProgram
    {
        static public void Main()
        {
            List<int> my_list = new List<int>();

            my_list.Add(10);
            my_list.Add(10311312);
            my_list.Add(100331);
            my_list.Add(142411);
            my_list.Add(134141);
            my_list.Add(103435353);
            my_list.Add(12123343);
            my_list.Add(343141);
            my_list.Add(796687);

            Console.WriteLine("Initial count: "+ my_list.Count);
 
            my_list.Remove(10);
            Console.WriteLine("2nd count: "+ my_list.Count);
 
            my_list.RemoveAt(4);
            Console.WriteLine("3rd count: "+ my_list.Count);
            
            my_list.RemoveRange(0, 2);
            Console.WriteLine("4th count: "+ my_list.Count);
 
            my_list.Clear();
            Console.WriteLine("5th count: "+ my_list.Count);
        }
    }
}