using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEVAPIPROJECT2.Data;
using WEVAPIPROJECT2.Models;

namespace WEVAPIPROJECT2.Controllers
{
    //Route on a controller
    //api/ComputerScience
    [Route("api/ComputerScience")]
    [ApiController]
    public class ComputerScienceController : ControllerBase
    {
        private readonly LibraryImplements _libraryImplements = new LibraryImplements();
        //get api/ComputerScience
        [HttpGet]
        public ActionResult<IEnumerable<ComputerScience>> GetComputerSciences()
        {
            var ComputerScienceItems = _libraryImplements.GetComputerSciences();
            return Ok(ComputerScienceItems);
        }
        //Get api/ComputerScience/2
        [HttpGet("{id}")]
        public ActionResult <ComputerScience> GetComputerSciences(int id)
        {
            var ComputerScienceItem1 = _libraryImplements.GetBookByID(id);
            return Ok(ComputerScienceItem1);
        }


    }
}
