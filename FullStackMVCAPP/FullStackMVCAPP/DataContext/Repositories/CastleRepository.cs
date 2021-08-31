using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullStackMVCAPP.DataContext.Repositories
{
    public class CastleRepository
    {
        public IEnumerable<Models.Castle> EntityList(GOTContext _GOTContext)
        {
            return _GOTContext.Castles.ToList();
        }

        public Models.Castle GetEntityByID(GOTContext _GOTContext, int id)
        {
            return _GOTContext.Castles.Where(chr => chr.Id == id).First();
        }
    }
}