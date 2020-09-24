using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEVAPIPROJECT2.Models;

namespace WEVAPIPROJECT2.Data
{
    public class LibraryImplements : ILibrary
    {
        public ComputerScience GetBookByID(int id)
        {
            return new ComputerScience { BookId = 1, BookName = "Adv.Java", BookISBN = 111, BookDep = "cs" };
        }

        public IEnumerable< ComputerScience> GetComputerSciences()
        {
            var ComputerScience = new List<ComputerScience>
            {
                new ComputerScience { BookId = 1, BookName = "Adv.Java", BookISBN = 111, BookDep = "cs" },
                new ComputerScience { BookId = 2, BookName = "Ec BOOK", BookISBN = 222, BookDep = "EC" },
                new ComputerScience { BookId = 3, BookName = "Mech Book", BookISBN = 333, BookDep = "Mechanical" }
                
            };
            return ComputerScience;
        }
    }
}
