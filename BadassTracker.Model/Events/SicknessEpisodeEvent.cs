using System;

namespace BadassTracker.Model.Events
{
    public class SicknessEpisodeEvent
    {
        internal SicknessEpisodeEvent(DateTime? endDateTime)
        {
            StartDateTime = DateTime.Now;
            EndDateTime = endDateTime ?? StartDateTime;
        }

        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }
    }
}
