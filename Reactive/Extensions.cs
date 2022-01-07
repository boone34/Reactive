using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Reactive.Linq;

namespace TechNoir.Reactive
{
    /// <summary>
    /// Class Extensions.
    /// Implements Trigger and FirstSampleTrigger observable operators.
    /// </summary>
    public static class Extensions
	{
        private class TriggerObservable<TResult, TTrigger> : IDisposable
		{
            private readonly object              _Lock;
            private readonly CompositeDisposable _Disposables;
            private          bool                _Triggered;
            private          bool                _TriggerCompleted;
            private readonly IObserver<TResult>  _Observer;

            public void Dispose()
			{
				_Disposables.Dispose();
			}

            private void SourceOnNext(TResult value)
			{
				lock (_Lock)
				{
					if (!_Triggered) return;

					_Observer.OnNext(value);
					_Triggered = false;

					if (_TriggerCompleted)
						_Observer.OnCompleted();
				}
			}

            private void TriggerOnNext()
			{
				lock (_Lock) { _Triggered = true; }
			}

            private void TriggerOnCompleted()
			{
				lock (_Lock)
				{
					if (!_Triggered)
						_Observer.OnCompleted();

					_TriggerCompleted = true;
				}
			}

            public TriggerObservable(IObservable<TResult> source, IObservable<TTrigger> trigger, IObserver<TResult> observer)
			{
				if (source == null)  throw new ArgumentNullException(nameof(source));
				if (trigger == null) throw new ArgumentNullException(nameof(trigger));

				_Lock        = new object();
				_Disposables = new CompositeDisposable();
				_Observer    = observer;

				_Disposables.Add(source.Subscribe(SourceOnNext, _Observer.OnError, _Observer.OnCompleted));
				_Disposables.Add(trigger.Subscribe(_ => TriggerOnNext(), _Observer.OnError, TriggerOnCompleted));
			}
		}

        /// <summary>
        /// Trigger operator which outputs a source value only after a trigger. Once a source value is output the trigger is reset.
        ///
        /// Source:  ----1----2----3----4----
        /// Trigger: -------T---------T------
        /// Output:  ---------2---------4----
        ///
        /// If either the source or trigger complete the output completes.
        /// If either the source or trigger error the output error's.
        /// </summary>
        /// <typeparam name="TResult">The type of the source observable.</typeparam>
        /// <typeparam name="TTrigger">The type of the trigger observable.</typeparam>
        /// <param name="source">The source observable.</param>
        /// <param name="trigger">The trigger observable.</param>
        /// <returns>IObservable&lt;TResult&gt;.</returns>
        public static IObservable<TResult> Trigger<TResult, TTrigger>(this IObservable<TResult> source, IObservable<TTrigger> trigger)
			=>
		Observable.Create<TResult>(observer => new TriggerObservable<TResult, TTrigger>(source, trigger, observer))
		;

        private class FirstSampleTriggerObservable<TResult, TTrigger, TKey> : IDisposable
		{
            private enum States
			{
                Starting,
                WaitingForOne,
                WaitingForDistinct,
                HaveDistinct,
                Triggered
            }

            private readonly object                  _Lock;
            private          States                  _State;
            private readonly CompositeDisposable     _Disposables;
            private          TResult                 _LastValue;
            private          TResult                 _NextValue;
            private readonly IObserver<TResult>      _Observer;
            private readonly Func<TResult, TKey>     _KeySelector;
            private readonly IEqualityComparer<TKey> _KeyComparer;

            public void Dispose()
			{
				_Disposables.Dispose();
			}

            private bool IsDistinct(TResult value) => !_KeyComparer.Equals(_KeySelector(_LastValue), _KeySelector(value));

            private void SourceOnNext(TResult value)
			{
				lock (_Lock)
				{
					switch (_State)
					{
						case States.Starting:
							_Observer.OnNext(value);
							_LastValue = value;
							_State = States.WaitingForDistinct;
							break;
						case States.WaitingForOne:
							_Observer.OnNext(value);
							_Observer.OnCompleted();
							break;
						case States.WaitingForDistinct:
							if (IsDistinct(value))
							{
								_NextValue = value;
								_State = States.HaveDistinct;
							}
							break;
						case States.HaveDistinct:
							if (IsDistinct(value))
								_NextValue = value;
							else
								_State = States.WaitingForDistinct;
							break;
						case States.Triggered:
							if (IsDistinct(value))
							{
								_Observer.OnNext(value);
								_LastValue = value;
								_State = States.WaitingForDistinct;
							}
							break;
						default:
							throw new ArgumentOutOfRangeException();
					}
				}
			}

