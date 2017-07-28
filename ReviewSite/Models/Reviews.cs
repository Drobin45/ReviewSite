using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewSite.Models
{
    public class Reviews
    {
        [Key]
        public int ReviewID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [Display(Name ="Publish Date")]
        public DateTime PublishDate { get; set; }

        [ForeignKey ("Categories")]
        public int CategoryID { get; set; }
        public virtual Categories Categories { get; set; }


    }
}