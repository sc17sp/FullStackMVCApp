using FullStackMVCAPP.DataContext;
using FullStackMVCAPP.DataContext.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FullStackMVCAPP.Models;

namespace FullStackMVCAPP.Services
{
    public class HouseService
    {
        protected readonly GOTContext _GOTContext;
        protected readonly HouseRepository _HouseRepository;

        public HouseService()
        {
            _GOTContext = new GOTContext();
            _HouseRepository = new HouseRepository();
        }

        public IEnumerable<House> GetHouses()
        {
            return _HouseRepository.EntityList(_GOTContext);
        }
    }
}