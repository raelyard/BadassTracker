using System;
using BadassTracker.Model.Events.Creation;

namespace BadassTracker.Model.Tests.Events.DomainServices.SicknessEpisodeEventManagerTests
{
    public class WhenCreatingASicknessEpisodeEventWithStartDate : WhenCreatingASicknessEpisodeEventBase
    {
        private const string StartDateTimeString = "2040-01-01";
        private readonly DateTime _startDateTime = DateTime.Parse(StartDateTimeString);

        protected override Action<SicknessEpisodeEventBuilder> BuilderAction
        {
            get { return builder => builder.StartingAt(_startDateTime); }
        }
    }
}