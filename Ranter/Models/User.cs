using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ranter.Models
{
    public class User : IdentityUser
    {

        public virtual List<Post> Posts { get; set; }

    }
}