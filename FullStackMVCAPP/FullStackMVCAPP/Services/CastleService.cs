using FullStackMVCAPP.DataContext;
using FullStackMVCAPP.DataContext.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullStackMVCAPP.Services
{
    public class CastleService
    {
        protected readonly GOTContext _GOTContext;
        protected readonly CastleRepository _CastleRepository;

        public CastleService(GOTContext gOTContext, CastleRepository castleRepository)
        {
            _GOTContext = gOTContext;
            _CastleRepository = castleRepository;
        }

        public IList<FullStackMVCAPP.Models.Castle> GetCastles()
        {
            return _CastleRepository.EntityList(_GOTContext);
        }
    }
}