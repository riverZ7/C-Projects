using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Application
{
    public class CheckingAccount : Account
    {
        public int CheckAccount() {

            int deposit = 2000;
            int withdraw = 3000;


            int calcuChe = deposit - withdraw;
            return calcuChe;

            if (deposit < withdraw) {
                Console.WriteLine("this is an over draft ");
            }
            else
            {
                Console.WriteLine("There is no over Draft ");
            }
        }

        public void withdraw2(decimal amount)
        {

        }

        public void deposit2(decimal amount)
        {

        }
    }
}
