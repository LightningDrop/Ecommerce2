using Ecommerce2.Web.Interface;
using Ecommerce2.Web.Models.DTOs;

namespace Ecommerce2.Web.Service
{
    public class AccountService : IAccountService
    {
        private readonly IDictionary<int, AccountDTO> _accounts = new Dictionary<int, AccountDTO>();


        // Will replace ctor whenever API and BE is implemented 
        public AccountService()
        {
            // This is rough implementation and will be replaced when API is developed 
            //foreach (var account in accounts) _accounts.Add(account.Id, account);
            this.InitializeDummyVariables();
        }

        // Grabs all accounts 
        public Task<List<AccountDTO>> GetAllAccounts()
        {
            var valuesList = _accounts.Values.ToList();
            return Task.FromResult(valuesList);
        }

        // Grabs the Account from the Dictionary  
        public Task<AccountDTO> GetAccountByListingID(int Id)
        {
            if (Id == null) throw new ArgumentNullException();
            _accounts.TryGetValue(Id, out AccountDTO account);
            return Task.FromResult(account);
        }


        // This function can be removed later and is used to initialize inMem data 
        public void InitializeDummyVariables()
        {

            // Make a better implementation later 
            int id = 0;
            List<AccountDTO> accounts = new List<AccountDTO>();
            accounts.Add(new AccountDTO(id, "bbrown", "Barry", "Brown", "bbrown@csus", new DateTime(1980, 1, 1)));
            accounts.Add(new AccountDTO(id + 1, "spiderman", "Peter", "Parker", "pparker@marvel", new DateTime(1990, 5, 3)));
            accounts.Add(new AccountDTO(id + 2, "sdawg", "Snup", "Dawg", "sdawg@sonOfGoodGood", new DateTime(1998, 4, 20)));

            foreach (var account in accounts) _accounts.Add(account.Id, account);


            // Idk why this doesn't work
            //List<AccountDTO> accounts =
            //{
            //    new AccountDTO
            //    {
            //        UserName = "bbrown",
            //        FirstName = "Barry",
            //        LastName = "Brown",
            //        Email = "bbrown@csus",
            //        new DateTime(1980,1,1)
            //    }
            //};

        }

    }
}

