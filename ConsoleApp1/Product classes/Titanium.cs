using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Product_classes
{
    public class Titanium : CreaditCard
    {
        public string GetCardType()
        {
            return "Titanium Edge";
        }
        public int GetCreaditLimit()
        {
            return 25000;
        }
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }
}
