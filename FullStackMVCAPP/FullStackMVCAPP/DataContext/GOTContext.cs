using System;
using System.Data.Entity;

namespace FullStackMVCAPP.DataContext
{
public class GOTContext : DbContext 
{
    
    public DbSet<FullStackMVCAPP.Models.House> Houses { get; set; }
    public virtual DbSet<FullStackMVCAPP.Models.Castle> Castles { get; set; }
    public DbSet<FullStackMVCAPP.Models.Character> Characters { get; set; }
    
}
}
