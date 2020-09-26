using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RXDOTNETPROGRAM5
{
    class Program
    {
        static void Main(string[] args)
        {
            var seqNum = Observable.Range(1, 5);
            // Projects each element of an observable sequence into a new form
            var seqString = from n in seqNum
                            select new string('1', (int)n);
            seqString.Subscribe(str => { Console.WriteLine(str); });
            Console.ReadKey();
        }
    }
}
