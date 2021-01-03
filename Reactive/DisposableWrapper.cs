using System;

namespace TechNoir.Reactive
{
    public class DisposableWrapper<T> : IDisposable
    {
        private IDisposable _Disposable;
        
        protected bool Disposed { get; private set; }

        public T Wrapped { get; }

        protected virtual void Dispose(bool disposing)
        {
            if (Disposed) return;

            if (disposing && _Disposable != null)
            {
                _Disposable.Dispose();
                _Disposable = null;
            }

            Disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public DisposableWrapper(T wrapped)
        {
            _Disposable = wrapped as IDisposable;;
            Wrapped     = wrapped;
        }
    }
}
