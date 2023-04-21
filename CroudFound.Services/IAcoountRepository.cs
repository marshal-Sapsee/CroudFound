using CroudFound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroudFound.Services
{
    public interface IAcoountRepository
    {
        IEnumerable<AccountData> GetAllAccountData();
        AccountData GetAccount(int id);

    }
}
