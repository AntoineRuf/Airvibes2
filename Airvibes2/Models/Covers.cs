using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Airvibes2.Models
{
    public class Covers
    {
        public Covers()
        {
            this.Records = new HashSet<Records>();
        }
        public int Id { get; set; }
        public byte[] Image { get; set; }

        public virtual ICollection<Records> Records { get; set; }
    }
}