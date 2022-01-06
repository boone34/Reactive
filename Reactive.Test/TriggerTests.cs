using System;
using System.Reactive;
using Microsoft.Reactive.Testing;
using NUnit.Framework;

namespace TechNoir.Reactive.Test
{
    [TestFixture]
    public class TriggerTests : BaseTest
    {
        [Test, Order(100)]
        public void SourceFirst()
        {
            var scheduler = new TestScheduler();

            var source  = scheduler.CreateHotObservable(OnNexts(100, 200, 3, i => i + 1));
            var trigger = scheduler.CreateHotObservable(OnNexts(200, 200, 3, _ => Unit.Default));

            ReactiveAssert
            .AreElementsEqual
            (
                OnNexts(300, 200, 2, i => i + 2),
                scheduler.Start(() => source.Trigger(trigger), 0, 0, 900).Messages
            )
            ;
        }

        [Test, Order(200)]
        public void TriggerFirst()
        {
            var scheduler = new TestScheduler();

            var source  = scheduler.CreateHotObservable(OnNexts(200, 200, 3, i => i + 1));
            var trigger = scheduler.CreateHotObservable(OnNexts(100, 200, 3, _ => Unit.Default));

            ReactiveAssert
            .AreElementsEqual
            (
                OnNexts(200, 200, 3, i => i + 1),
                scheduler.Start(() => source.Trigger(trigger), 0, 0, 900).Messages
            )
            ;
        }

        [Test, Order(300)]
        public void SourceCompletesFirst()
        {
            var scheduler = new TestScheduler();

            var source  = scheduler.CreateHotObservable(OnNextsCompleted(100, 200, 3, i => i + 1));
            var trigger = scheduler.CreateHotObservable(OnNextsCompleted(200, 200, 3, _ => Unit.Default));

            ReactiveAssert
            .AreElementsEqual
            (
                OnNextsCompleted(300, 200, 2, i => i + 2),
                scheduler.Start(() => source.Trigger(trigger), 0, 0, 900).Messages
            )
            ;
        }

        [Test, Order(400)]
        public void TriggerCompletesFirst()
        {
            var scheduler = new TestScheduler();

            var source  = scheduler.CreateHotObservable(OnNextsCompleted(100, 200, 3, i => i + 1));
            var trigger = scheduler.CreateHotObservable(OnNextsCompleted(200, 200, 2, _ => Unit.Default));

            ReactiveAssert
            .AreElementsEqual
            (
                OnNexts(300, 200, 2, i => i + 2, _ => OnCompleted<int>(600)),
                scheduler.Start(() => source.Trigger(trigger), 0, 0, 900).Messages
            )
            ;
        }

        [Test, Order(500)]
        public void SourceError()
        {
            var scheduler = new TestScheduler();

            var source  = scheduler.CreateHotObservable(OnNextsError(100, 200, 3, i => i + 1, new Exception()));
            var trigger = scheduler.CreateHotObservable(OnNextsCompleted(200, 200, 3, _ => Unit.Default));

            ReactiveAssert
            .AreElementsEqual
            (
                OnNextsError(300, 200, 2, i => i + 2, e => e is Exception),
                scheduler.Start(() => source.Trigger(trigger), 0, 0, 900).Messages
            )
            ;
        }

        [Test, Order(600)]
        public void TriggerError()
        {
            var scheduler = new TestScheduler();

            var source  = scheduler.CreateHotObservable(OnNextsCompleted(100, 200, 3, i => i + 1));
            var trigger = scheduler.CreateHotObservable(OnNextsError(200, 200, 2, _ => Unit.Default, new Exception()));

            ReactiveAssert
            .AreElementsEqual
            (
                OnNexts(300, 200, 2, i => i + 2, _ => OnError<int>(600, e => e is Exception)),
                scheduler.Start(() => source.Trigger(trigger), 0, 0, 900).Messages
            )
            ;
        }
    }
}
