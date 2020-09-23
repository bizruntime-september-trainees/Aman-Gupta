using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WEBAPIPROJECT1.Models;
using Microsoft.AspNetCore.Rewrite;

namespace WEBAPIPROJECT1.Controllers
{
    [ApiController] //     Indicates that a type and all derived types are used to serve HTTP API responses.
    //     Controllers decorated with this attribute are configured with features and behavior
    //     targeted at improving the developer experience for building APIs.
    //     When decorated on an assembly, all controllers in the assembly will be treated
    //     as controllers with API behavior.
    [Route("[controller]")]
    public class DepartmentsController : ControllerBase
    {
       

        [HttpGet]//identify an action that support the HTTP get method 
        public IEnumerable<Departments> Get()
        {
           using(var context= new WEBAPIDATABASEPROJECT1Context())
            {
                //create a Db conext object 
                //then used dataset to return all the Departments 


                //return all department
                return context.Departments.ToList();

                //Add a department
                //it is a model
                //Departments departments = new Departments();
                //departments.DepartmentId = 4;
                //departments.DepartmentName = "Dba";
                //departments.LocationId = 101;

                //add model to dataset
                //context.Departments.Add(departments);
               // Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<Departments> entityEntry = context.Departments.Add(departments);

                //update department location id
                //Departments departments = context.Departments.Where(dept => dept.DepartmentName == "Dba").FirstOrDefault();
                //departments.DepartmentId = 105;


                //delete 
                //Departments departments = context.Departments.Where(dept => dept.DepartmentName == "Dba").FirstOrDefault();
                //context.Departments.Remove(departments);
                //context.SaveChanges();//insert the values in the database
                ////return department based on id
               // return (IEnumerable<Departments>)context.Departments.Where(dept => dept.DepartmentId == 3).ToList();
            }
        }
    }
}
