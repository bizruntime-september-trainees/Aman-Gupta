using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RXNETPROGRAM1
{
    class Program
    {
        static void Main(string[] args)
        {
            var source1 = Observable.Range(1, 3);//first Observable sequence 
            var source2 = Observable.Range(1, 3);//second Observable sequence
            //concat both Observable sequence and 
            //the Concat operator to combine two sequences into a single sequence and subscribe to it
            //Subscribes an element handler to an observable sequence.                                     

            source1.Concat(source2)
                   .Subscribe(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
