using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        public ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager Manager)
        {
            this.manager = Manager;
            User_Interface user_Interface = new User_Interface();
            user_Interface.ChoseManager();
        }
    }
}
