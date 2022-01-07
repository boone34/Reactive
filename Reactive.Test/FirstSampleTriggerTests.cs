using System;
using System.Reactive;
using Microsoft.Reactive.Testing;
using NUnit.Framework;

namespace TechNoir.Reactive.Test
{
    /// <summary>
    /// FirstSampleTrigger operator Tests.
    /// Implements the <see cref="BaseTest" />
    /// </summary>
    /// <seealso cref="BaseTest" />
    [TestFixture]
    public class FirstSampleTriggerTests : BaseTest
    {
        /// <summary>
        /// Source:  ----1---------2---------3
        /// Trigger: ---------T---------T---------T
        /// Output:  ----1---------2---------3
        /// </summary>
        [Test, Order(100)]
        public void SourceFirst()
        {
            var scheduler = new TestScheduler();

            var source  = scheduler.CreateHotObservable(OnNexts(100, 200, 3, i => i + 1));
            var trigger = scheduler.CreateHotObservable(OnNexts(200, 200, 3, _ => Unit.Default));

            ReactiveAssert
            .AreElementsEqual
            (
                OnNexts(100, 200, 3, i => i + 1),
                scheduler.Start(() => source.FirstSampleTrigger(trigger), 0, 0, 900).Messages
            )
            ;
        }

        /// <summary>
        /// Source:  ---------1---------2---------3
        /// Trigger: ----T---------T---------t
        /// Output:  ---------1---------2---------3
        /// </summary>
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
                scheduler.Start(() => source.FirstSampleTrigger(trigger), 0, 0, 900).Messages
            )
            ;
        }

        /// <summary>
        /// Source:  ----1---------2---------3---------|
        /// Trigger: ---------T---------T---------T---------|
        /// Output:  ----1---------2---------3---------|
        /// </summary>
        [Test, Order(300)]
        public void SourceCompletesFirst()
        {
            var scheduler = new TestScheduler();

            var source  = scheduler.CreateHotObservable(OnNextsCompleted(100, 200, 3, i => i + 1));
            var trigger = scheduler.CreateHotObservable(OnNextsCompleted(200, 200, 3, _ => Unit.Default));

            ReactiveAssert
            .AreElementsEqual
            (
                OnNextsCompleted(100, 200, 3, i => i + 1),
                scheduler.Start(() => source.FirstSampleTrigger(trigger), 0, 0, 900).Messages
            )
            ;
        }

        /// <summary>
        /// Source:  ----1---------2---------3---------|
        /// Trigger: ---------T---------T---------|
        /// Output:  ----1---------2---------3----|
        /// </summary>
        [Test, Order(400)]
        public void TriggerCompletesFirst()
        {
            var scheduler = new TestScheduler();

            var source  = scheduler.CreateHotObservable(OnNextsCompleted(100, 200, 3, i => i + 1));
            var trigger = scheduler.CreateHotObservable(OnNextsCompleted(200, 200, 2, _ => Unit.Default));

            ReactiveAssert
            .AreElementsEqual
            (
                OnNexts(100, 200, 3, i => i + 1, _ => OnCompleted<int>(600)),
                scheduler.Start(() => source.FirstSampleTrigger(trigger), 0, 0, 900).Messages
            )
            ;
        }

        /// <summary>
        /// Source:  ----1---------2---------3---------#
        /// Trigger: ---------T---------T---------T---------|
        /// Output:  ----1---------2---------3---------#
        /// </summary>
        [Test, Order(500)]
        public void SourceError()
        {
            var scheduler = new TestScheduler();

            var source  = scheduler.CreateHotObservable(OnNextsError(100, 200, 3, i => i + 1, new Exception()));
            var trigger = scheduler.CreateHotObservable(OnNextsCompleted(200, 200, 3, _ => Unit.Default));

            ReactiveAssert
            .AreElementsEqual
            (
                OnNextsError(100, 200, 3, i => i + 1, e => e is Exception),
                scheduler.Start(() => source.FirstSampleTrigger(trigger), 0, 0, 900).Messages
            )
            ;
        }

        /// <summary>
        /// Source:  ----1---------2---------3---------|
        /// Trigger: ---------T---------T---------#
        /// Output:  ----1---------2---------3----#
        /// </summary>
        [Test, Order(600)]
        public void TriggerError()
        {
            var scheduler = new TestScheduler();

            var source  = scheduler.CreateHotObservable(OnNextsCompleted(100, 200, 3, i => i + 1));
            var trigger = scheduler.CreateHotObservable(OnNextsError(200, 200, 2, _ => Unit.Default, new Exception()));

            ReactiveAssert
            .AreElementsEqual
            (
                OnNexts(100, 200, 3, i => i + 1, _ => OnError<int>(600, e => e is Exception)),
                scheduler.Start(() => source.FirstSampleTrigger(trigger), 0, 0, 900).Messages
            )
            ;
        }

        /// <summary>
        /// Source:  ---1---2---3---4---5---6
        /// Trigger: ---------T-------T-------T
        /// Output:  ---1-----2-------4-------6
        /// </summary>
        [Test, Order(700)]
        public void FasterSource()
        {
            var scheduler = new TestScheduler();

            var source  = scheduler.CreateHotObservable(OnNexts(100, 100, 6, i => i + 1));
            var trigger = scheduler.CreateHotObservable(OnNexts(250, 200, 3, _ => Unit.Default));

            ReactiveAssert
            .AreElementsEqual
            (
                new [] { OnNext(100, 1), OnNext(250, 2), OnNext(450, 4), OnNext(650, 6) },
                scheduler.Start(() => source.FirstSampleTrigger(trigger), 0, 0, 900).Messages
            )
            ;
        }

        /// <summary>
        /// Source:  ---------1-------2-------3
        /// Trigger: ---T---T---T---T---T---T
        /// Output:  ---------1-------2-------3
        /// </summary>
        [Test, Order(800)]
        public void FasterTrigger()
        {
            var scheduler = new TestScheduler();

            var source  = scheduler.CreateHotObservable(OnNexts(250, 200, 3, i => i + 1));
            var trigger = scheduler.CreateHotObservable(OnNexts(100, 100, 6, _ => Unit.Default));

            ReactiveAssert
            .AreElementsEqual
            (
                new [] { OnNext(250, 1), OnNext(450, 2), OnNext(650, 3) },
                scheduler.Start(() => source.FirstSampleTrigger(trigger), 0, 0, 900).Messages
            )
            ;
        }

        /// <summary>
        /// Source:  ---1---1---2---3---4---3
        /// Trigger: ---------T-------T-------T
        /// Output:  ---1-------2-----3--------
        /// </summary>
        [Test, Order(900)]
        public void DistinctFasterSource()
        {
            var scheduler = new TestScheduler();

            var source  = scheduler.CreateHotObservable(OnNext(100, 1), OnNext(200, 1), OnNext(300, 2), OnNext(400, 3), OnNext(500, 4), OnNext(600, 3));
            var trigger = scheduler.CreateHotObservable(OnNexts(250, 200, 3, _ => Unit.Default));

            ReactiveAssert
            .AreElementsEqual
            (
                new [] { OnNext(100, 1), OnNext(300, 2), OnNext(450, 3) },
                scheduler.Start(() => source.FirstSampleTrigger(trigger), 0, 0, 900).Messages
            )
            ;
        }

        /// <summary>
        /// Source:  ---------1-------1-------2-------3-------4-------3
        /// Trigger: ---T---T---T---T---T---T---T---T---T---T---T---T---T
        /// Output:  ---------1---------------2-------3-------4-------3
        /// </summary>
        [Test, Order(1000)]
        public void DistinctFasterTrigger()
        {
            var scheduler = new TestScheduler();

            var source  = scheduler.CreateHotObservable(OnNext(250, 1), OnNext(350, 1), OnNext(550, 2), OnNext(750, 3), OnNext(950, 4), OnNext(1150, 3));
            var trigger = scheduler.CreateHotObservable(OnNexts(100, 100, 13, _ => Unit.Default));

            ReactiveAssert
            .AreElementsEqual
            (
                new [] { OnNext(250, 1), OnNext(550, 2), OnNext(750, 3), OnNext(950, 4), OnNext(1150, 3) },
                scheduler.Start(() => source.FirstSampleTrigger(trigger), 0, 0, 2000).Messages
            )
            ;
        }
    }
}
