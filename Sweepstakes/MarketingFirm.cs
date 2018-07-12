using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        public MarketingFirm(User_Interface_Factory user_Interface, Sweepstakes sweepstakes)
        {
            user_Interface.GetManager(user_Interface.ChooseDataManager(), sweepstakes);
            return;
        }

    }
}
