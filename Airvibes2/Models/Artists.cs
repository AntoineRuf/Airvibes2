using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Airvibes2.Models
{
    public class Artists
    {
        public Artists()
        {
            this.Records = new HashSet<Records>();
            this.Songs = new HashSet<Songs>();
        }
        public int Id { get; set; }
        public Nullable<int> Id_Photo { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }

        public virtual Photos Photos { get; set; }
        public virtual ICollection<Records> Records { get; set; }
        public virtual ICollection<Songs> Songs { get; set; }
    }
}