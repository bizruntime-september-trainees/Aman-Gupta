using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class Book
    {
        [Key]
        public int Id//automatically increment ID
        {
            get;
            set;
        }
        [Required]
        public string Name//name can't be null
        {
            get;
            set;
        }
        public string Author
        {
            get;
            set;
        }

    }
}
