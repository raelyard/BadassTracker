using System;

namespace BadassTracker.Model.Events.Creation
{
    public class SicknessEpisodeEventBuilder
    {
        private DateTime? _endDateTime;
        public SicknessEpisodeEvent Build()
        {
            return new SicknessEpisodeEvent(_endDateTime);
        }

        public SicknessEpisodeEventBuilder EndingAt(DateTime endDateTime)
        {
            _endDateTime = endDateTime;
            return this;
        }
    }
}
