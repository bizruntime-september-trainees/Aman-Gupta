using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoggerProgram1
{
   public abstract class LogBase
    {
        public abstract void log(string message);
    }
    public class Logger : LogBase
    {
        private string CurrentDirectory
        { 
            get;
            set; 
        }
        private string FileName
        {
            get;
            set;
        }
        private string FilePath
        {
            get;
            set;
        }
        public Logger()
        {
            this.CurrentDirectory = @"C:\Users\amang\source\repos\LoggerProgram1";
            this.FileName = "log.txt";
            this.FilePath = this.CurrentDirectory + "/" + this.FileName;

        }
        public override void log(string message)
        {
            //throw new NotImplementedException();
            StreamWriter w = System.IO.File.AppendText(this.FilePath);
            {
                w.WriteLine("log entry");
                w.WriteLine("date: " + DateTime.Now.ToShortDateString() + " Time: " + DateTime.Now.ToShortTimeString());
                w.WriteLine(message);
                w.WriteLine("----------------------------------");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.log("aman");
            logger.log("gupta");

            //Console.WriteLine("hello World");
        }
    }
}
