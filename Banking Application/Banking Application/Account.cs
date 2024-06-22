using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Banking_Application
{
    public class Account : SavingAccount
    {

       public void Main(string[] args)
        {
            Account account = new Account();

          
        }

        public void MonthlyStatement()
        {
            Console.WriteLine($"Acccoount Number {accoubtNumber}");
            Console.WriteLine("This is the monthly Statment fot the SaviningAccouunt");
        }

    }
  



}
