using Ecommcerce2.Core.Models.FEModels;

namespace Ecommcerce2.Core.Interfaces
{
    public interface ICartData
    {
        Task<IEnumerable<Cart>> GetAll();
        Task<Cart> Get(int id);

        //Task Delete(int id);
    }
}
