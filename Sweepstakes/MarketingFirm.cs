using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class MarketingFirm 
    {
        public string managerName;
      
        public MarketingFirm(User_Interface user_Interface)
        {
            Console.WriteLine("What manager type would you like to use? \na) Stack Manager \nb) Queue Manager");
            managerName = Console.ReadLine().ToLower();

            user_Interface.GetManager(managerName);
        }  


    }
}
