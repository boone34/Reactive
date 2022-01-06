using System;
using System.Linq;
using System.Reactive;
using Microsoft.Reactive.Testing;

namespace TechNoir.Reactive.Test
{
    public class BaseTest : ReactiveTest
    {
        protected Recorded<Notification<T>> [] OnNexts<T>(long start_ticks, long ticks_increment, int count, Func<int, T> next, Func<long, Recorded<Notification<T>>> last = null)
        {
            var records = Enumerable.Range(0, count).Select(i => OnNext(start_ticks + (i * ticks_increment), next(i))).ToList();
            if (last != null)
                records.Add(last(start_ticks + (count * ticks_increment)));

            return records.ToArray();
        }

        protected Recorded<Notification<T>> [] OnNextsCompleted<T>(long start_ticks, long ticks_increment, int count, Func<int, T> next)
            =>
        OnNexts(start_ticks, ticks_increment, count, next, OnCompleted<T>)
        ;

        protected Recorded<Notification<T>> [] OnNextsError<T>(long start_ticks, long ticks_increment, int count, Func<int, T> next, Exception exception)
            =>
        OnNexts(start_ticks, ticks_increment, count, next, ticks => OnError<T>(ticks, exception))
        ;

        protected Recorded<Notification<T>> [] OnNextsError<T>(long start_ticks, long ticks_increment, int count, Func<int, T> next, Func<Exception, bool> predicate)
            =>
        OnNexts(start_ticks, ticks_increment, count, next, ticks => OnError<T>(ticks, predicate))
        ;
    }
}
