using System;
using BadassTracker.Model.Data;
using BadassTracker.Model.Events;
using BadassTracker.Model.Events.Creation;
using BadassTracker.Model.Events.DomainServices;
using NUnit.Framework;
using Rhino.Mocks;

namespace BadassTracker.Model.Tests.Events.DomainServices.SicknessEpisodeEventManagerTests
{
    [TestFixture]
    public abstract class WhenCreatingASicknessEpisodeEventBase
    {
        private EventPersister _persister;
        protected SicknessEpisodeEvent Event;
        protected abstract Action<SicknessEpisodeEventBuilder> BuilderAction { get; }

        [TestFixtureSetUp]
        public void Setup()
        {
            _persister = MockRepository.GenerateStub<EventPersister>();
            Event = new SicknessEpisodeEventManager(_persister).Create(e => BuilderAction(e));
        }

        [Test]
        public void ShouldPersistEvent()
        {
            _persister.AssertWasCalled(persister => persister.Add(Event));
        }
    }
}