            private void TriggerOnNext()
			{
				lock (_Lock)
				{
					switch (_State)
					{
						case States.Starting:
						case States.WaitingForOne:
						case States.Triggered:
							break;
						case States.WaitingForDistinct:
							_State = States.Triggered;
							break;
						case States.HaveDistinct:
							_Observer.OnNext(_NextValue);
							_LastValue = _NextValue;
							_State = States.WaitingForDistinct;
							break;
						default:
							throw new ArgumentOutOfRangeException();
					}
				}
			}

            private void TriggerOnCompleted()
			{
				lock (_Lock)
				{
					switch (_State)
					{
						case States.Starting:
							_State = States.WaitingForOne;
							break;
						case States.WaitingForOne:
						case States.WaitingForDistinct:
						case States.HaveDistinct:
						case States.Triggered:
							_Observer.OnCompleted();
							break;
						default:
							throw new ArgumentOutOfRangeException();
					}
				}
			}

            public FirstSampleTriggerObservable(IObservable<TResult> source, IObservable<TTrigger> trigger, IObserver<TResult> observer, Func<TResult, TKey> key_selector, IEqualityComparer<TKey> comparer)
			{
				if (source == null) throw new ArgumentNullException(nameof(source));
				if (trigger == null) throw new ArgumentNullException(nameof(trigger));

				_Lock = new object();
				_State = States.Starting;
				_Disposables = new CompositeDisposable();
				_Observer = observer;
				_KeySelector = key_selector ?? throw new ArgumentNullException(nameof(key_selector));
				_KeyComparer = comparer ?? throw new ArgumentNullException(nameof(comparer));

				_Disposables.Add(source.Subscribe(SourceOnNext, _Observer.OnError, _Observer.OnCompleted));
				_Disposables.Add(trigger.Subscribe(_ => TriggerOnNext(), _Observer.OnError, TriggerOnCompleted));
			}
		}

        private class DefaultEqualityComparer<T> : IEqualityComparer<T>
		{
            public bool Equals(T x, T y)   => x == null ? y == null : x.Equals(y);
            public int  GetHashCode(T obj) => obj.GetHashCode();
		}

        /// <summary>
        /// Trigger operator which outputs the first source value followed by distinct source values on trigger.
        ///
        /// Source:  ----1----2----3----4----3----4----5-----
        /// Trigger: -------T---------T---------T---------T--
        /// Output:  ----1----2-------3-----------4-------5--
        ///
        /// If either the source or trigger complete the output completes.
        /// If either the source or trigger error the output error's.
        ///
        /// This operator facilitates keeping UI updated with the latest data. For example consider updating a data grid based on a search term entered
        /// by a user where retrieving the data can take some time (ie. database look up etc).
        /// 
        /// Often this is addressed by throttling user criteria changes and performing the lookup on the throttled criteria. Doing this will delay the
        /// first grid update. Also since the throttle time is not synchronized to the lookup time this can lead to un necessary lookups (when the throttle
        /// time is less than the lookup time) or missed updates (when the throttle time is greater than the lookup time).
        ///
        /// This operator addresses these issues by emitting the first criteria immediately and then emitting changed criteria synchronized to lookup
        /// completion.
        ///
        /// To use the <paramref name="source" /> should be an observable of the criteria, <paramref name="trigger" /> should be a observable of lookup
        /// completion. Note that the type of the trigger is immaterial. Each time the operator emits a criteria a lookup should be initiated. In this
        /// way the UI will be updated as quickly as lookups can be performed.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <typeparam name="TTrigger">The type of the trigger.</typeparam>
        /// <param name="source">The source <see cref="IObservable{TResult}"/>.</param>
        /// <param name="trigger">The trigger <see cref="IObservable{TTrigger}"/>.</param>
        /// <returns><see cref="IObservable{TResult}"/>.</returns>
        public static IObservable<TResult> FirstSampleTrigger<TResult, TTrigger>(this IObservable<TResult> source, IObservable<TTrigger> trigger)
			=>
		Observable
		.Create<TResult>
		(observer => new FirstSampleTriggerObservable<TResult, TTrigger, TResult>(source, trigger, observer, val => val, new DefaultEqualityComparer<TResult>()))
		;

