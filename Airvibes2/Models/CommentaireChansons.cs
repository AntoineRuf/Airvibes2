using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Airvibes2.Models
{
    public class CommentaireChansons
    {
        public Songs Songs { get; set; }
        public List<SComment> SComment { get; set; }
    }
}