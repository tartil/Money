using CreditLibrary;
﻿using BusinessCard;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Money.Money money = new Money.Money();
            money.GetMoney();
            BusinessCardMain businessCard = new BusinessCardMain();
            businessCard.UseBusinessCard();
        }
    }
}