        /// <summary>
        /// <see cref="FirstSampleTrigger{TResult,TTrigger}(IObservable{TResult}, IObservable{TTrigger})"/> overload.
        ///
        /// Accepts an <see cref="IEqualityComparer{TResult}"/> allowing for custom comparison of source values to determine distinctness.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <typeparam name="TTrigger">The type of the trigger.</typeparam>
        /// <param name="source">The source <see cref="IObservable{TResult}"/>.</param>
        /// <param name="trigger">The trigger <see cref="IObservable{TTrigger}"/>.</param>
        /// <param name="comparer">The <see cref="IEqualityComparer{TResult}"/> used to compare source values.</param>
        /// <returns><see cref="IObservable{TResult}"/>.</returns>
        public static IObservable<TResult> FirstSampleTrigger<TResult, TTrigger>(this IObservable<TResult> source, IObservable<TTrigger> trigger, IEqualityComparer<TResult> comparer)
			=>
		Observable
		.Create<TResult>
		(observer => new FirstSampleTriggerObservable<TResult, TTrigger, TResult>(source, trigger, observer, val => val, comparer))
		;

        /// <summary>
        /// <see cref="FirstSampleTrigger{TResult,TTrigger}(IObservable{TResult}, IObservable{TTrigger})"/> overload.
        ///
        /// Accepts an <see cref="Func{TResult,Tkey}">source key selector</see> allowing for comparison of source key values to determine distinctness.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <typeparam name="TTrigger">The type of the trigger.</typeparam>
        /// <typeparam name="TKey">The type of the source key.</typeparam>
        /// <param name="source">The source <see cref="IObservable{TResult}"/>.</param>
        /// <param name="trigger">The trigger <see cref="IObservable{TTrigger}"/>.</param>
        /// <param name="key_selector">The <see cref="Func{TResult,Tkey}">source key selector</see> used to select source keys.</param>
        /// <returns><see cref="IObservable{TResult}"/>.</returns>
        public static IObservable<TResult> FirstSampleTrigger<TResult, TTrigger, TKey>(this IObservable<TResult> source, IObservable<TTrigger> trigger, Func<TResult, TKey> key_selector)
			=>
		Observable
		.Create<TResult>
		(observer => new FirstSampleTriggerObservable<TResult, TTrigger, TKey>(source, trigger, observer, key_selector, new DefaultEqualityComparer<TKey>()))
		;

        /// <summary>
        /// <see cref="FirstSampleTrigger{TResult, TTrigger, TKey}(IObservable{TResult}, IObservable{TTrigger}, Func{TResult, TKey})"/> overload.
        ///
        /// Accepts an <see cref="IEqualityComparer{TKey}"/> allowing for custom comparison of source key values to determine distinctness.
        /// </summary>
        /// <typeparam name="TResult">The type of the t result.</typeparam>
        /// <typeparam name="TTrigger">The type of the t trigger.</typeparam>
        /// <typeparam name="TKey">The type of the source key.</typeparam>
        /// <param name="source">The source <see cref="IObservable{TResult}"/>.</param>
        /// <param name="trigger">The trigger <see cref="IObservable{TTrigger}"/>.</param>
        /// <param name="key_selector">The <see cref="Func{TResult,Tkey}">source key selector</see> used to select source keys.</param>
        /// <param name="comparer">The <see cref="IEqualityComparer{TKey}"/> used to compare source key values.</param>
        /// <returns><see cref="IObservable{TResult}"/>.</returns>
        public static IObservable<TResult> FirstSampleTrigger<TResult, TTrigger, TKey>(this IObservable<TResult> source, IObservable<TTrigger> trigger, Func<TResult, TKey> key_selector, IEqualityComparer<TKey> comparer)
			=>
		Observable
		.Create<TResult>
		(observer => new FirstSampleTriggerObservable<TResult, TTrigger, TKey>(source, trigger, observer, key_selector, comparer))
		;
	}
}
