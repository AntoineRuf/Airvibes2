using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Airvibes2.Models
{
    public class Records
    {
        public Records()
        {
            this.RComment = new HashSet<RComment>();
            this.Songs = new HashSet<Songs>();
        }
        public int Id { get; set; }
        public int Id_Artist { get; set; }
        public Nullable<int> Id_Cover { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> ReleaseDate { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }

        public virtual Artists Artists { get; set; }
        public virtual Covers Covers { get; set; }
        public virtual ICollection<RComment> RComment { get; set; }
        public virtual ICollection<Songs> Songs { get; set; }

    }
}