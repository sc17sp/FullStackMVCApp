using System;
using System.Data.Entity;
using FullStackMVCAPP.Models;

namespace FullStackMVCAPP.DataContext
{
public class GOTContext : DbContext 
{
    
    public virtual DbSet<House> Houses { get; set; }
    public virtual DbSet<Models.Castle> Castles { get; set; }
    public virtual DbSet<Character> Characters { get; set; }
    
}
}
