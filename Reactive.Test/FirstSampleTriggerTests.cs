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
                OnNexts(100, 200, 3, i => i + 2),
                scheduler.Start(() => source.FirstSampleTrigger(trigger), 0, 0, 900).Messages
            )
            ;
        }
    }
}
