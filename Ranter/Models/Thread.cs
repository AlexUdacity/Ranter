using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ranter.Models
{
    public class Thread
    {

        [Required]
        public virtual List<Post> Posts { get; set; }


    }
}