using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Airvibes2.Models
{
    public class Rating
    {

    }
    public class Songs
    {
        public int Id { get; set; }

        [ForeignKey("Artists")]
        public int Artists_Id { get; set; }
        public virtual Artists Artists { get; set; }

        [ForeignKey("Records")]
        public int Records_Id { get; set; }
        public virtual Records Records { get; set; }

        public string Title { get; set; }
        public int Duration { get; set; }
        public int TimesPlayed { get; set; }
        public string FilePath { get; set; }
        public Nullable<int> Mark { get; set; }
        public Nullable<int> NbrMarks { get; set; }
        public List<SComment> SComment { get; set; }
    }

}