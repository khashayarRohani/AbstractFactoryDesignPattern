using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  ConsoleApp1.Interfaces;

namespace ConsoleApp1.Product_classes
{
    public class MoneyBackF: AbstractFactoryDesignPattern
    {
        protected override CreaditCard MakeProduct()
        {
            CreaditCard card = new MoneyBack();
            return card;
        }
    }
}
