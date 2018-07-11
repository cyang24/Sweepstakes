using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> contestantsRegistered;

        public string sweepstakeName;
        public string name
        {
            get { return sweepstakeName; }
        }


        public Sweepstakes(string name)
        {
            sweepstakeName = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestantsRegistered.Add(contestant.RegistrationNumber, contestant);
            contestant.RegistrationNumber++;
        }

        public string PickWinner()
        {
            Random r = new Random();
            int random = r.Next(0, contestantsRegistered.Count);
            return "Congratulations: " + contestantsRegistered[random].FirstName + " " + contestantsRegistered[random].LastName + "!";
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(PickWinner());
        }

       
    }
}
