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
            //Create new contestant
            Contestant contestant = new Contestant("Tom", "Tom", "Tom@yahoo.com");
            //Create sweepstakes
            Sweepstakes sweepstakes = new Sweepstakes("WIN $5000 DOLLARS");
            sweepstakes.RegisterContestant(contestant);

            //Create UI(Factory)
            User_Interface_Factory user_Interface = new User_Interface_Factory();
        
           //Create Marketing firm 
            MarketingFirm marketing = new MarketingFirm(user_Interface, sweepstakes);

            sweepstakes.PrintContestantInfo(contestant);

            Console.ReadLine();

        }
    }
}
