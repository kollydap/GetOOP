using System;
using System.Collections.Generic;
using System.Text;

namespace BetterOOP
{
    public interface IPainter
    {
        bool IsAvailable { get; }
        void EstimateTimeToPaint(double sqMeters);
        double EstimateCompensation(double sqMeters);
    }
}
