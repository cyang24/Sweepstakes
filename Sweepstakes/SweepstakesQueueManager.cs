using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class SweepstakesQueueManager : Manager, ISweepstakesManager
    {   

        public Queue<Sweepstakes> myQueue;

        public SweepstakesQueueManager(Sweepstakes sweepstakes)
        {
            managerName = "b";
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
