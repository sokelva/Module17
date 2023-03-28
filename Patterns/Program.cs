using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            Calculator.CalculateInterest(account);
        }
    }
}
