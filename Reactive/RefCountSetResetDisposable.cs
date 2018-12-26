using System;
using System.Reactive.Disposables;

namespace TechNoir.Reactive
{
	public class RefCountSetResetDisposable
	{
		private readonly object _Lock;
		private uint _RefCount;
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

		public RefCountSetResetDisposable(Action set, Action reset)
		{
			_Lock = new object();
			_Set = set;
			_Reset = reset;
		}
	}
}
