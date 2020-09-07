using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListNon_GenericRemove
{
    public class Program
    {
        public static void Main()
        {
            ArrayList arList = new ArrayList()
                {
                    1,
                    null,
                    "Bill",
                    300,
                    " ",
                    4.5f,
                    300
                };

            arList.Remove(null); //Removes first occurance of null
            arList.RemoveAt(4); //Removes element at index 4
            arList.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
            Console.WriteLine(arList.Contains(300));

            foreach (var item in arList)
                Console.WriteLine(item);
        }
    }
}
