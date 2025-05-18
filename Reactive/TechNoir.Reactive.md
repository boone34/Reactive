## TechNoir.Reactive Namespace
### Classes

<a name='TechNoir.Reactive.DisposableExtensions'></a>

## DisposableExtensions Class

Class DisposableExtensions.

```csharp
public static class DisposableExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DisposableExtensions
### Methods

<a name='TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,bool,System.Func_T,System.IDisposable_[])'></a>

## DisposableExtensions.AddObservable<T>(this CompositeDisposable, IObservable<T>, bool, Func<T,IDisposable>[]) Method

Adds/removes/replaces a [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') to [disposables](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,bool,System.Func_T,System.IDisposable_[]).disposables 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, bool, System.Func<T,System.IDisposable>[]).disposables') based on the output of [observable](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,bool,System.Func_T,System.IDisposable_[]).observable 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, bool, System.Func<T,System.IDisposable>[]).observable').

```csharp
public static void AddObservable<T>(this CompositeDisposable disposables, System.IObservable<T> observable, bool null_nop, params System.Func<T,System.IDisposable>[] disposable_funcs);
```
#### Type parameters

<a name='TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,bool,System.Func_T,System.IDisposable_[]).T'></a>

`T`

The [observable](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,bool,System.Func_T,System.IDisposable_[]).observable 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, bool, System.Func<T,System.IDisposable>[]).observable') type.
#### Parameters

<a name='TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,bool,System.Func_T,System.IDisposable_[]).disposables'></a>

`disposables` [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable')

The [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') to add/remove/replace the [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') to.

<a name='TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,bool,System.Func_T,System.IDisposable_[]).observable'></a>

`observable` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[T](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,bool,System.Func_T,System.IDisposable_[]).T 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, bool, System.Func<T,System.IDisposable>[]).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')

The [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1') used to generate the [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') from [disposable_funcs](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,bool,System.Func_T,System.IDisposable_[]).disposable_funcs 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, bool, System.Func<T,System.IDisposable>[]).disposable_funcs').

<a name='TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,bool,System.Func_T,System.IDisposable_[]).null_nop'></a>

`null_nop` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Determines weather null values are added to the [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable'). Should be set to true to not add null values.

<a name='TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,bool,System.Func_T,System.IDisposable_[]).disposable_funcs'></a>

`disposable_funcs` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,bool,System.Func_T,System.IDisposable_[]).T 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, bool, System.Func<T,System.IDisposable>[]).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The functions used to generate the [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') form [observable](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,bool,System.Func_T,System.IDisposable_[]).observable 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, bool, System.Func<T,System.IDisposable>[]).observable') values.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
disposables

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
observable

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
disposable_funcs

<a name='TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_,bool)'></a>

## DisposableExtensions.AddObservable<T>(this CompositeDisposable, IObservable<T>, Func<T,IDisposable>, bool) Method

Adds/removes/replaces an [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') to [disposables](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_,bool).disposables 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, System.Func<T,System.IDisposable>, bool).disposables') based on the output of [observable](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_,bool).observable 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, System.Func<T,System.IDisposable>, bool).observable').

```csharp
public static void AddObservable<T>(this CompositeDisposable disposables, System.IObservable<T> observable, System.Func<T,System.IDisposable> disposable_func, bool null_nop=true);
```
#### Type parameters

<a name='TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_,bool).T'></a>

`T`

The [observable](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_,bool).observable 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, System.Func<T,System.IDisposable>, bool).observable') type.
#### Parameters

<a name='TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_,bool).disposables'></a>

`disposables` [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable')

The [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') to add/remove/replace the [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') to.

<a name='TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_,bool).observable'></a>

`observable` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[T](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_,bool).T 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, System.Func<T,System.IDisposable>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')

The [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1') used to generate the [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') with [disposable_func](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_,bool).disposable_func 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, System.Func<T,System.IDisposable>, bool).disposable_func').

<a name='TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_,bool).disposable_func'></a>

`disposable_func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_,bool).T 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, System.Func<T,System.IDisposable>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The function used to generate the [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') form [observable](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_,bool).observable 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, System.Func<T,System.IDisposable>, bool).observable') values.

