using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RXNETPROGRAM3
{
    class Program
    {
        static void Main(string[] args)
        {
            var source1 = Observable.Range(1, 3);
            var source2 = Observable.Range(4, 3);
            // if source1 completes without any error, then source2 will not start.
            //it will ignore the second source
            source1.Catch(source2)
                   .Subscribe(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
