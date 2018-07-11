using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class User_Interface
    {   
        public Contestant contestants;
        
        public User_Interface()
        {
            
        }

        public void GetContestantInformation()
        {   
            Console.WriteLine("Please enter your first name");
            contestants.FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name");
            contestants.LastName = Console.ReadLine();

            Console.WriteLine("Please enter your email");
            contestants.Email = Console.ReadLine();

            Console.WriteLine("Please enter your registration number");
            contestants.RegistrationNumber = int.Parse(Console.ReadLine());
        }


    }
}
