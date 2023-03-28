using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOrdinaryNS
{
    public class AccountOrdinary
    {
        public static double Rate = 0.4;
        public static double RateTwo = 0.2;

        public double CalculateAccountOrdinary(Account account)
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            account.Interest = account.Balance * Rate;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * RateTwo;

            if (account.Balance < 50000)
                account.Interest -= account.Balance * Rate;

            return account.Interest;
        }
    }
}
