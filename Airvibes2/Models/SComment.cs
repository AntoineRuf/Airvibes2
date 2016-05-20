using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Airvibes2.Models
{
    public class SComment
    {
        public int Id { get; set; }
        public int Id_User { get; set; }
        public int Id_Song { get; set; }
        public string Body { get; set; }
        public System.DateTime PostedAt { get; set; }

        public virtual Songs Songs { get; set; }
    }
}