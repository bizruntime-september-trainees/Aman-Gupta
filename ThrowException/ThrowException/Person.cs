using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowException
{
    class Person
    {
       public void doflip()
        {
            throw new Exception("he was not able to do a flip");
        }
       
    }
    class Program1
    {
        static void Main(String[] args)
        {
            Person obj = new Person();    
            try
            {
                obj.doflip();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

            }
        }
    }
}
