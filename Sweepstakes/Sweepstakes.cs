using System;
using System.Collections.Generic;


namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> contestantsRegistered;

        public int runningTotalRegistered = 0;
        public string sweepstakeName;

        public string Name
        {
            get { return sweepstakeName; }
        }


        public Sweepstakes(string name)
        {
            //contestantsRegistered.Count;
            sweepstakeName = name;
            contestantsRegistered = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestantsRegistered.Add(contestant.RegistrationNumber = runningTotalRegistered, contestant);
            runningTotalRegistered++;
        }

        public string PickWinner()
        {
            Random r = new Random();
            int random = r.Next(0, contestantsRegistered.Count);
            return "Congratulations: " + contestantsRegistered[random].FirstName + " " + contestantsRegistered[random].LastName + "! You won " + sweepstakeName;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(PickWinner());
        }

       
    }
}
