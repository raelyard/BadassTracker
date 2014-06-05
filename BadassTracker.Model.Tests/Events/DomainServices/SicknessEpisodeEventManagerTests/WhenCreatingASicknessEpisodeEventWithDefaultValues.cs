using System;
using BadassTracker.Model.Events.Creation;
using NUnit.Framework;
using Should;

namespace BadassTracker.Model.Tests.Events.DomainServices.SicknessEpisodeEventManagerTests
{
    public class WhenCreatingASicknessEpisodeEventWithDefaultValues : WhenCreatingASicknessEpisodeEventBase
    {
        protected override Action<SicknessEpisodeEventBuilder> BuilderAction
        {
            get { return builder => { }; }
        }

        [Test]
        public void ShouldGetStartDateToNow()
        {
            Event.StartDateTime.ShouldBeInRange(DateTime.Now.AddSeconds(-.1), DateTime.Now);
        }

        [Test]
        public void ShouldGetDefaultStartDate()
        {
            Event.StartDateTime.ShouldBeInRange(DateTime.Now.AddSeconds(-.1), DateTime.Now);
        }
    }
}