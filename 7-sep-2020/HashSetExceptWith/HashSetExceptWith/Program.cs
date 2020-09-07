using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetExceptWith
{
    class ProgramExceptWith
    {

        
        public static void Main()
        {

           
            HashSet<string> mySet1 = new HashSet<string>();
 
            mySet1.Add("Punjab");
            mySet1.Add("Haryana");
            mySet1.Add("Jammu");
            mySet1.Add("Himachal");
            mySet1.Add("Delhi");
 
            Console.WriteLine("The elements in mySet1 are : ");

            foreach (string i in mySet1)
            {
                Console.WriteLine(i);
            } 
            HashSet<string> mySet2 = new HashSet<string>();

           
            mySet2.Add("Bangalore");
            mySet2.Add("Kerala");
            mySet2.Add("Uttar Pradesh");
            mySet2.Add("Himachal");
            mySet2.Add("Delhi");
 
            Console.WriteLine("The elements in mySet2 are : ");

            foreach (string i in mySet2)
            {
                Console.WriteLine(i);
            }
 
            mySet2.ExceptWith(mySet1);
 

            Console.WriteLine("The elements in mySet2 are : ");

            foreach (string i in mySet2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
