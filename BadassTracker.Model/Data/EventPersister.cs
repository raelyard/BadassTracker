using BadassTracker.Model.Events;

namespace BadassTracker.Model.Data
{
    public interface EventPersister
    {
        void Add(SicknessEpisodeEvent sicknessEpisodeEvent);
    }
}