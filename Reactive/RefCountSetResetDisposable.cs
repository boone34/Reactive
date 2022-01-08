using System;
using System.Reactive.Disposables;

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
		private readonly object _Lock;
		private          uint   _RefCount;
		private readonly Action _Set;
		private readonly Action _Reset;

		private void OnDispose()
		{
			lock (_Lock)
			{
				if (_RefCount == 0) return;

				_RefCount--;

				if (_RefCount == 0)
					_Reset?.Invoke();
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
				if (_RefCount == 0)
					_Set?.Invoke();

				_RefCount++;

				return Disposable.Create(OnDispose);
			}
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="RefCountSetResetDisposable"/> class.
        /// </summary>
        /// <param name="set">Action to be performed when this is set the first time.</param>
        /// <param name="reset">Action to be performed when this is disposed the last time (when reference count == 0).</param>
        public RefCountSetResetDisposable(Action set, Action reset)
		{
			_Lock  = new object();
			_Set   = set;
			_Reset = reset;
		}
	}
}
