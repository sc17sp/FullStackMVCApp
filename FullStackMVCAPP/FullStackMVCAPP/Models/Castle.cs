using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FullStackMVCAPP.Models
{
    public class castleContext : DbContext
    { 
        public DbSet<Castle> Castles { get; set; }    
    }
    public class Castle
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}