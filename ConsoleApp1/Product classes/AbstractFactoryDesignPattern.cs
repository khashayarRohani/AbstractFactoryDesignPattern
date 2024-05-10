using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Product_classes
{
    public abstract class  AbstractFactoryDesignPattern
    {
        protected abstract CreaditCard MakeProduct();


        public CreaditCard CreatCreadtCard()
        {
            return this.MakeProduct();
        }

    }

}

