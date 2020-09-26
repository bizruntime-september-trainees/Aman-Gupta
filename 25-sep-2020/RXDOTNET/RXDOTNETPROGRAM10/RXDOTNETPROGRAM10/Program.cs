using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RXDOTNETPROGRAM10
{
    class Program
    {
        static void Main(string[] args)
        {
            //     Represents an object that is both an observable sequence as well as an observer.
            //     Each notification is broadcasted to all subscribed observers
            //subjects do not perform any synchronization across threads
            //the advantage of reducing overhead and improving performance
            Subject<int> subject = new Subject<int>();
            var subscription = subject.Subscribe(
                                     x => Console.WriteLine("Value published: {0}", x),
                                     () => Console.WriteLine("Sequence Completed."));
            subject.OnNext(1);

            subject.OnNext(2);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            subject.OnCompleted();
            subscription.Dispose();
        }
    }
}
