using System;


public interface ICharacterRepositry: IEntityRepository <FullStackMVCAPP.Models.Character>
{
    public IList<FullStackMVCAPP.Models.Character> GetCharacterByHouseId(int Id);
}
