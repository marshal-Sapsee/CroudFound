using CroudFound.Models;
using CroudFound.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace CroudFoundSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IEnumerable<AccountData> accountData { get ; set; }
        private readonly IAcoountRepository _db;

        public IndexModel(ILogger<IndexModel> logger, IAcoountRepository db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            accountData = _db.GetAllAccountData();
        }
    }
}