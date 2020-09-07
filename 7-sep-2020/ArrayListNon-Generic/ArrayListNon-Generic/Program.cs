using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListNon_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList() { 1,"a",11.23};
            arraylist.Add(1);
            arraylist.Add("sajbscdjc");
            arraylist.Insert(0, 111);
            //Console.WriteLine(arraylist.Capacity);
           /*foreach(var items in arraylist)
            {
                Console.WriteLine(items + " ,");
            }*/
           for (int i=0;i<arraylist.Count;i++)
            {
                Console.WriteLine(arraylist[i]+",");
            }
        }
    }
}
