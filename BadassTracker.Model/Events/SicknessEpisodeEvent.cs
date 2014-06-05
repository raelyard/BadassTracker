using System;

namespace BadassTracker.Model.Events
{
    public class SicknessEpisodeEvent
    {
        public SicknessEpisodeEvent()
        {
            StartDateTime = DateTime.Now;
            EndDateTime = StartDateTime;
        }

        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }

        internal void EndingAt(DateTime endDateTime)
        {
            EndDateTime = endDateTime;
        }
    }
}
