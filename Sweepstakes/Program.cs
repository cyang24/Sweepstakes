using System;
using System.Collections.Generic;
using System.Collections;

namespace Sweepstakes
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Start Sweetstakes Test");
            Console.WriteLine("\n");

            //Create new contestants
            Contestant contestant = new Contestant("Tom", "Tom", "Tom@yahoo.com");
            Contestant contestant2 = new Contestant("Bob", "Bob", "Bob@yahoo.com"); 
            Contestant contestant3 = new Contestant("John", "John", "John@yahoo.com");
            Contestant contestant4= new Contestant("Mike", "H", "Mike@yahoo.com");
            Contestant contestant5 = new Contestant("Mike", "T", "Bob@yahoo.com");
            Contestant contestant6 = new Contestant("Wade", "Wade", "Wade@yahoo.com");

            //Create sweepstakes
            Sweepstakes sweepstakes = new Sweepstakes("WIN $5000 DOLLARS!");
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.RegisterContestant(contestant2);
            sweepstakes.RegisterContestant(contestant3);

            Sweepstakes sweepstakes2 = new Sweepstakes("WIN FORTNITE THEMEPARK GET AWAY!");
            sweepstakes2.RegisterContestant(contestant4);
            sweepstakes2.RegisterContestant(contestant5);
            sweepstakes2.RegisterContestant(contestant6);

            Sweepstakes sweepstakes3 = new Sweepstakes("WIN SEASON PACKER TICKET PASSES FOR LIFE!");
            sweepstakes3.RegisterContestant(contestant4);
            sweepstakes3.RegisterContestant(contestant5);
            sweepstakes3.RegisterContestant(contestant6);

            //Create UI(Factory)
            User_Interface_Factory user_Interface = new User_Interface_Factory();
        
           //Create Marketing firm 
            MarketingFirm marketing = new MarketingFirm(user_Interface, sweepstakes);

            Console.WriteLine(sweepstakes.PickWinner() + "\n");  
            Console.WriteLine(sweepstakes2.PickWinner()+ "\n");
            Console.WriteLine(sweepstakes3.PickWinner()+ "\n");

            Console.WriteLine("disclaimer: any similarities are purely coincidental.");

            Console.ReadLine();

        }
    }
}
