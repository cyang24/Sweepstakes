using System;
using System.Collections.Generic;


namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {   
        Stack<Sweepstakes> myStack;

        public SweepstakesStackManager()
        {
            myStack = new Stack<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            myStack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return myStack.Pop();
        }
    }

}
