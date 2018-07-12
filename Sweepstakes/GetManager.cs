using System;
namespace Sweepstakes
{
    public interface IGetManager
    {
        Manager GetManager(string managerName, Sweepstakes sweepstakes);
    }
}
