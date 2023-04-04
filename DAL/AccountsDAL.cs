using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountsDAL
    {
        QuanLyChuongTrinhHocContext context = new QuanLyChuongTrinhHocContext();

        public IList<Account> getListAccounts()
        {
            var list = context.Accounts.ToList();
            return list;    
        }
    }
}
