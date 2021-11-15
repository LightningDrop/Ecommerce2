using Ecommcerce2.Core.Models.FEModels;

namespace Ecommcerce2.Core.Interfaces
{
    public interface IItemData
    {
        Task<IEnumerable<Item>> GetAll();
        Task<Item> Get(int id);

        //Task Delete(int id);

    }
}
