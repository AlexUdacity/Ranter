using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ranter.Models
{
    public class Post
    {

        [Key]
        public int PostID { get; set; }
        public string PostName { get; set; }
        public DateTime PostTime { get; set; }

    }
}