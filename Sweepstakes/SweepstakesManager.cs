﻿using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public interface ISweepstakesManager
    {
        
        void InsertSweepstakes(Sweepstakes sweepstakes);
        Sweepstakes GetSweepstakes();

    }
}
