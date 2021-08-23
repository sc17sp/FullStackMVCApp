using FullStackMVCAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackMVCAPP.Services.Interfaces
{
    interface ICharacterService
    {
        IEnumerable<Character> GetCharacters();

        Character GetCharacterById(int id);

        IEnumerable<Character> GetCharacterByHouseId(int id);
    }
}
