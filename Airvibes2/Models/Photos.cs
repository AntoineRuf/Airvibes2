using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Airvibes2.Models
{
    public class Photos
    {
        public Photos()
        {
            this.Artists = new HashSet<Artists>();
        }
        public int Id { get; set; }
        public byte[] Image { get; set; }

        public virtual ICollection<Artists> Artists { get; set; }
    }
}