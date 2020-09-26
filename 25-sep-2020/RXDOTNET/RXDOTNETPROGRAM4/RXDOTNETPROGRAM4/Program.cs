using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RXDOTNETPROGRAM4
{
    class Program
    {
        static void Main(string[] args)
        {
            //     Returns an observable sequence that terminates with an exception.
            var source1 = Observable.Throw<int>(new Exception("An error has occurred."));
            var source2 = Observable.Range(4, 3);
            //operator will move on to source2 even if source1 cannot be completed due to an error
            //main concept is it will concat both observable even if first one have error
            source1.OnErrorResumeNext(source2)
                   .Subscribe(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
