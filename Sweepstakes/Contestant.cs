using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class Contestant
    {
        private string firstName;
        private string lastName;
        private string email;
        private int registrationNumber;

        public string FirstName
        {
            get { return firstName; }
            set {  firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }


        public Contestant(String firstName, String lastName, String Email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }
}
