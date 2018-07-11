using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class User_Interface
    {
        ISweepstakesManager Manager;
        
        public User_Interface()
        {

        }

        public void GetContestantInformation(Contestant contestants)
        {
            Console.WriteLine("Please enter your first name");
            contestants.FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name");
            contestants.LastName = Console.ReadLine();

            Console.WriteLine("Please enter your email");
            contestants.Email = Console.ReadLine();

        }
        
        public void ChoseManager()
        {
            Console.WriteLine("Please choose how you would like to manage the data ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "a":
                    Manager = new SweepstakesStackManager();
                    break;
                case "b":
                    Manager = new SweepstakesQueueManager();
                    break;
                case "c":
                    throw new ApplicationException(string.Format("Not a valid manager type"));
            }

        }
    }
}
