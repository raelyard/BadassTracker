using System;
using BadassTracker.Model.Data;
using BadassTracker.Model.Events.Creation;

namespace BadassTracker.Model.Events.DomainServices
{
    public class SicknessEpisodeEventManager
    {
        private readonly EventPersister _persister;

        public SicknessEpisodeEventManager(EventPersister persister)
        {
            _persister = persister;
        }

        public SicknessEpisodeEvent Create(Action<SicknessEpisodeEventBuilder> creationAction)
        {
            var builder = new SicknessEpisodeEventBuilder();
            creationAction(builder);
            var @event = builder.Build();
            _persister.Add(@event);
            return @event;
        }
    }
}
