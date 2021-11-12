using Ecommerce2.Web.Models.DTOs;

namespace Ecommerce2.Web.Interface
{
    public interface IAccountService
    {
        public Task<AccountDTO> GetAccountByListingID(int Id);
        public Task<List<AccountDTO>> GetAllAccounts();

        // Temporary for now
        public void InitializeDummyVariables();

    }
}
