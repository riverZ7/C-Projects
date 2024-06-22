using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Application
{
    public class SavingAccount
    { 
         public string accoubtNumber = "NUm 23443";
        public void withdraw(decimal amount)
        {
            

        }

        public void deposit(decimal amount)
        {

        }
           public int resultsOfSavings()
        {
            int deposit = 1000;
            int withdraw = 500;
          
            
            int calcuSav = deposit - withdraw;
            return calcuSav;


            Console.WriteLine("this what is left in the Savinng");
            Console.WriteLine(calcuSav);
        }
    }
}
