using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ranter.Models.Repositories
{
    public class PostRepository : Repository<Post>
    {

        public List<Post> GetByName(String name)
        {
            return DbSet.Where(a => a.PostName.Contains(name)).ToList();
        }

    }
}