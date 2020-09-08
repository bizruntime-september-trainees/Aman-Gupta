using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockingCollectionCompleteAdding
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<int> bCollection = new BlockingCollection<int>(boundedCapacity: 10);

            Task producerThread = Task.Factory.StartNew(() =>
            {
                int i;
                for ( i = 0; i < 10; ++i)
                {
                    bCollection.Add(i);
                 
                }
                
               

                bCollection.CompleteAdding();
            });
            Task consumerThread = Task.Factory.StartNew(() =>
            {
                while (!bCollection.IsCompleted)
                {
                    int item = bCollection.Take();
                    Console.WriteLine(item);
                }
            });
            Task.WaitAll(consumerThread);
            //Console.WriteLine("--------------------------------------");
             /*foreach (int result in bCollection)
            {
               
                Console.WriteLine(result);
            }*/


        }
    }
}
