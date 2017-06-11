using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Airvibes2.Models
{
    public class Records
    {
        
        public int Id { get; set; }
        [ForeignKey("Artists")]
        public int Artists_Id { get; set; }
        public virtual Artists Artists { get; set; }

        public string Cover { get; set; }

        public string Title { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy", ApplyFormatInEditMode = true)]
        [Display(Name = "Date de naissance")]
        public Nullable<System.DateTime> ReleaseDate { get; set; }
        public string Genre { get; set; }
        
        public List<Songs> SongsFrom { get; set; }

    }
}