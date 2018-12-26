using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Reactive.Linq;

namespace TechNoir.Reactive
{
	public static class Extensions
	{
		private class TriggerObservable<TResult, TTrigger> : IDisposable
		{
			private readonly object _Lock;
			private readonly CompositeDisposable _Disposables;
			private bool _Triggered;
			private bool _TriggerCompleted;
			private readonly IObserver<TResult> _Observer;

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
				if (source == null) throw new ArgumentNullException(nameof(source));
				if (trigger == null) throw new ArgumentNullException(nameof(trigger));

				_Lock = new object();
				_Disposables = new CompositeDisposable();
				_Observer = observer;

				_Disposables.Add(source.Subscribe(SourceOnNext, _Observer.OnError, _Observer.OnCompleted));
				_Disposables.Add(trigger.Subscribe(_ => TriggerOnNext(), _Observer.OnError, TriggerOnCompleted));
			}
		}

		public static IObservable<TResult> Trigger<TResult, TTrigger>(this IObservable<TResult> source, IObservable<TTrigger> trigger)
		{
			return Observable.Create<TResult>(observer => new TriggerObservable<TResult, TTrigger>(source, trigger, observer));
		}

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

			private readonly object _Lock;
			private States _State;
			private readonly CompositeDisposable _Disposables;
			private TResult _LastValue;
			private TResult _NextValue;
			private readonly IObserver<TResult> _Observer;
			private readonly Func<TResult, TKey> _KeySelector;
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
							_State = States.Triggered;
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
			public bool Equals(T x, T y) => x == null ? y == null : x.Equals(y);
			public int GetHashCode(T obj) => obj.GetHashCode();
		}

		public static IObservable<TResult> FirstSampleTrigger<TResult, TTrigger>(this IObservable<TResult> source, IObservable<TTrigger> trigger)
		{
			return
			Observable
			.Create<TResult>
			(observer => new FirstSampleTriggerObservable<TResult, TTrigger, TResult>(source, trigger, observer, val => val, new DefaultEqualityComparer<TResult>()))
			;
		}

		public static IObservable<TResult> FirstSampleTrigger<TResult, TTrigger>(this IObservable<TResult> source, IObservable<TTrigger> trigger, IEqualityComparer<TResult> comparer)
		{
			return
			Observable
			.Create<TResult>
			(observer => new FirstSampleTriggerObservable<TResult, TTrigger, TResult>(source, trigger, observer, val => val, comparer))
			;
		}

		public static IObservable<TResult> FirstSampleTrigger<TResult, TTrigger, TKey>(this IObservable<TResult> source, IObservable<TTrigger> trigger, Func<TResult, TKey> key_selector)
		{
			return
			Observable
			.Create<TResult>
			(observer => new FirstSampleTriggerObservable<TResult, TTrigger, TKey>(source, trigger, observer, key_selector, new DefaultEqualityComparer<TKey>()))
			;
		}

		public static IObservable<TResult> FirstSampleTrigger<TResult, TTrigger, TKey>(this IObservable<TResult> source, IObservable<TTrigger> trigger, Func<TResult, TKey> key_selector, IEqualityComparer<TKey> comparer)
		{
			return
			Observable
			.Create<TResult>
			(observer => new FirstSampleTriggerObservable<TResult, TTrigger, TKey>(source, trigger, observer, key_selector, comparer))
			;
		}
	}
}
