using FullStackMVCAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackMVCAPP.Services.Interfaces
{
    interface ICastleService
    {
        //Conflic between Castle.core package used by Moq and Castle Model, so directly importing resolves conflict.
        IEnumerable<Models.Castle> GetCastles();
    }
}
