using FullStackMVCAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackMVCAPP.Services.Interfaces
{
    interface IHouseService
    {
        IEnumerable<House> GetHouses();
    }
}
