using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class Contestants
    {
        private string firstName;
        private string lastName;
        private string email;
        private string registrationNumber;

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

        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }


        public Contestants(String firstName, String lastName, String Email, String RegistrationNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            RegistrationNumber = registrationNumber;
        }
    }
}
