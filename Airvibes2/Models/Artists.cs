using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Airvibes2.Models
{
    public class Artists
    {
        
        public int Id { get; set; }
        public string Photo { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        
        public List<Records> Records { get; set; }
    }
}
