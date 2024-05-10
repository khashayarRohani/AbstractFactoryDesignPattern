using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  ConsoleApp1.Interfaces;

namespace ConsoleApp1.Product_classes
{
    public class MoneyBack: CreaditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreaditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge() 
        {
            return 500;
        }
    }
}
