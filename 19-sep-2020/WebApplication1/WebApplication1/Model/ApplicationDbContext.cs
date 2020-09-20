using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class ApplicationDbContext :DbContext //class from EntityFrameworkCore
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)//need this parameter for dependency injection
        {

        }
        public DbSet<Book> Book //To add any model to database
        {
            get;
            set;
        }
    }
}
