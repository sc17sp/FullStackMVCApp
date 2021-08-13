using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FullStackMVCAPP.Models
{
    public class Houses
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Region { get; set; }
        public string Words { get; set; }
        [Required]
        public virtual Castles castleId { get; set; }
    }
}