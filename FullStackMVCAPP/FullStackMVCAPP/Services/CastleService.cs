using FullStackMVCAPP.DataContext;
using FullStackMVCAPP.DataContext.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FullStackMVCAPP.Models;

namespace FullStackMVCAPP.Services
{
    public class CastleService
    {
        protected readonly GOTContext _GOTContext;
        protected readonly CastleRepository _CastleRepository;

        public CastleService()
        {
            _GOTContext = new DataContext.GOTContext();
            _CastleRepository = new CastleRepository();
        }

        public IEnumerable<Castle> GetCastles()
        {
            return _CastleRepository.EntityList(_GOTContext);
        }
    }
}