using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DandJchatter.Models
{
    public class Post
    {
        [Key]
        public int PostID { get; set; }
        public string Chat { get; set; }
        public DateTime TimeOfChat { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set;}
        //[ForeignKey("AspNetUsers")]
        //public string ID { get; set; }
        //public string UserName { get; set; }
    }
}