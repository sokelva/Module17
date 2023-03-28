using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSalaryNS
{
    public class AccountSalary
    {
        public static double Rate = 0.5;

        public double CalculateAccountSalary(Account account)
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * Rate;
            return account.Interest;
        }
    }
}
