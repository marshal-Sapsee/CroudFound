using CroudFound.Models;
using CroudFound.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CroudFoundSite.Pages.Account
{
    public class AccountDetailModel : PageModel
    {
        private readonly IAcoountRepository _acoountRepository;

        public AccountDetailModel(IAcoountRepository acoountRepository)
        {
            _acoountRepository = acoountRepository;
        }

        public AccountData Account { get; private set; }

        public IActionResult OnGet(int id)
        {
            Account = _acoountRepository.GetAccount(id);

            if (Account == null) return RedirectToPage("/NotFound");

            return Page();
        }
    }
}
