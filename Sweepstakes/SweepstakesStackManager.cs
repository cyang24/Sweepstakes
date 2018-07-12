using System;
using System.Collections.Generic;


namespace Sweepstakes
{
    public class SweepstakesStackManager : Manager, ISweepstakesManager
    {   
        public Stack<Sweepstakes> myStack;

        public SweepstakesStackManager()
        {
            managerName = "a";
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
