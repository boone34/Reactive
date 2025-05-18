using System;
using System.Linq;
using System.Reactive.Disposables;

namespace TechNoir.Reactive
{
    /// <summary>
    /// Class DisposableExtensions.
    /// </summary>
    public static class DisposableExtensions
    {
        /// <summary>Disposes <paramref name="item" /> with <paramref name="disposables" />.</summary>
        /// <typeparam name="T">Must be a <see cref="IDisposable" />.</typeparam>
        /// <param name="item">The <see cref="IDisposable" /> to be disposed with <paramref name="disposables" />.</param>
        /// <param name="disposables">The <see cref="CompositeDisposable" /> to dispose <paramref name="item" />.</param>
        /// <returns><paramref name="item" />.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="disposables" /></exception>
        public static T DisposeWithComposite<T>(this T item, CompositeDisposable disposables)
            where T : IDisposable
        {
            if (disposables == null) throw new ArgumentNullException(nameof(disposables));

            disposables.Add(item);
            return item;
        }

        /// <summary>
        /// Adds/removes/replaces an <see cref="IDisposable" /> to <paramref name="disposables" /> based on the output of <paramref name="observable" />.
        /// </summary>
        /// <typeparam name="T">The <paramref name="observable" /> type.</typeparam>
        /// <param name="disposables">The <see cref="CompositeDisposable" /> to add/remove/replace the <see cref="IDisposable" /> to.</param>
        /// <param name="observable">The <see cref="IObservable{T}" /> used to generate the <see cref="IDisposable" /> with <paramref name="disposable_func"/>.</param>
        /// <param name="disposable_func">The function used to generate the <see cref="IDisposable" /> form <paramref name="observable"/> values.</param>
        /// <param name="null_nop">Determines weather null values are added to <paramref name="disposables" />. The default is false.</param>
        /// <exception cref="ArgumentNullException"><paramref name="disposables" /></exception>
        /// <exception cref="ArgumentNullException"><paramref name="observable" /></exception>
        /// <exception cref="ArgumentNullException"><paramref name="disposable_func" /></exception>
        public static void AddObservable<T>(this CompositeDisposable disposables, IObservable<T> observable, Func<T, IDisposable> disposable_func, bool null_nop = true)
        {
            if (disposables == null)     throw new ArgumentNullException(nameof(disposables));
            if (observable == null)      throw new ArgumentNullException(nameof(observable));
            if (disposable_func == null) throw new ArgumentNullException(nameof(disposable_func));

            IDisposable? disposable = null;

            observable
            .Subscribe
            (
                x
                    =>
                {
                    if (disposable != null)
                    {
                        if (!disposables.Remove(disposable)) disposable.Dispose();
                        disposable = null;
                    }

                    if (null_nop && x == null) return;

                    disposable = disposable_func(x)?.DisposeWithComposite(disposables);
                }
            )
            .DisposeWithComposite(disposables)
            ;
        }

        /// <summary>
        /// Adds/removes/replaces a <see cref="CompositeDisposable" /> to <paramref name="disposables" /> based on the output of <paramref name="observable" />.
        /// </summary>
        /// <typeparam name="T">The <paramref name="observable" /> type.</typeparam>
        /// <param name="disposables">The <see cref="CompositeDisposable" /> to add/remove/replace the <see cref="CompositeDisposable" /> to.</param>
        /// <param name="observable">The <see cref="IObservable{T}" /> used to generate the <see cref="CompositeDisposable" /> from <paramref name="disposable_funcs"/>.</param>
        /// <param name="null_nop">Determines weather null values are added to the <see cref="CompositeDisposable" />. Should be set to true to not add null values.</param>
        /// <param name="disposable_funcs">The functions used to generate the <see cref="CompositeDisposable" /> form <paramref name="observable"/> values.</param>
        /// <exception cref="ArgumentNullException">disposables</exception>
        /// <exception cref="ArgumentNullException">observable</exception>
        /// <exception cref="ArgumentOutOfRangeException">disposable_funcs</exception>
        public static void AddObservable<T>(this CompositeDisposable disposables, IObservable<T> observable, bool null_nop, params Func<T, IDisposable>[] disposable_funcs)
        {
            if (disposables == null)     throw new ArgumentNullException(nameof(disposables));
            if (observable == null)      throw new ArgumentNullException(nameof(observable));
            if (!disposable_funcs.Any()) throw new ArgumentOutOfRangeException(nameof(disposable_funcs));

            CompositeDisposable? this_disposables = null;

            observable
            .Subscribe
            (
                x
                    =>
                {
                    if (this_disposables != null)
                    {
                        if (!disposables.Remove(this_disposables)) this_disposables.Dispose();
                        this_disposables = null;
                    }

                    if (null_nop && x == null) return;

                    var func_disposables = disposable_funcs.Select(df => df(x)).Where(d => d != null).ToList();
                    if (!func_disposables.Any()) return;

                    this_disposables = new CompositeDisposable(func_disposables).DisposeWithComposite(disposables);
                }
            )
            .DisposeWithComposite(disposables)
            ;
        }

        /// <summary>
        /// Adds/removes/replaces a <see cref="CompositeDisposable" /> to <paramref name="disposables" /> based on the output of <paramref name="observable" />.
        /// Same as <see cref="AddObservable{T}(CompositeDisposable, IObservable{T}, bool, Func{T, IDisposable}[])" /> with null_nop set to true, null values are not added to the <see cref="CompositeDisposable" />.
        /// </summary>
        /// <typeparam name="T">The <paramref name="observable" /> type.</typeparam>
        /// <param name="disposables">The <see cref="CompositeDisposable" /> to add/remove/replace the <see cref="CompositeDisposable" /> to.</param>
        /// <param name="observable">The <see cref="IObservable{T}" /> used to generate the <see cref="CompositeDisposable" /> from <paramref name="disposable_funcs"/>.</param>
        /// <param name="disposable_funcs">The functions used to generate the <see cref="CompositeDisposable" /> form <paramref name="observable"/> values.</param>
        public static void AddObservable<T>(this CompositeDisposable disposables, IObservable<T> observable, params Func<T, IDisposable>[] disposable_funcs)
        {
            disposables.AddObservable(observable, true, disposable_funcs);
        }
    }
}
