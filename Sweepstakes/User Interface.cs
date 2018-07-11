using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class User_Interface
    {
        
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


    }
}
