using System;

namespace BadassTracker.Model.Events.Creation
{
    public class SicknessEpisodeEventBuilder
    {
        private DateTime? _endDateTime;
        private DateTime? _startDateTime;

        public SicknessEpisodeEvent Build()
        {
            return new SicknessEpisodeEvent(_startDateTime, _endDateTime);
        }

        public SicknessEpisodeEventBuilder StartingAt(DateTime startDateTime)
        {
            _startDateTime = startDateTime;
            return this;
        }

        public SicknessEpisodeEventBuilder EndingAt(DateTime endDateTime)
        {
            _endDateTime = endDateTime;
            return this;
        }
    }
}
