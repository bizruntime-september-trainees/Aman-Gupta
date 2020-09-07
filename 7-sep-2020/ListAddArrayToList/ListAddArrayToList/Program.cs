using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAddArrayToList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[3] { "Mumbai", "London", "New York" };

            List<string> popularCities = new List<string>();

            // adding an array in a List
            popularCities.AddRange(cities);

            foreach(var city in popularCities)
            {
                Console.WriteLine(city+", ");
            }
        }
    }
}
