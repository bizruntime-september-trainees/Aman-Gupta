using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using System.Net;
using System.Configuration;

[assembly: log4net.Config.XmlConfigurator(Watch=true)]

namespace LoggerConfigration
{
     class Program
    {
        private static readonly log4net.ILog log = LogHelper.GetLog();//log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            Console.WriteLine("hi i ama aman");
            log.Error("this is a error message");

            Console.ReadLine();
        }
    }
}
