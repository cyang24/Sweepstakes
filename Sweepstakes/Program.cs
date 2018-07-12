using System;
using System.Collections.Generic;
using System.Collections;

namespace Sweepstakes
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Test");

            Contestant contestant = new Contestant("Tom", "Tom", "Tom@yahoo.com");
           
            Sweepstakes sweepstakes = new Sweepstakes("WIN $5000 DOLLARS");

            User_Interface user_Interface = new User_Interface();

            MarketingFirm marketing = new MarketingFirm(user_Interface);



            Console.ReadLine();
            
        }
    }
}
