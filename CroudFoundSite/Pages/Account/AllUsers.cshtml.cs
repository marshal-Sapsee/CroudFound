using CroudFound.Models;
using CroudFound.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CroudFoundSite.Pages.Account
{
    public class AllUsersModel : PageModel
    {
        private readonly IAcoountRepository _db;
        public AllUsersModel(IAcoountRepository db)
        {
            _db = db;
        }

        public IEnumerable<AccountData> AccountData { get; set; }

        public void OnGet()
        {
            AccountData = _db.GetAllAccountData();
        }
    }
}
