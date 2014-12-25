using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAccountPraacticeApp
{
    class AccountClass
    {
       
       public  double amount=0.0;
        public string accountNo, customerName;
        public double GetDeposit(double value)
        {
            
            return amount+value;
        }
        public double GetWithdraw(double value)
        {
            return amount-value;
        }

    }
}
