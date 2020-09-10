using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Programme2
{
    public static void Main(string[] args)
    {
        string[] delhiResidents = { "Ramesh", "Kapil", "Vikas", "Amit" };
        string[] kolkataResidents = { "Kapil", "Manmohan", "Deepak", "Amit" };

        var allResidents = delhiResidents.Intersect(kolkataResidents);
        foreach (var item in allResidents)
        {
            Console.WriteLine(item);
        }
    }
}