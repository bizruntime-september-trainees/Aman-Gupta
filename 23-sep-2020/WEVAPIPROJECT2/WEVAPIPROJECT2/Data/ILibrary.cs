using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEVAPIPROJECT2.Models;

namespace WEVAPIPROJECT2.Data
{
    public interface ILibrary
    {
       IEnumerable<ComputerScience> GetComputerSciences();
        ComputerScience GetBookByID(int id);
    }
}
