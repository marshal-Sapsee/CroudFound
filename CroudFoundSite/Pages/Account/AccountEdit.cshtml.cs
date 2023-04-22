using CroudFound.Models;
using CroudFound.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CroudFoundSite.Pages.Account
{
    public class AccountEditModel : PageModel
    {
        private readonly IAcoountRepository _acoountRepository;

        public AccountEditModel(IAcoountRepository acoountRepository)
        {
            _acoountRepository = acoountRepository;
        }

        public AccountData accountData { get; set; }

        public IActionResult OnGet(int id)
        {
            accountData = _acoountRepository.GetAccount(id);

            if (accountData == null)
            {
                return RedirectToPage("/NotFound");
            }

            return Page();
        }
    }
}
