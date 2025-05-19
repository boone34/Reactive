using System;
using System.Reactive.Disposables;
using System.Threading;

namespace TechNoir.Reactive
{
    /// <summary>
    /// Class RefCountSetResetDisposable.
    ///
    /// Implements a reference count which manages a disposable. The first time the reference count is incremented by calling <see cref="Set"/>
    /// a <em>Set</em> action is invoked if not null.
    ///
    /// Each time the <see cref="IDisposable"/> returned from <see cref="Set"/> is disposed the reference count is decremented. Once decremented
    /// to zero the <em>Reset</em> action is invoked if not null.
    /// </summary>
    public class RefCountSetResetDisposable
	{
		private readonly object                  _Lock;
		private          uint                    _RefCount;
		private readonly Action?                 _Set;
		private readonly Action?                 _Reset;
		private readonly TimeSpan?               _FirstSetDelay;
		private readonly SynchronizationContext? _SynchronizationContext;
        
        private Timer? _SetTimer;

        private bool ClearSetTimer()
        {
            if (_SetTimer == null) return false;
            
            _SetTimer.Dispose();
            _SetTimer = null;
            
            return true;
        }
        
		private void OnDispose()
		{
			lock (_Lock)
			{
				if (_RefCount == 0) return;

				_RefCount--;

                if (_RefCount == 0 && !ClearSetTimer()) _Reset?.Invoke();
			}
		}

        private void SetDelayed()
        {
            lock (_Lock)
            {
                try
                {
                    if (_SynchronizationContext == null)
                        _Set!();
                    else
                        _SynchronizationContext.Post(_ => _Set!(), null);
                }
                finally
                {
                    ClearSetTimer();
                }
            }
        }
        
        /// <summary>
        /// Increments reference count. If reference count == 0 the <em>Set</em> action is invoked if not null.
        /// </summary>
        /// <returns><see cref="IDisposable" /> which should be disposed to decrement reference count.</returns>
        public IDisposable Set()
		{
			lock (_Lock)
			{
                if (_RefCount != 0 || _Set == null) return create_disposable(ref _RefCount);

                if (_FirstSetDelay == null)
                {
                    _Set.Invoke();
                    return create_disposable(ref _RefCount);
                }
                
                _SetTimer
                    =
                new Timer
                (
                    _ => SetDelayed(),
                    null,
                    _FirstSetDelay.Value,
                    Timeout.InfiniteTimeSpan
                )
                ;

                return create_disposable(ref _RefCount);

                IDisposable create_disposable(ref uint ref_count)
                {
    				ref_count++;
                    return Disposable.Create(OnDispose);
                }
			}
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="RefCountSetResetDisposable"/> class.
        /// </summary>
        /// <param name="set">Action to be performed when this is set the first time.</param>
        /// <param name="reset">Action to be performed when this is disposed the last time (when reference count == 0).</param>
        /// <param name="first_set_delay">Delay on first set, if disposed before <see cref="Set"/> is not called.</param>
        /// <param name="synchronization_context">If delayed context to use to invoke <see cref="Set"/>.</param>
        public RefCountSetResetDisposable(Action set, Action reset, TimeSpan? first_set_delay = null, SynchronizationContext? synchronization_context = null)
		{
			_Lock                   = new object();
			_Set                    = set;
			_Reset                  = reset;
            _FirstSetDelay          = first_set_delay;
            _SynchronizationContext = synchronization_context;
        }
	}
}