<a name='TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_,bool).null_nop'></a>

`null_nop` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Determines weather null values are added to [disposables](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_,bool).disposables 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, System.Func<T,System.IDisposable>, bool).disposables'). The default is false.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[disposables](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_,bool).disposables 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, System.Func<T,System.IDisposable>, bool).disposables')

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[observable](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_,bool).observable 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, System.Func<T,System.IDisposable>, bool).observable')

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[disposable_func](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_,bool).disposable_func 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, System.Func<T,System.IDisposable>, bool).disposable_func')

<a name='TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_[])'></a>

## DisposableExtensions.AddObservable<T>(this CompositeDisposable, IObservable<T>, Func<T,IDisposable>[]) Method

Adds/removes/replaces a [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') to [disposables](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_[]).disposables 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, System.Func<T,System.IDisposable>[]).disposables') based on the output of [observable](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_[]).observable 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, System.Func<T,System.IDisposable>[]).observable').  
Same as [AddObservable&lt;T&gt;(this CompositeDisposable, IObservable&lt;T&gt;, bool, Func&lt;T,IDisposable&gt;[])](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,bool,System.Func_T,System.IDisposable_[]) 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, bool, System.Func<T,System.IDisposable>[])') with null_nop set to true, null values are not added to the [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable').

```csharp
public static void AddObservable<T>(this CompositeDisposable disposables, System.IObservable<T> observable, params System.Func<T,System.IDisposable>[] disposable_funcs);
```
#### Type parameters

<a name='TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_[]).T'></a>

`T`

The [observable](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_[]).observable 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, System.Func<T,System.IDisposable>[]).observable') type.
#### Parameters

<a name='TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_[]).disposables'></a>

`disposables` [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable')

The [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') to add/remove/replace the [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') to.

<a name='TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_[]).observable'></a>

`observable` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[T](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_[]).T 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, System.Func<T,System.IDisposable>[]).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')

The [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1') used to generate the [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') from [disposable_funcs](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_[]).disposable_funcs 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, System.Func<T,System.IDisposable>[]).disposable_funcs').

<a name='TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_[]).disposable_funcs'></a>

