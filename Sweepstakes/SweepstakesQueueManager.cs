using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {   
        Queue<string> queue = new Queue<string>();

        public SweepstakesQueueManager()
        {
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes){}
        public Sweepstakes GetSweepstakes(){}


    }
}
