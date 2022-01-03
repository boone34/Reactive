using System;

namespace TechNoir.Reactive
{
    /// <summary>
    /// Class DisposableWrapper.
    /// Implements the <see cref="IDisposable" />
    /// Used to wrap an object which may or may not be <see cref="IDisposable" />. If the wrapped object is <see cref="IDisposable" /> it will be disposed when this is disposed.
    /// </summary>
    /// <typeparam name="T">Type of the wrapped object</typeparam>
    /// <seealso cref="IDisposable" />
    public class DisposableWrapper<T> : IDisposable
    {
        /// <summary>
        /// The disposable
        /// </summary>
        private IDisposable _Disposable;

        /// <summary>
        /// Gets a value indicating whether this <see cref="DisposableWrapper{T}"/> is disposed.
        /// </summary>
        /// <value><c>true</c> if disposed; otherwise, <c>false</c>.</value>
        protected bool Disposed { get; private set; }

        /// <summary>
        /// Gets the wrapped object.
        /// </summary>
        /// <value>The wrapped.</value>
        public T Wrapped { get; }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
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

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DisposableWrapper{T}"/> class.
        /// </summary>
        /// <param name="wrapped">The wrapped object.</param>
        public DisposableWrapper(T wrapped)
        {
            _Disposable = wrapped as IDisposable;;
            Wrapped     = wrapped;
        }
    }
}
