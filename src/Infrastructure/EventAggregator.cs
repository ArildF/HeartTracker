using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Rogue.HeartTracker.Infrastructure
{
    public class EventAggregator : IEventAggregator
    {
        private readonly IDictionary<Type, object> _events = new ConcurrentDictionary<Type, object>();

        public IObservable<TEvent> GetEvent<TEvent>()
        {
            Subject<TEvent> evt = DoGetEvent<TEvent>();

            return evt;
        }

        private Subject<TEvent> DoGetEvent<TEvent>()
        {
            Subject<TEvent> evt;
            object obj;
            if (!_events.TryGetValue(typeof(TEvent), out obj))
            {
                evt = new Subject<TEvent>();
                _events.Add(typeof(TEvent), evt);
            }
            else
            {
                evt = (Subject<TEvent>)obj;
            }
            return evt;
        }

        public void Publish<TEvent>(TEvent arg)
        {
            DoGetEvent<TEvent>().OnNext(arg);
        }

    }
}