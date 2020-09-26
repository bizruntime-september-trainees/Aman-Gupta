using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RXDOTNETPROGRAM11
{
    class Program
    {
        static void Main(string[] args)
        {
            //first create a source sequence which produces an integer every 1 second
            //then create a Subject
            //pass it as an observer to the source so that it will receive all the values pushed out by this source sequence
            //we create another two subscriptions, this time with the subject as the source
            var source = Observable.Interval(TimeSpan.FromSeconds(1));
            Subject<long> subject = new Subject<long>();
            var subSource = source.Subscribe(subject);
            var subSubject1 = subject.Subscribe(
                                     x => Console.WriteLine("Value published to observer #1: {0}", x),
                                     () => Console.WriteLine("Sequence Completed."));
            var subSubject2 = subject.Subscribe(
                                     x => Console.WriteLine("Value published to observer #2: {0}", x),
                                     () => Console.WriteLine("Sequence Completed."));
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            subject.OnCompleted();
            subSubject1.Dispose();
            subSubject2.Dispose();
        }
    }
}
