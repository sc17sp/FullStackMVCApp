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
        public IEnumerable<House> EntityList(GOTContext _GOTContext)
        {
            var castles = _GOTContext.Castles.ToList();
            return _GOTContext.Houses.ToList();
        }

        public House GetEntityByID(GOTContext _GOTContext, int id)
        {   
            return _GOTContext.Houses.Single(chr => chr.Id == id);
        }
    }
}