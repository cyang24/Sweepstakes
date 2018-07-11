using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {   
        Stack<string> myStack = new Stack<string>();

        public SweepstakesStackManager()
        {
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes){}
        public Sweepstakes GetSweepstakes(){}
    }

}
