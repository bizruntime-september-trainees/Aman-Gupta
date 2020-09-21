using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WEBAPIPROJECT1.Models;

namespace WEBAPIPROJECT1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentsController : ControllerBase
    {
       

        [HttpGet]
        public IEnumerable<Departments> Get()
        {
           using(var context= new WEBAPIDATABASEPROJECT1Context())
            {
                //create a Db conext object 
                //then used dataset to return all the Departments 


                //return all department
                //return context.Departments.ToList();

                //Add a department
                //it is a model
                //Departments departments = new Departments();
                //departments.DepartmentId = 4;
                //departments.DepartmentName = "Dba";
                //departments.LocationId = 101;

                //add model to dataset
                //context.Departments.Add(departments);

                //update department location id
                //Departments departments = context.Departments.Where(dept => dept.DepartmentName == "Dba").FirstOrDefault();
                //departments.DepartmentId = 105;
                

                //delete 
                Departments departments = context.Departments.Where(dept => dept.DepartmentName == "Dba").FirstOrDefault();
                context.Departments.Remove(departments);
                context.SaveChanges();//insert the values in the database
                //return department based on id
                return context.Departments.Where(dept => dept.DepartmentId == 4).ToList();
            }
        }
    }
}