`disposable_funcs` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_[]).T 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, System.Func<T,System.IDisposable>[]).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The functions used to generate the [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') form [observable](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.AddObservable_T_(thisCompositeDisposable,System.IObservable_T_,System.Func_T,System.IDisposable_[]).observable 'TechNoir.Reactive.DisposableExtensions.AddObservable<T>(this CompositeDisposable, System.IObservable<T>, System.Func<T,System.IDisposable>[]).observable') values.

<a name='TechNoir.Reactive.DisposableExtensions.DisposeWithComposite_T_(thisT,CompositeDisposable)'></a>

## DisposableExtensions.DisposeWithComposite<T>(this T, CompositeDisposable) Method

Disposes [item](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.DisposeWithComposite_T_(thisT,CompositeDisposable).item 'TechNoir.Reactive.DisposableExtensions.DisposeWithComposite<T>(this T, CompositeDisposable).item') with [disposables](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.DisposeWithComposite_T_(thisT,CompositeDisposable).disposables 'TechNoir.Reactive.DisposableExtensions.DisposeWithComposite<T>(this T, CompositeDisposable).disposables').

```csharp
public static T DisposeWithComposite<T>(this T item, CompositeDisposable disposables)
    where T : System.IDisposable;
```
#### Type parameters

<a name='TechNoir.Reactive.DisposableExtensions.DisposeWithComposite_T_(thisT,CompositeDisposable).T'></a>

`T`

Must be a [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable').
#### Parameters

<a name='TechNoir.Reactive.DisposableExtensions.DisposeWithComposite_T_(thisT,CompositeDisposable).item'></a>

`item` [T](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.DisposeWithComposite_T_(thisT,CompositeDisposable).T 'TechNoir.Reactive.DisposableExtensions.DisposeWithComposite<T>(this T, CompositeDisposable).T')

The [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') to be disposed with [disposables](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.DisposeWithComposite_T_(thisT,CompositeDisposable).disposables 'TechNoir.Reactive.DisposableExtensions.DisposeWithComposite<T>(this T, CompositeDisposable).disposables').

<a name='TechNoir.Reactive.DisposableExtensions.DisposeWithComposite_T_(thisT,CompositeDisposable).disposables'></a>

`disposables` [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable')

The [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') to dispose [item](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.DisposeWithComposite_T_(thisT,CompositeDisposable).item 'TechNoir.Reactive.DisposableExtensions.DisposeWithComposite<T>(this T, CompositeDisposable).item').

#### Returns
[T](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.DisposeWithComposite_T_(thisT,CompositeDisposable).T 'TechNoir.Reactive.DisposableExtensions.DisposeWithComposite<T>(this T, CompositeDisposable).T')  
[item](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.DisposeWithComposite_T_(thisT,CompositeDisposable).item 'TechNoir.Reactive.DisposableExtensions.DisposeWithComposite<T>(this T, CompositeDisposable).item').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[disposables](TechNoir.Reactive.md#TechNoir.Reactive.DisposableExtensions.DisposeWithComposite_T_(thisT,CompositeDisposable).disposables 'TechNoir.Reactive.DisposableExtensions.DisposeWithComposite<T>(this T, CompositeDisposable).disposables')

<a name='TechNoir.Reactive.DisposableWrapper_T_'></a>

## DisposableWrapper<T> Class

Class DisposableWrapper.  
Implements the [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  
Used to wrap an object which may or may not be [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable'). If the wrapped object is [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') it will be disposed when this is disposed.

```csharp
public class DisposableWrapper<T> :
System.IDisposable
```
#### Type parameters

<a name='TechNoir.Reactive.DisposableWrapper_T_.T'></a>

`T`

Type of the wrapped object

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DisposableWrapper<T>

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')

### See Also
- [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')
### Constructors

<a name='TechNoir.Reactive.DisposableWrapper_T_.DisposableWrapper(T)'></a>

## DisposableWrapper(T) Constructor

Initializes a new instance of the [DisposableWrapper&lt;T&gt;](TechNoir.Reactive.md#TechNoir.Reactive.DisposableWrapper_T_ 'TechNoir.Reactive.DisposableWrapper<T>') class.

```csharp
public DisposableWrapper(T wrapped);
```
#### Parameters

<a name='TechNoir.Reactive.DisposableWrapper_T_.DisposableWrapper(T).wrapped'></a>

`wrapped` [T](TechNoir.Reactive.md#TechNoir.Reactive.DisposableWrapper_T_.T 'TechNoir.Reactive.DisposableWrapper<T>.T')

The wrapped object.
### Fields

<a name='TechNoir.Reactive.DisposableWrapper_T_._Disposable'></a>

## DisposableWrapper<T>._Disposable Field

The disposable

```csharp
private IDisposable _Disposable;
```

#### Field Value
[System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')
### Properties

<a name='TechNoir.Reactive.DisposableWrapper_T_.Disposed'></a>

## DisposableWrapper<T>.Disposed Property

Gets a value indicating whether this [DisposableWrapper&lt;T&gt;](TechNoir.Reactive.md#TechNoir.Reactive.DisposableWrapper_T_ 'TechNoir.Reactive.DisposableWrapper<T>') is disposed.

```csharp
protected bool Disposed { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if disposed; otherwise, `false`.

<a name='TechNoir.Reactive.DisposableWrapper_T_.Wrapped'></a>

## DisposableWrapper<T>.Wrapped Property

Gets the wrapped object.

```csharp
public T Wrapped { get; }
```

#### Property Value
[T](TechNoir.Reactive.md#TechNoir.Reactive.DisposableWrapper_T_.T 'TechNoir.Reactive.DisposableWrapper<T>.T')  
The wrapped.
### Methods

<a name='TechNoir.Reactive.DisposableWrapper_T_.Dispose()'></a>

## DisposableWrapper<T>.Dispose() Method

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose();
```

Implements [Dispose()](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable.Dispose 'System.IDisposable.Dispose')

<a name='TechNoir.Reactive.DisposableWrapper_T_.Dispose(bool)'></a>

## DisposableWrapper<T>.Dispose(bool) Method

Releases unmanaged and - optionally - managed resources.

```csharp
protected virtual void Dispose(bool disposing);
```
#### Parameters

<a name='TechNoir.Reactive.DisposableWrapper_T_.Dispose(bool).disposing'></a>

`disposing` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

`true` to release both managed and unmanaged resources; `false` to release only unmanaged resources.

<a name='TechNoir.Reactive.Extensions'></a>

## Extensions Class

Class Extensions.  
Implements Trigger and FirstSampleTrigger observable operators.

```csharp
public static class Extensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Extensions
### Methods

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_)'></a>

## Extensions.FirstSampleTrigger<TResult,TTrigger,TKey>(this IObservable<TResult>, IObservable<TTrigger>, Func<TResult,TKey>) Method

[FirstSampleTrigger&lt;TResult,TTrigger&gt;(this IObservable&lt;TResult&gt;, IObservable&lt;TTrigger&gt;)](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_) 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger>(this System.IObservable<TResult>, System.IObservable<TTrigger>)') overload.  
              
             Accepts an [source key selector](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2') allowing for comparison of source key values to determine distinctness.

```csharp
public static System.IObservable<TResult> FirstSampleTrigger<TResult,TTrigger,TKey>(this System.IObservable<TResult> source, System.IObservable<TTrigger> trigger, System.Func<TResult,TKey> key_selector);
```
#### Type parameters

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_).TResult'></a>

`TResult`

The type of the result.

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_).TTrigger'></a>

`TTrigger`

The type of the trigger.

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_).TKey'></a>

`TKey`

The type of the source key.
#### Parameters

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_).source'></a>

`source` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TResult](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_).TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger,TKey>(this System.IObservable<TResult>, System.IObservable<TTrigger>, System.Func<TResult,TKey>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')

The source [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_).trigger'></a>

`trigger` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TTrigger](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_).TTrigger 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger,TKey>(this System.IObservable<TResult>, System.IObservable<TTrigger>, System.Func<TResult,TKey>).TTrigger')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')

The trigger [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_).key_selector'></a>

`key_selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_).TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger,TKey>(this System.IObservable<TResult>, System.IObservable<TTrigger>, System.Func<TResult,TKey>).TResult')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TKey](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_).TKey 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger,TKey>(this System.IObservable<TResult>, System.IObservable<TTrigger>, System.Func<TResult,TKey>).TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The [source key selector](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2') used to select source keys.

#### Returns
[System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TResult](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_).TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger,TKey>(this System.IObservable<TResult>, System.IObservable<TTrigger>, System.Func<TResult,TKey>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
[System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_,System.Collections.Generic.IEqualityComparer_TKey_)'></a>

## Extensions.FirstSampleTrigger<TResult,TTrigger,TKey>(this IObservable<TResult>, IObservable<TTrigger>, Func<TResult,TKey>, IEqualityComparer<TKey>) Method

[FirstSampleTrigger&lt;TResult,TTrigger,TKey&gt;(this IObservable&lt;TResult&gt;, IObservable&lt;TTrigger&gt;, Func&lt;TResult,TKey&gt;)](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_) 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger,TKey>(this System.IObservable<TResult>, System.IObservable<TTrigger>, System.Func<TResult,TKey>)') overload.  
              
             Accepts an [System.Collections.Generic.IEqualityComparer&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1') allowing for custom comparison of source key values to determine distinctness.

```csharp
public static System.IObservable<TResult> FirstSampleTrigger<TResult,TTrigger,TKey>(this System.IObservable<TResult> source, System.IObservable<TTrigger> trigger, System.Func<TResult,TKey> key_selector, System.Collections.Generic.IEqualityComparer<TKey> comparer);
```
#### Type parameters

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_,System.Collections.Generic.IEqualityComparer_TKey_).TResult'></a>

`TResult`

The type of the t result.

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_,System.Collections.Generic.IEqualityComparer_TKey_).TTrigger'></a>

`TTrigger`

The type of the t trigger.

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_,System.Collections.Generic.IEqualityComparer_TKey_).TKey'></a>

`TKey`

The type of the source key.
#### Parameters

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_,System.Collections.Generic.IEqualityComparer_TKey_).source'></a>

`source` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TResult](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_,System.Collections.Generic.IEqualityComparer_TKey_).TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger,TKey>(this System.IObservable<TResult>, System.IObservable<TTrigger>, System.Func<TResult,TKey>, System.Collections.Generic.IEqualityComparer<TKey>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')

The source [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_,System.Collections.Generic.IEqualityComparer_TKey_).trigger'></a>

`trigger` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TTrigger](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_,System.Collections.Generic.IEqualityComparer_TKey_).TTrigger 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger,TKey>(this System.IObservable<TResult>, System.IObservable<TTrigger>, System.Func<TResult,TKey>, System.Collections.Generic.IEqualityComparer<TKey>).TTrigger')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')

The trigger [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_,System.Collections.Generic.IEqualityComparer_TKey_).key_selector'></a>

`key_selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_,System.Collections.Generic.IEqualityComparer_TKey_).TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger,TKey>(this System.IObservable<TResult>, System.IObservable<TTrigger>, System.Func<TResult,TKey>, System.Collections.Generic.IEqualityComparer<TKey>).TResult')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TKey](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_,System.Collections.Generic.IEqualityComparer_TKey_).TKey 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger,TKey>(this System.IObservable<TResult>, System.IObservable<TTrigger>, System.Func<TResult,TKey>, System.Collections.Generic.IEqualityComparer<TKey>).TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The [source key selector](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2') used to select source keys.

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_,System.Collections.Generic.IEqualityComparer_TKey_).comparer'></a>

`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TKey](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_,System.Collections.Generic.IEqualityComparer_TKey_).TKey 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger,TKey>(this System.IObservable<TResult>, System.IObservable<TTrigger>, System.Func<TResult,TKey>, System.Collections.Generic.IEqualityComparer<TKey>).TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

The [System.Collections.Generic.IEqualityComparer&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1') used to compare source key values.

#### Returns
[System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TResult](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger,TKey_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Func_TResult,TKey_,System.Collections.Generic.IEqualityComparer_TKey_).TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger,TKey>(this System.IObservable<TResult>, System.IObservable<TTrigger>, System.Func<TResult,TKey>, System.Collections.Generic.IEqualityComparer<TKey>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
[System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_)'></a>

## Extensions.FirstSampleTrigger<TResult,TTrigger>(this IObservable<TResult>, IObservable<TTrigger>) Method

Operator which outputs the first source value followed by distinct source values on trigger.  
  
Source:  ----1----2----3----4----3----4----5-----  
Trigger: -------T---------T---------T---------T--  
Output:  ----1----2-------3-----------4-------5--  
  
If either the source or trigger complete the output completes.  
If either the source or trigger error the output error's.  
  
This operator facilitates keeping UI updated with the latest data. For example consider updating a data grid based on a search term entered  
by a user where retrieving the data can take some time (ie. database look up etc).  
  
Often this is addressed by throttling user criteria changes and performing the lookup on the throttled criteria. Doing this will delay the  
first grid update. Also since the throttle time is not synchronized to the lookup time this can lead to un necessary lookups (when the throttle  
time is less than the lookup time) or missed updates (when the throttle time is greater than the lookup time).  
  
This operator addresses these issues by emitting the first criteria immediately and then emitting changed criteria synchronized to lookup  
completion.  
  
To use the [source](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_).source 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger>(this System.IObservable<TResult>, System.IObservable<TTrigger>).source') should be an observable of the criteria, [trigger](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_).trigger 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger>(this System.IObservable<TResult>, System.IObservable<TTrigger>).trigger') should be a observable of lookup  
completion. Note that the type of the trigger is immaterial. Each time the operator emits a criteria a lookup should be initiated. In this  
way the UI will be updated as quickly as lookups can be performed.

```csharp
public static System.IObservable<TResult> FirstSampleTrigger<TResult,TTrigger>(this System.IObservable<TResult> source, System.IObservable<TTrigger> trigger);
```
#### Type parameters

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_).TResult'></a>

`TResult`

The type of the result.

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_).TTrigger'></a>

`TTrigger`

The type of the trigger.
#### Parameters

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_).source'></a>

`source` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TResult](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_).TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger>(this System.IObservable<TResult>, System.IObservable<TTrigger>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')

The source [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_).trigger'></a>

`trigger` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TTrigger](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_).TTrigger 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger>(this System.IObservable<TResult>, System.IObservable<TTrigger>).TTrigger')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')

The trigger [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').

#### Returns
[System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TResult](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_).TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger>(this System.IObservable<TResult>, System.IObservable<TTrigger>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
[System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Collections.Generic.IEqualityComparer_TResult_)'></a>

## Extensions.FirstSampleTrigger<TResult,TTrigger>(this IObservable<TResult>, IObservable<TTrigger>, IEqualityComparer<TResult>) Method

[FirstSampleTrigger&lt;TResult,TTrigger&gt;(this IObservable&lt;TResult&gt;, IObservable&lt;TTrigger&gt;)](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_) 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger>(this System.IObservable<TResult>, System.IObservable<TTrigger>)') overload.  
              
             Accepts an [System.Collections.Generic.IEqualityComparer&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1') allowing for custom comparison of source values to determine distinctness.

```csharp
public static System.IObservable<TResult> FirstSampleTrigger<TResult,TTrigger>(this System.IObservable<TResult> source, System.IObservable<TTrigger> trigger, System.Collections.Generic.IEqualityComparer<TResult> comparer);
```
#### Type parameters

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Collections.Generic.IEqualityComparer_TResult_).TResult'></a>

`TResult`

The type of the result.

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Collections.Generic.IEqualityComparer_TResult_).TTrigger'></a>

`TTrigger`

The type of the trigger.
#### Parameters

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Collections.Generic.IEqualityComparer_TResult_).source'></a>

`source` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TResult](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Collections.Generic.IEqualityComparer_TResult_).TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger>(this System.IObservable<TResult>, System.IObservable<TTrigger>, System.Collections.Generic.IEqualityComparer<TResult>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')

The source [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Collections.Generic.IEqualityComparer_TResult_).trigger'></a>

`trigger` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TTrigger](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Collections.Generic.IEqualityComparer_TResult_).TTrigger 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger>(this System.IObservable<TResult>, System.IObservable<TTrigger>, System.Collections.Generic.IEqualityComparer<TResult>).TTrigger')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')

