using System;
using BadassTracker.Model.Data;
using BadassTracker.Model.Events;
using BadassTracker.Model.Events.Creation;
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

        private DateTime? _endDateTime;

        public SicknessEpisodeEventCreationContext()
        {
            _persister = MockRepository.GenerateStub<EventPersister>();
            _manager = new SicknessEpisodeEventManager(_persister);
        }

        public void StartCreation()
        {
            // doing nothing for the moment - this will be used for setting context when creating events via user interface
        }

        public void SpecifyEndTime()
        {
            _endDateTime = DateTime.Now.AddHours(1);
        }

        public void CreateEvent()
        {
            Action<SicknessEpisodeEventBuilder> builderAction = builder => { };
            if (_endDateTime.HasValue)
            {
                builderAction = builder => builder.EndingAt(_endDateTime.Value);
            }
            _event = _manager.Create(builderAction);
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

        public void AssertCorrectEndDateTime()
        {
            _endDateTime.HasValue.ShouldBeTrue("End Date Time did not get set.");
            _event.EndDateTime.ShouldEqual(_endDateTime.Value);
        }
    }
}
