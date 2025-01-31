﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FullStackMVCAPP.Models
{
    public class House
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Region { get; set; }
        public string Words { get; set; }
        [Required]
        public Castle Castle { get; set; }
         
        public virtual ICollection<Character> Characters { get; set; }
    }
}