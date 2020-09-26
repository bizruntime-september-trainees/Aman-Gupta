using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RXDOTNETPROGRAM8
{
    class Program
    {
        static void Main(string[] args)
        {

            //     Generates an observable sequence by running a state-driven loop producing the sequence's elements.
           
            IObservable<int> seq = Observable.Generate(0, i => i < 10, i => i + 1, i => i * i);
            // it takes an initial state
            //a conditional function to terminate
            //an iterator
            //a result selector (a square function of the current value)
            IObservable<int> source = from n in seq
                                      where n < 36
                                      select n;
            source.Subscribe(x => { Console.WriteLine(x); });   
            Console.ReadKey();
        }
    }
}
