using FullStackMVCAPP.DataContext;
using FullStackMVCAPP.DataContext.Repositories;
using System;
using System.Collections.Generic;
using System.Web;
using FullStackMVCAPP.Services.Interfaces;

namespace FullStackMVCAPP.Services
{
    public class CastleService : ICastleService
    {
        protected readonly GOTContext _GOTContext;
        protected readonly CastleRepository _CastleRepository;

        public CastleService()
        {
            _GOTContext = new DataContext.GOTContext();
            _CastleRepository = new CastleRepository();
        }

        public CastleService(GOTContext gOTContext)
        {
            _GOTContext = gOTContext;
            _CastleRepository = new CastleRepository();
        }
        //Conflic between Castle.core package used by Moq and Castle Model, so directly importing resolves conflict.
        public IEnumerable<Models.Castle> GetCastles()
        {
            return _CastleRepository.EntityList(_GOTContext);
        }
    }
}