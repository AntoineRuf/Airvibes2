using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Airvibes2.Models
{
    public class SComment
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public string Users_Id { get; set; }
        [ForeignKey("Songs")]
        public int Songs_Id { get; set; }

        public string Body { get; set; }
        public System.DateTime PostedAt { get; set; }

        public virtual Songs Songs { get; set; }
        public virtual ApplicationUser User {get;set;}
    }
}