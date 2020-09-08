using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockingCollectionTakeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<int> bCollection = new BlockingCollection<int>(boundedCapacity: 3);
            bCollection.Add(1);
            bCollection.Add(2);

            int item = bCollection.Take();
            Console.WriteLine(item); //returns 1
            Console.WriteLine("--------------------------------");
           
            BlockingCollection<int> bCollectionlist2 = new BlockingCollection<int>(boundedCapacity: 2);
            bCollectionlist2.Add(1);
            bCollectionlist2.Add(2);

            int itemlist2 = bCollectionlist2.Take();
            itemlist2 = bCollectionlist2.Take();

            if (bCollectionlist2.TryTake(out item, TimeSpan.FromSeconds(1)))
            {
                Console.WriteLine(item);
            }
            else
            {
                Console.WriteLine("No item removed");
            }

        }
    }
}