The trigger [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').

<a name='TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Collections.Generic.IEqualityComparer_TResult_).comparer'></a>

`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TResult](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Collections.Generic.IEqualityComparer_TResult_).TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger>(this System.IObservable<TResult>, System.IObservable<TTrigger>, System.Collections.Generic.IEqualityComparer<TResult>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

The [System.Collections.Generic.IEqualityComparer&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1') used to compare source values.

#### Returns
[System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TResult](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.FirstSampleTrigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_,System.Collections.Generic.IEqualityComparer_TResult_).TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger<TResult,TTrigger>(this System.IObservable<TResult>, System.IObservable<TTrigger>, System.Collections.Generic.IEqualityComparer<TResult>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
[System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').

<a name='TechNoir.Reactive.Extensions.Trigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_)'></a>

## Extensions.Trigger<TResult,TTrigger>(this IObservable<TResult>, IObservable<TTrigger>) Method

Operator which outputs a source value only after a trigger. Once a source value is output the trigger is reset.  
  
Source:  ----1----2----3----4----  
Trigger: -------T---------T------  
Output:  ---------2---------4----  
  
If either the source or trigger complete the output completes.  
If either the source or trigger error the output error's.

```csharp
public static System.IObservable<TResult> Trigger<TResult,TTrigger>(this System.IObservable<TResult> source, System.IObservable<TTrigger> trigger);
```
#### Type parameters

<a name='TechNoir.Reactive.Extensions.Trigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_).TResult'></a>

`TResult`

The type of the source observable.

<a name='TechNoir.Reactive.Extensions.Trigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_).TTrigger'></a>

`TTrigger`

The type of the trigger observable.
#### Parameters

<a name='TechNoir.Reactive.Extensions.Trigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_).source'></a>

`source` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TResult](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.Trigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_).TResult 'TechNoir.Reactive.Extensions.Trigger<TResult,TTrigger>(this System.IObservable<TResult>, System.IObservable<TTrigger>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')

The source observable.

<a name='TechNoir.Reactive.Extensions.Trigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_).trigger'></a>

`trigger` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TTrigger](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.Trigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_).TTrigger 'TechNoir.Reactive.Extensions.Trigger<TResult,TTrigger>(this System.IObservable<TResult>, System.IObservable<TTrigger>).TTrigger')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')

The trigger observable.

#### Returns
[System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TResult](TechNoir.Reactive.md#TechNoir.Reactive.Extensions.Trigger_TResult,TTrigger_(thisSystem.IObservable_TResult_,System.IObservable_TTrigger_).TResult 'TechNoir.Reactive.Extensions.Trigger<TResult,TTrigger>(this System.IObservable<TResult>, System.IObservable<TTrigger>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
IObservable<TResult>.

<a name='TechNoir.Reactive.RefCountSetResetDisposable'></a>

## RefCountSetResetDisposable Class

Class RefCountSetResetDisposable.  
  
Implements a reference count which manages a disposable. The first time the reference count is incremented by calling [Set()](TechNoir.Reactive.md#TechNoir.Reactive.RefCountSetResetDisposable.Set() 'TechNoir.Reactive.RefCountSetResetDisposable.Set()')  
a <em>Set</em> action is invoked if not null.  
  
Each time the [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') returned from [Set()](TechNoir.Reactive.md#TechNoir.Reactive.RefCountSetResetDisposable.Set() 'TechNoir.Reactive.RefCountSetResetDisposable.Set()') is disposed the reference count is decremented. Once decremented  
to zero the <em>Reset</em> action is invoked if not null.

```csharp
public class RefCountSetResetDisposable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; RefCountSetResetDisposable
### Constructors

<a name='TechNoir.Reactive.RefCountSetResetDisposable.RefCountSetResetDisposable(System.Action,System.Action)'></a>

## RefCountSetResetDisposable(Action, Action) Constructor

Initializes a new instance of the [RefCountSetResetDisposable](TechNoir.Reactive.md#TechNoir.Reactive.RefCountSetResetDisposable 'TechNoir.Reactive.RefCountSetResetDisposable') class.

```csharp
public RefCountSetResetDisposable(System.Action set, System.Action reset);
```
#### Parameters

<a name='TechNoir.Reactive.RefCountSetResetDisposable.RefCountSetResetDisposable(System.Action,System.Action).set'></a>

`set` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Action to be performed when this is set the first time.

<a name='TechNoir.Reactive.RefCountSetResetDisposable.RefCountSetResetDisposable(System.Action,System.Action).reset'></a>

`reset` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Action to be performed when this is disposed the last time (when reference count == 0).
### Methods

<a name='TechNoir.Reactive.RefCountSetResetDisposable.Set()'></a>

## RefCountSetResetDisposable.Set() Method

Increments reference count. If reference count == 0 the <em>Set</em> action is invoked if not null.

```csharp
public System.IDisposable Set();
```

#### Returns
[System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  
[System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') which should be disposed to decrement reference count.