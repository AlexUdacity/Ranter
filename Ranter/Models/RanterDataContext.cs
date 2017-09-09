using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ranter.Models
{
    public class RanterDataContext : DbContext
    {

        public DbSet<Post> Posts { get; set; }

    }
}