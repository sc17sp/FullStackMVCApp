using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FullStackMVCAPP.Models;

namespace FullStackMVCAPP.DataContext.Repositories
{
    public class CastleRepository
    {
        public IList<Castle> EntityList(GOTContext _GOTContext)
        {
            return _GOTContext.Castles.ToList();
        }

        public Castle GetEntityByID(GOTContext _GOTContext, int id)
        {
            return _GOTContext.Castles.Where(chr => chr.Id == id).First();
        }
    }
}