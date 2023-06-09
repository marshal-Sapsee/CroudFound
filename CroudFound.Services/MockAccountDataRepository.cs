﻿using CroudFound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CroudFound.Services
{
    public class MockAccountDataRepository : IAcoountRepository
    {
        private List<AccountData> _accountDataList;

        public MockAccountDataRepository() 
        {
            _accountDataList = new List<AccountData>()
            {
                new AccountData() {
                    accountType = Users.SuperAdmin,
                    Id = 0,
                    Email = "SuperAdmin@gmail.com",
                    Password = "SuperAdminPass",
                    Name = "Super",
                    SurName = "Admin",
                    Country = "Belarus",
                    Region = "Brest",
                    City = "Bereza",
                    Address = "Office",
                    PostalCode = "None",
                    Birth = DateTime.Parse("12.02.1990"),
                    PhoneNumber = "None"

                },
                new AccountData() {
                    accountType = Users.Admin,
                    Id = 1,
                    Email = "Admin@gmail.com",
                    Password = "AdminHardPass",
                    Name = "Admin",
                    SurName = "Savanchuk",
                    Country = "Belarus",
                    Region = "Brest",
                    City = "Bereza",
                    Address = "Office",
                    PostalCode = "None",
                    Birth = DateTime.Parse("12.04.1990"),
                    PhoneNumber = "None"

                },
                new AccountData() {
                    accountType = Users.User,
                    Id = 2,
                    Email = "Mail.sapsee@gmail.com",
                    Password = "UserPass",
                    Name = "Pavel",
                    SurName = "Savanchuk",
                    Country = "Belarus",
                    Region = "Brest",
                    City = "Bereza",
                    Address = "Soviet 68, 19",
                    PostalCode = "225295",
                    Birth = DateTime.Parse("12.05.1990"),
                    PhoneNumber = "+375255223246"

                },
                new AccountData() {
                    accountType = Users.Visitor,
                    Id = 3,
                    Email = "Unathorized",
                    Password = "Unathorized",
                    Name = "Unathorized",
                    SurName = "Unathorized",
                    Country = "Unathorized",
                    Region = "Unathorized",
                    City = "Unathorized",
                    Address = "Unathorized",
                    PostalCode = "Unathorized",
                    Birth = DateTime.Now,
					PhoneNumber = "Unathorized"
                }
            };
        }

        public AccountData GetAccount(int id)
        {
            return _accountDataList.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<AccountData> GetAllAccountData()
        {
            return _accountDataList;
        }
    }
}
