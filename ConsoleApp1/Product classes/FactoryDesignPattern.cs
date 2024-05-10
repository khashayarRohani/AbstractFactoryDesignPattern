using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Product_classes
{
    public class FactoryDesignPattern
    {
        public static CreaditCard GetCreaditCard(string cardType)
        {
            CreaditCard cardDetails = null;

            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Plantium();
            }

            return cardDetails;
        }

    }
}
