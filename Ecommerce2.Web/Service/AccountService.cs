using Ecommerce2.Web.Interface;
using Ecommerce2.Web.Models.DTOs;

namespace Ecommerce2.Web.Service
{
    public class AccountService : IAccountService
    {
        private readonly IDictionary<Guid, (Guid Id, AccountDTO account)> _accounts = new Dictionary<Guid, (Guid Id, AccountDTO account)>();


        // Will replace ctor whenever API and BE is implemented 
        public AccountService(List<AccountDTO> accounts)
        {
            // This is rough implementation and will be replaced when API is developed 
            foreach (var account in accounts) _accounts.Add(account.Id, (account.Id, account));
        }

        // Grabs the Account from the Dictionary  
        public Task<AccountDTO> GetAccountByListingID(Guid Id)
        {
            _accounts.TryGetValue(Id, out var value);
            return Task.FromResult(value.account);
        }

    }
}

