using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Product_classes
{
    public class PlantiumF : AbstractFactoryDesignPattern
    {
        protected override CreaditCard MakeProduct()
        {
            CreaditCard card = new Plantium();
            return card;
        }
    }
}
