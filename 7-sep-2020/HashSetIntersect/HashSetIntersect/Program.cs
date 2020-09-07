using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetIntersect
{
    class ProgramHashSetIntersect
    {
 
        public static void Main()
        { 
            HashSet<string> mySet1 = new HashSet<string>();

            HashSet<string> mySet2 = new HashSet<string>();

            
            mySet1.Add("Hello");
            mySet1.Add("hi");
            mySet1.Add("AmanGupta");
 
            mySet2.Add("hello");
            mySet2.Add("and");
            mySet2.Add("hi");
            mySet2.Add("are");
            mySet2.Add("the");
            mySet2.Add("best");
 
            HashSet<string> ans = new HashSet<string>(mySet1);

            ans.IntersectWith(mySet2);

       
            foreach (string i in ans)
            {
                Console.WriteLine(i);
            }
        }
    }

}
