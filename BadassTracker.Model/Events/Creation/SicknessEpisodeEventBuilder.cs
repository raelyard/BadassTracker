using System;

namespace BadassTracker.Model.Events.Creation
{
    public class SicknessEpisodeEventBuilder
    {
        private readonly SicknessEpisodeEvent _event;

        public SicknessEpisodeEventBuilder()
        {
            _event = new SicknessEpisodeEvent();
        }

        public SicknessEpisodeEvent Build()
        {
            return _event;
        }

        public SicknessEpisodeEventBuilder EndingAt(DateTime endDateTime)
        {
            _event.EndingAt(endDateTime);
            return this;
        }
    }
}
