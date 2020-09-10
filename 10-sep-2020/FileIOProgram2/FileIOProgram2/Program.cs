using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOProgram2
{
    class Program
    {
        static void writeFile(string Filename)
        {
            File.WriteAllText(Filename, "Hello World");
        }
        static void readFile(String Filename)
        {
            Console.WriteLine(File.ReadAllText(Filename));
        }

        static void Main(string[] args)
        {
            String Filename = @"F:\abc";
            writeFile(Filename);
        }
    }
}
