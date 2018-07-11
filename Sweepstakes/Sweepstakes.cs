using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> contestantsRegistered;
        
        public Sweepstakes()
        {
            
        }

        public void SweepstakesRun(string name)
        {
           
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestantsRegistered.Add(contestant.RegistrationNumber, contestant);
            contestant.RegistrationNumber++;

        }

        public string PickWinner()
        {
           
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }

       
    }
}
