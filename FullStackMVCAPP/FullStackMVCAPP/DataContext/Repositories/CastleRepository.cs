using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullStackMVCAPP.DataContext.Repositories
{
    public class CastleRepository
    {
        public IList<FullStackMVCAPP.Models.Castle> EntityList(GOTContext _GOTContext)
        {
            return _GOTContext.Castles.ToList();
        }

        public FullStackMVCAPP.Models.Castle GetEntityByID(GOTContext _GOTContext, int id)
        {
            return _GOTContext.Castles.Where(chr => chr.Id == id).First();
        }
    }
}