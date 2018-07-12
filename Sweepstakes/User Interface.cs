using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class User_Interface : IGetManager
    {
        
        public Manager GetManager(string managerName)
        {
            switch (managerName.ToLower())
            {
                case "a":
                    return new SweepstakesStackManager();
                case "b":
                    return new SweepstakesQueueManager();
                default:
                    throw new ApplicationException(string.Format("Not a valid manager type"));
            }

        }


        //public void GetContestantInformation(Contestant contestants)
        //{
            //Console.WriteLine("Please enter your first name");
            //contestants.FirstName = Console.ReadLine();

            //Console.WriteLine("Please enter your last name");
            //contestants.LastName = Console.ReadLine();

            //Console.WriteLine("Please enter your email");
            //contestants.Email = Console.ReadLine();

        //}
        
        
    }
}
