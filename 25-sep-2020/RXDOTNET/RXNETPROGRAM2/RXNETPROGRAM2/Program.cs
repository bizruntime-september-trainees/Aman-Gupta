using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RXNETPROGRAM2
{
    class Program
    {
        static void Main(string[] args)
        {
            var source1 = Observable.Range(1, 3);
            var source2 = Observable.Range(1, 3);
            //two sequences are active at the same time and values are pushed out as they occcured in source
            //The resultant sequence only completes when the last source sequence has finished pushing values.
            // all the source observable sequences need to be of the same type of IObservable<T>
            //resultant sequence will be of the type IObservable<T>

           source1.Merge(source2)
                   .Subscribe(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
