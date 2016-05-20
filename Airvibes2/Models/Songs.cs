using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Airvibes2.Models
{
    public class Songs
    {
        public Songs()
        {
            this.SComment = new HashSet<SComment>();
        }
        public int Id { get; set; }
        public int Id_Artist { get; set; }
        public int Id_Record { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public int TimesPlayed { get; set; }
        public int Rating { get; set; }
        public byte[] LowQFile { get; set; }
        public byte[] HiQFile { get; set; }

        public virtual Artists Artists { get; set; }
        public virtual Records Records { get; set; }
        public virtual ICollection<SComment> SComment { get; set; }
    }
}