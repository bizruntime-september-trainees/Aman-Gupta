using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RXDOTNETPROGRAM9
{
    class Program
    {
        static void Main(string[] args)
        {
            var seq = Observable.Interval(TimeSpan.FromSeconds(1));
            //     Projects each element of an observable sequence into consecutive non-overlapping buffers which are produced based on element count information
            var bufSeq = seq.Buffer(6);
            bufSeq.Subscribe(values => Console.WriteLine(values.Sum()));
            Console.ReadKey();
        }
    }
}
