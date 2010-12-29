using System;

namespace Rogue.HeartTracker.Infrastructure
{
    public interface IEventAggregator
    {
        IObservable<TEvent> GetEvent<TEvent>();
        void Publish<TEvent>(TEvent evt);
    }
}