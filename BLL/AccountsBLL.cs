﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AccountsBLL
    {
        AccountsDAL accountsDAL;

        public AccountsBLL()
        {
            accountsDAL = new AccountsDAL();
        }

        public IList<Account> getListAccounts()
        {
            return accountsDAL.getListAccounts();
        }
    }
}