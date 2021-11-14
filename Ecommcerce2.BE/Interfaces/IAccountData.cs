using Ecommcerce2.Core.Models;

namespace Ecommcerce2.Core.Interfaces
{
    public interface IAccountData
    {
        Task<IEnumerable<Account>> GetAll();
        Task<Account> Get(int id);
        //Task Delete(int id);
    }
}
