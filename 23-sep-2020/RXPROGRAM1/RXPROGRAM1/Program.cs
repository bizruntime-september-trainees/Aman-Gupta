using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RXPROGRAM1
{
    class Program
    {
        static void Main(string[] args)
        {
            var observable = Observable.Range(1, 10);
            IObserver<int> observer = Observer.Create<int>(
               
                Console.WriteLine,
                (error) => { Console.WriteLine($"Error:{error.Message}"); },
                () => { Console.WriteLine("Observation Complete"); });
                
            var subcription = observable.Subscribe(observer);

            Console.ReadLine();
            subcription.Dispose();
        }
    }
}
