using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FullStackMVCAPP.Models
{
    public class GOTContext : DbContext
    { 
        public DbSet<House> Houses { get; set; }
        public DbSet<Castle> Castles { get; set; }
    }
    public class House
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Region { get; set; }
        public string Words { get; set; }
        [Required]
        public Castle CastleId { get; set; }
    }
}