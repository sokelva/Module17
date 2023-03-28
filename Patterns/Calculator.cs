using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountOrdinaryNS;
using AccountSalaryNS;

public static class Calculator
{
    // Метод для расчета процентной ставки
    public static void CalculateInterest(Account account)
    {
        if (account.Type == "Обычный")
        {
            account.Interest = new AccountOrdinary().CalculateAccountOrdinary(account);
        }
        
        if (account.Type == "Зарплатный")
        {
            account.Interest = new AccountSalary().CalculateAccountSalary(account);
        }
    }
}
