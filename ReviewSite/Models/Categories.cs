using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewSite.Models
{
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }

        [Display(Name ="Category")]
        public string CategoryName { get; set; }

        public virtual ICollection<Reviews> Reviews { get; set; }

    }
}