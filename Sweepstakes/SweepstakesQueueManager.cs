﻿using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {   
        Queue<Sweepstakes> myQueue;

        public SweepstakesQueueManager()
        {
            myQueue = new Queue<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            myQueue.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return myQueue.Dequeue();
        }


    }
}
