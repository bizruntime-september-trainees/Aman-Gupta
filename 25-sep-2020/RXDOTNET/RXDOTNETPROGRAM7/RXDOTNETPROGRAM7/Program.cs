using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RXDOTNETPROGRAM7
{
    class Program
    {
        static void Main(string[] args)
        {
            var source1 = Observable.Interval(TimeSpan.FromSeconds(5)).Take(2);
            var proj = Observable.Range(100, 3);
            //     Projects each element of the source observable sequence to the other observable sequence 
            //     and merges the resulting observable sequences into one observable sequence
            var resultSeq = source1.SelectMany(proj);
            //     Subscribes an element handler, an exception handler, and a completion handler to an observable sequence.
            var sub = resultSeq.Subscribe(x => Console.WriteLine("OnNext : {0}", x.ToString()),
                                          ex => Console.WriteLine("Error : {0}", ex.ToString()),
                                          () => Console.WriteLine("Completed"));
            Console.ReadKey();
        }
    }
}
