using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Airvibes2.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }

        [ForeignKey("Songs")]
        public int SongsId { get; set; }
        public virtual Songs Songs { get; set; }

        public string MemberId { get; set; }
    }
}