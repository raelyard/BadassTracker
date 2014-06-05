using System;
using BadassTracker.Model.Events.Creation;
using NUnit.Framework;
using Should;

namespace BadassTracker.Model.Tests.Events.DomainServices.SicknessEpisodeEventManagerTests
{
    public class WhenCreatingASicknessEpisodeEventWithEndDate : WhenCreatingASicknessEpisodeEventBase
    {
        private const string EndDateTimeString = "2050-01-01";
        private readonly DateTime _endDateTime = DateTime.Parse(EndDateTimeString);

        protected override Action<SicknessEpisodeEventBuilder> BuilderAction
        {
            get { return builder => builder.EndingAt(_endDateTime); }
        }

        [Test]
        public void ShouldSetEndDate()
        {
            Event.EndDateTime.ShouldEqual(_endDateTime);
        }
    }
}