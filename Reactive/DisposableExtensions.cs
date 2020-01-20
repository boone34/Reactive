using System;
using System.Linq;
using System.Reactive.Disposables;

namespace TechNoir.Reactive
{
    public static class DisposableExtensions
    {
        public static T DisposeWithComposite<T>(this T item, CompositeDisposable disposables)
            where T : IDisposable
        {
            if (disposables == null) throw new ArgumentNullException(nameof(disposables));

            disposables.Add(item);
            return item;
        }

        public static void AddObservable<T>(this CompositeDisposable disposables, IObservable<T> observable, Func<T, IDisposable> disposable_func, bool null_nop = true)
        {
            if (disposables == null)     throw new ArgumentNullException(nameof(disposables));
            if (observable == null)      throw new ArgumentNullException(nameof(observable));
            if (disposable_func == null) throw new ArgumentNullException(nameof(disposable_func));

            IDisposable disposable = null;

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

        public static void AddObservable<T>(this CompositeDisposable disposables, IObservable<T> observable, bool null_nop, params Func<T, IDisposable>[] disposable_funcs)
        {
            if (disposables == null)     throw new ArgumentNullException(nameof(disposables));
            if (observable == null)      throw new ArgumentNullException(nameof(observable));
            if (!disposable_funcs.Any()) throw new ArgumentOutOfRangeException(nameof(disposable_funcs));

            CompositeDisposable this_disposables = null;

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

        public static void AddObservable<T>(this CompositeDisposable disposables, IObservable<T> observable, params Func<T, IDisposable>[] disposable_funcs)
        {
            disposables.AddObservable(observable, true, disposable_funcs);
        }
    }
}
