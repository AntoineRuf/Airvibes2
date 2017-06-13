using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Airvibes2.Models
{
    public class SearchModel
    {
        public virtual ICollection<Songs> Songs { get; set; }
        public virtual ICollection<Records> Records { get; set; }
        public virtual ICollection<Artists> Artists { get; set; }
    }
}