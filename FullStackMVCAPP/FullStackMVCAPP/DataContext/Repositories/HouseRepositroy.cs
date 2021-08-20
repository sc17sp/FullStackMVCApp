using FullStackMVCAPP.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullStackMVCAPP.DataContext.Repositories
{
    public class HouseRepositroy : IEntityRepository <FullStackMVCAPP.Models.House>
    {
        public IList<FullStackMVCAPP.Models.House> EntityList(GOTContext _GOTContext)
        {
            return _GOTContext.Houses.ToList();
        }

        public FullStackMVCAPP.Models.House GetEntityByID(GOTContext _GOTContext, int id)
        {
            return _GOTContext.Houses.Where(chr => chr.Id == id).First();
        }
    }
}