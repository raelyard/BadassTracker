using System;
using BadassTracker.Model.Data;
using BadassTracker.Model.Events;
using BadassTracker.Model.Events.DomainServices;
using Rhino.Mocks;
using Should;

namespace BadassTracker.Specifications.Support
{
    public class SicknessEpisodeEventCreationContext
    {
        private SicknessEpisodeEvent _event;
        private readonly EventPersister _persister;
        private readonly SicknessEpisodeEventManager _manager;

        public SicknessEpisodeEventCreationContext()
        {
            _persister = MockRepository.GenerateStub<EventPersister>();
            _manager = new SicknessEpisodeEventManager(_persister);
        }

        public void StartCreation()
        {
            // doing nothing for the moment - this will be used for setting context when creating events via user interface
        }

        public void CreateEvent()
        {
            _event = _manager.Create(builder => { });
        }

        public void AssertEventTracked()
        {
            AssertEventNotNull();
            AssertStartAndEndDateSet();
            AssertEventSaved();
        }

        private void AssertStartAndEndDateSet()
        {
            _event.StartDateTime.ShouldNotBeInRange(DateTime.Now.AddSeconds(.1), DateTime.Now);
            _event.EndDateTime.ShouldNotBeInRange(DateTime.Now.AddSeconds(.1), DateTime.Now);
        }

        private void AssertEventNotNull()
        {
            _event.ShouldNotBeNull();
        }
        private void AssertEventSaved()
        {
            _persister.AssertWasCalled(persister => persister.Add(_event));
        }
    }
}
