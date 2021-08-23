using FullStackMVCAPP.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FullStackMVCAPP.Models;

namespace FullStackMVCAPP.DataContext.Repositories
{
    public class HouseRepository : IEntityRepository <House>
    {
        public IList<House> EntityList(GOTContext _GOTContext)
        {
            return _GOTContext.Houses.ToList();
        }

        public House GetEntityByID(GOTContext _GOTContext, int id)
        {
            return _GOTContext.Houses.Where(chr => chr.Id == id).First();
        }
    }
}