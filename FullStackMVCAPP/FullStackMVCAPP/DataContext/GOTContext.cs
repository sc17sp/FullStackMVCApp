using System;
using System.Data.Emtity;

namespace FullStackMVCAPP.DataContext
{
public class GOTContext : DbContext 
{
	public GOTContext(DbContextOptions <GOTContext> options): base(options){}

    public DbSet<FullStackMVCAPP.Models.House> Houses { get; set; }
    public DbSet<FullStackMVCAPP.Models.Castle> Castles { get; set; }
    public DbSet<FullStackMVCAPP.Models.Character> Characters { get; set; }
    
}
}
