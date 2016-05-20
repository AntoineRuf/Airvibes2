using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Airvibes2.Models
{
    public class RComment
    {
        public int Id { get; set; }
        public int Id_User { get; set; }
        public int Id_Record { get; set; }
        public string Body { get; set; }
        public System.DateTime PostedAt { get; set; }

        public virtual Records Records { get; set; }
    }
}