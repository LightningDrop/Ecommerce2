using Ecommcerce2.Core.Models.FEModels;

namespace Ecommcerce2.Core.Interfaces
{
    public interface ITransactionData
    {
        Task<IEnumerable<Transaction>> GetAll();
        Task<Transaction> Get(int id);

        //Task Delete(int id);

    }
}
