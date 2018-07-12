using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class User_Interface_Factory : IGetManager
    {   
        public string managerName;
        
        public Manager GetManager(string managerName, Sweepstakes sweepstakes)
        {
            switch (managerName.ToLower())
            {
                case "a":
                    return new SweepstakesStackManager(sweepstakes);
                case "b":
                    return new SweepstakesQueueManager(sweepstakes);
                default:
                    throw new ApplicationException(string.Format("Not a valid manager type"));
            }

        }

        public string ChooseDataManager()
        {
            Console.WriteLine("What manager type would you like to use? \na) Stack Manager \nb) Queue Manager");
            managerName = Console.ReadLine().ToLower();
            return managerName;
        }

        
    }
}
