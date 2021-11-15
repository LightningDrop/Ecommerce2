using Ecommcerce2.Core.Interfaces;
using Ecommcerce2.Core.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ecommerce2.Web.Razor.Pages.Accounts
{
    public class ListModel : PageModel
    {
        private readonly IAccountData _accountData;
        public IEnumerable<Account> Accounts { get; set; }

        public ListModel(IAccountData accountData)
        {
            _accountData = accountData;
        }

        public async void OnGet()
        {
            Accounts = await _accountData.GetAll();

        }
    }
}
