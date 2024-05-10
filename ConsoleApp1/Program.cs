using ConsoleApp1.Interfaces;
using ConsoleApp1.Product_classes;
using System;

class Program
{
    static public void Main()
    {


        CreaditCard cardDetails = FactoryDesignPattern.GetCreaditCard("MoneyBack");


        if (cardDetails != null)
        {
            Console.WriteLine("CardType : " + cardDetails.GetCardType());
            Console.WriteLine("CreditLimit : " + cardDetails.GetCreaditLimit());
            Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
        }
        else
        {
            Console.Write("Invalid Card Type");
        }

        Console.WriteLine("---------------------------\n abstract factory:\n");

        CreaditCard creditCard = new TitaniumF().CreatCreadtCard();
        if (creditCard != null)
        {
            Console.WriteLine("Card Type : " + creditCard.GetCardType());
            Console.WriteLine("Credit Limit : " + creditCard.GetCreaditLimit());
            Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
        }
        else
        {
            Console.Write("Invalid Card Type");
        }
        Console.WriteLine("--------------");
        //MoneyBackFactory CreateProduct method will return an instance of Platinum Product via the CreditCard interface
        creditCard = new MoneyBackF().CreatCreadtCard();
        if (creditCard != null)
        {
            Console.WriteLine("Card Type : " + creditCard.GetCardType());
            Console.WriteLine("Credit Limit : " + creditCard.GetCreaditLimit());
            Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
        }
        else
        {
            Console.Write("Invalid Card Type");
        }

        Console.ReadLine();
    }

}

