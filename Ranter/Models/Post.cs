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

        [Required]
        [StringLength(100)]
        public string PostName { get; set; }

        [Required]
        public DateTime PostTime { get; set; }

        [Required]
        public DateTime UpdateTime { get; set; }

    }
}