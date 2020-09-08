using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockingCollectionAddMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<int> bCollection = new BlockingCollection<int>(boundedCapacity: 2);
            bCollection.Add(1);
            bCollection.Add(2);

            if (bCollection.TryAdd(3, TimeSpan.FromSeconds(1)))
            {
                Console.WriteLine("Item added");
            }
            else
            {
                Console.WriteLine("Item does not added");
            }
        }
    }
}
