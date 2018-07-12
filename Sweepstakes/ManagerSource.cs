using System;
namespace Sweepstakes
{
    public interface IManagerSource
    {
        ISweepstakesManager Manager
        {
            get; 
        }
    }
}
