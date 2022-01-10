## TechNoir.Reactive Namespace
### Classes
<a name='TechNoir_Reactive_DisposableExtensions'></a>
## DisposableExtensions Class
Class DisposableExtensions.  
```csharp
public static class DisposableExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DisposableExtensions  
### Methods
<a name='TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__bool_System_Func_T_System_IDisposable___)'></a>
## DisposableExtensions.AddObservable&lt;T&gt;(CompositeDisposable, IObservable&lt;T&gt;, bool, Func&lt;T,IDisposable&gt;[]) Method
Adds/removes/replaces a [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') to [disposables](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__bool_System_Func_T_System_IDisposable___)_disposables 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, bool, System.Func&lt;T,System.IDisposable&gt;[]).disposables') based on the output of [observable](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__bool_System_Func_T_System_IDisposable___)_observable 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, bool, System.Func&lt;T,System.IDisposable&gt;[]).observable').  
```csharp
public static void AddObservable<T>(this System.Reactive.Disposables.CompositeDisposable disposables, System.IObservable<T> observable, bool null_nop, params System.Func<T,System.IDisposable>[] disposable_funcs);
```
#### Type parameters
<a name='TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__bool_System_Func_T_System_IDisposable___)_T'></a>
`T`  
The [observable](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__bool_System_Func_T_System_IDisposable___)_observable 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, bool, System.Func&lt;T,System.IDisposable&gt;[]).observable') type.
  
#### Parameters
<a name='TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__bool_System_Func_T_System_IDisposable___)_disposables'></a>
`disposables` [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable')  
The [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') to add/remove/replace the [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') to.
  
<a name='TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__bool_System_Func_T_System_IDisposable___)_observable'></a>
`observable` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[T](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__bool_System_Func_T_System_IDisposable___)_T 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, bool, System.Func&lt;T,System.IDisposable&gt;[]).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
The [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1') used to generate the [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') from [disposable_funcs](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__bool_System_Func_T_System_IDisposable___)_disposable_funcs 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, bool, System.Func&lt;T,System.IDisposable&gt;[]).disposable_funcs').
  
<a name='TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__bool_System_Func_T_System_IDisposable___)_null_nop'></a>
`null_nop` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines weather null values are added to the [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable'). Should be set to true to not add null values.
  
<a name='TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__bool_System_Func_T_System_IDisposable___)_disposable_funcs'></a>
`disposable_funcs` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__bool_System_Func_T_System_IDisposable___)_T 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, bool, System.Func&lt;T,System.IDisposable&gt;[]).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The functions used to generate the [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') form [observable](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__bool_System_Func_T_System_IDisposable___)_observable 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, bool, System.Func&lt;T,System.IDisposable&gt;[]).observable') values.
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
disposables
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
observable
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
disposable_funcs
  
<a name='TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable__bool)'></a>
## DisposableExtensions.AddObservable&lt;T&gt;(CompositeDisposable, IObservable&lt;T&gt;, Func&lt;T,IDisposable&gt;, bool) Method
Adds/removes/replaces an [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') to [disposables](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable__bool)_disposables 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, System.Func&lt;T,System.IDisposable&gt;, bool).disposables') based on the output of [observable](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable__bool)_observable 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, System.Func&lt;T,System.IDisposable&gt;, bool).observable').  
```csharp
public static void AddObservable<T>(this System.Reactive.Disposables.CompositeDisposable disposables, System.IObservable<T> observable, System.Func<T,System.IDisposable> disposable_func, bool null_nop=true);
```
#### Type parameters
<a name='TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable__bool)_T'></a>
`T`  
The [observable](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable__bool)_observable 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, System.Func&lt;T,System.IDisposable&gt;, bool).observable') type.
  
#### Parameters
<a name='TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable__bool)_disposables'></a>
`disposables` [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable')  
The [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') to add/remove/replace the [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') to.
  
<a name='TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable__bool)_observable'></a>
`observable` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[T](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable__bool)_T 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, System.Func&lt;T,System.IDisposable&gt;, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
The [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1') used to generate the [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') with [disposable_func](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable__bool)_disposable_func 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, System.Func&lt;T,System.IDisposable&gt;, bool).disposable_func').
  
<a name='TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable__bool)_disposable_func'></a>
`disposable_func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable__bool)_T 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, System.Func&lt;T,System.IDisposable&gt;, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The function used to generate the [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') form [observable](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable__bool)_observable 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, System.Func&lt;T,System.IDisposable&gt;, bool).observable') values.
  
<a name='TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable__bool)_null_nop'></a>
`null_nop` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Determines weather null values are added to [disposables](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable__bool)_disposables 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, System.Func&lt;T,System.IDisposable&gt;, bool).disposables'). The default is false.
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[disposables](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable__bool)_disposables 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, System.Func&lt;T,System.IDisposable&gt;, bool).disposables')
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[observable](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable__bool)_observable 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, System.Func&lt;T,System.IDisposable&gt;, bool).observable')
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[disposable_func](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable__bool)_disposable_func 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, System.Func&lt;T,System.IDisposable&gt;, bool).disposable_func')
  
<a name='TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable___)'></a>
## DisposableExtensions.AddObservable&lt;T&gt;(CompositeDisposable, IObservable&lt;T&gt;, Func&lt;T,IDisposable&gt;[]) Method
Adds/removes/replaces a [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') to [disposables](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable___)_disposables 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, System.Func&lt;T,System.IDisposable&gt;[]).disposables') based on the output of [observable](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable___)_observable 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, System.Func&lt;T,System.IDisposable&gt;[]).observable').  
Same as [AddObservable&lt;T&gt;(CompositeDisposable, IObservable&lt;T&gt;, bool, Func&lt;T,IDisposable&gt;[])](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__bool_System_Func_T_System_IDisposable___) 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, bool, System.Func&lt;T,System.IDisposable&gt;[])') with null_nop set to true, null values are not added to the [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable').  
```csharp
public static void AddObservable<T>(this System.Reactive.Disposables.CompositeDisposable disposables, System.IObservable<T> observable, params System.Func<T,System.IDisposable>[] disposable_funcs);
```
#### Type parameters
<a name='TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable___)_T'></a>
`T`  
The [observable](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable___)_observable 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, System.Func&lt;T,System.IDisposable&gt;[]).observable') type.
  
#### Parameters
<a name='TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable___)_disposables'></a>
`disposables` [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable')  
The [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') to add/remove/replace the [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') to.
  
<a name='TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable___)_observable'></a>
`observable` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[T](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable___)_T 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, System.Func&lt;T,System.IDisposable&gt;[]).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
The [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1') used to generate the [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') from [disposable_funcs](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable___)_disposable_funcs 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, System.Func&lt;T,System.IDisposable&gt;[]).disposable_funcs').
  
<a name='TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable___)_disposable_funcs'></a>
`disposable_funcs` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable___)_T 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, System.Func&lt;T,System.IDisposable&gt;[]).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The functions used to generate the [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') form [observable](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_AddObservable_T_(System_Reactive_Disposables_CompositeDisposable_System_IObservable_T__System_Func_T_System_IDisposable___)_observable 'TechNoir.Reactive.DisposableExtensions.AddObservable&lt;T&gt;(System.Reactive.Disposables.CompositeDisposable, System.IObservable&lt;T&gt;, System.Func&lt;T,System.IDisposable&gt;[]).observable') values.
  
  
<a name='TechNoir_Reactive_DisposableExtensions_DisposeWithComposite_T_(T_System_Reactive_Disposables_CompositeDisposable)'></a>
## DisposableExtensions.DisposeWithComposite&lt;T&gt;(T, CompositeDisposable) Method
Disposes [item](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_DisposeWithComposite_T_(T_System_Reactive_Disposables_CompositeDisposable)_item 'TechNoir.Reactive.DisposableExtensions.DisposeWithComposite&lt;T&gt;(T, System.Reactive.Disposables.CompositeDisposable).item') with [disposables](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_DisposeWithComposite_T_(T_System_Reactive_Disposables_CompositeDisposable)_disposables 'TechNoir.Reactive.DisposableExtensions.DisposeWithComposite&lt;T&gt;(T, System.Reactive.Disposables.CompositeDisposable).disposables').
```csharp
public static T DisposeWithComposite<T>(this T item, System.Reactive.Disposables.CompositeDisposable disposables)
    where T : System.IDisposable;
```
#### Type parameters
<a name='TechNoir_Reactive_DisposableExtensions_DisposeWithComposite_T_(T_System_Reactive_Disposables_CompositeDisposable)_T'></a>
`T`  
Must be a [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable').
  
#### Parameters
<a name='TechNoir_Reactive_DisposableExtensions_DisposeWithComposite_T_(T_System_Reactive_Disposables_CompositeDisposable)_item'></a>
`item` [T](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_DisposeWithComposite_T_(T_System_Reactive_Disposables_CompositeDisposable)_T 'TechNoir.Reactive.DisposableExtensions.DisposeWithComposite&lt;T&gt;(T, System.Reactive.Disposables.CompositeDisposable).T')  
The [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') to be disposed with [disposables](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_DisposeWithComposite_T_(T_System_Reactive_Disposables_CompositeDisposable)_disposables 'TechNoir.Reactive.DisposableExtensions.DisposeWithComposite&lt;T&gt;(T, System.Reactive.Disposables.CompositeDisposable).disposables').
  
<a name='TechNoir_Reactive_DisposableExtensions_DisposeWithComposite_T_(T_System_Reactive_Disposables_CompositeDisposable)_disposables'></a>
`disposables` [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable')  
The [System.Reactive.Disposables.CompositeDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.Reactive.Disposables.CompositeDisposable 'System.Reactive.Disposables.CompositeDisposable') to dispose [item](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_DisposeWithComposite_T_(T_System_Reactive_Disposables_CompositeDisposable)_item 'TechNoir.Reactive.DisposableExtensions.DisposeWithComposite&lt;T&gt;(T, System.Reactive.Disposables.CompositeDisposable).item').
  
#### Returns
[T](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_DisposeWithComposite_T_(T_System_Reactive_Disposables_CompositeDisposable)_T 'TechNoir.Reactive.DisposableExtensions.DisposeWithComposite&lt;T&gt;(T, System.Reactive.Disposables.CompositeDisposable).T')  
[item](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_DisposeWithComposite_T_(T_System_Reactive_Disposables_CompositeDisposable)_item 'TechNoir.Reactive.DisposableExtensions.DisposeWithComposite&lt;T&gt;(T, System.Reactive.Disposables.CompositeDisposable).item').
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[disposables](TechNoir_Reactive.md#TechNoir_Reactive_DisposableExtensions_DisposeWithComposite_T_(T_System_Reactive_Disposables_CompositeDisposable)_disposables 'TechNoir.Reactive.DisposableExtensions.DisposeWithComposite&lt;T&gt;(T, System.Reactive.Disposables.CompositeDisposable).disposables')
  
  
<a name='TechNoir_Reactive_DisposableWrapper_T_'></a>
## DisposableWrapper&lt;T&gt; Class
Class DisposableWrapper.  
Implements the [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  
Used to wrap an object which may or may not be [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable'). If the wrapped object is [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') it will be disposed when this is disposed.  
```csharp
public class DisposableWrapper<T> :
System.IDisposable
```
#### Type parameters
<a name='TechNoir_Reactive_DisposableWrapper_T__T'></a>
`T`  
Type of the wrapped object
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DisposableWrapper&lt;T&gt;  

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  
### Constructors
<a name='TechNoir_Reactive_DisposableWrapper_T__DisposableWrapper(T)'></a>
## DisposableWrapper&lt;T&gt;.DisposableWrapper(T) Constructor
Initializes a new instance of the [DisposableWrapper&lt;T&gt;](TechNoir_Reactive.md#TechNoir_Reactive_DisposableWrapper_T_ 'TechNoir.Reactive.DisposableWrapper&lt;T&gt;') class.  
```csharp
public DisposableWrapper(T wrapped);
```
#### Parameters
<a name='TechNoir_Reactive_DisposableWrapper_T__DisposableWrapper(T)_wrapped'></a>
`wrapped` [T](TechNoir_Reactive.md#TechNoir_Reactive_DisposableWrapper_T__T 'TechNoir.Reactive.DisposableWrapper&lt;T&gt;.T')  
The wrapped object.
  
  
### Fields
<a name='TechNoir_Reactive_DisposableWrapper_T___Disposable'></a>
## DisposableWrapper&lt;T&gt;._Disposable Field
The disposable  
```csharp
private IDisposable _Disposable;
```
#### Field Value
[System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')
  
### Properties
<a name='TechNoir_Reactive_DisposableWrapper_T__Disposed'></a>
## DisposableWrapper&lt;T&gt;.Disposed Property
Gets a value indicating whether this [DisposableWrapper&lt;T&gt;](TechNoir_Reactive.md#TechNoir_Reactive_DisposableWrapper_T_ 'TechNoir.Reactive.DisposableWrapper&lt;T&gt;') is disposed.  
```csharp
protected bool Disposed { get; set; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
`true` if disposed; otherwise, `false`.
  
<a name='TechNoir_Reactive_DisposableWrapper_T__Wrapped'></a>
## DisposableWrapper&lt;T&gt;.Wrapped Property
Gets the wrapped object.  
```csharp
public T Wrapped { get; }
```
#### Property Value
[T](TechNoir_Reactive.md#TechNoir_Reactive_DisposableWrapper_T__T 'TechNoir.Reactive.DisposableWrapper&lt;T&gt;.T')
The wrapped.
  
### Methods
<a name='TechNoir_Reactive_DisposableWrapper_T__Dispose()'></a>
## DisposableWrapper&lt;T&gt;.Dispose() Method
Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.  
```csharp
public void Dispose();
```

Implements [Dispose()](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable.Dispose 'System.IDisposable.Dispose')  
  
<a name='TechNoir_Reactive_DisposableWrapper_T__Dispose(bool)'></a>
## DisposableWrapper&lt;T&gt;.Dispose(bool) Method
Releases unmanaged and - optionally - managed resources.  
```csharp
protected virtual void Dispose(bool disposing);
```
#### Parameters
<a name='TechNoir_Reactive_DisposableWrapper_T__Dispose(bool)_disposing'></a>
`disposing` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` to release both managed and unmanaged resources; `false` to release only unmanaged resources.
  
  
#### See Also
- [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')
  
<a name='TechNoir_Reactive_Extensions'></a>
## Extensions Class
Class Extensions.  
Implements Trigger and FirstSampleTrigger observable operators.  
```csharp
public static class Extensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Extensions  
### Methods
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger_)'></a>
## Extensions.FirstSampleTrigger&lt;TResult,TTrigger&gt;(IObservable&lt;TResult&gt;, IObservable&lt;TTrigger&gt;) Method
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
  
To use the [source](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger_)_source 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;).source') should be an observable of the criteria, [trigger](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger_)_trigger 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;).trigger') should be a observable of lookup  
completion. Note that the type of the trigger is immaterial. Each time the operator emits a criteria a lookup should be initiated. In this  
way the UI will be updated as quickly as lookups can be performed.  
```csharp
public static System.IObservable<TResult> FirstSampleTrigger<TResult,TTrigger>(this System.IObservable<TResult> source, System.IObservable<TTrigger> trigger);
```
#### Type parameters
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger_)_TResult'></a>
`TResult`  
The type of the result.
  
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger_)_TTrigger'></a>
`TTrigger`  
The type of the trigger.
  
#### Parameters
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger_)_source'></a>
`source` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TResult](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger_)_TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
The source [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').
  
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger_)_trigger'></a>
`trigger` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TTrigger](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger_)_TTrigger 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;).TTrigger')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
The trigger [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').
  
#### Returns
[System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TResult](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger_)_TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
[System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').
  
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger__System_Collections_Generic_IEqualityComparer_TResult_)'></a>
## Extensions.FirstSampleTrigger&lt;TResult,TTrigger&gt;(IObservable&lt;TResult&gt;, IObservable&lt;TTrigger&gt;, IEqualityComparer&lt;TResult&gt;) Method
[FirstSampleTrigger&lt;TResult,TTrigger&gt;(IObservable&lt;TResult&gt;, IObservable&lt;TTrigger&gt;)](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger_) 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;)') overload.  
              
             Accepts an [System.Collections.Generic.IEqualityComparer&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1') allowing for custom comparison of source values to determine distinctness.  
             
```csharp
public static System.IObservable<TResult> FirstSampleTrigger<TResult,TTrigger>(this System.IObservable<TResult> source, System.IObservable<TTrigger> trigger, System.Collections.Generic.IEqualityComparer<TResult> comparer);
```
#### Type parameters
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger__System_Collections_Generic_IEqualityComparer_TResult_)_TResult'></a>
`TResult`  
The type of the result.
  
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger__System_Collections_Generic_IEqualityComparer_TResult_)_TTrigger'></a>
`TTrigger`  
The type of the trigger.
  
#### Parameters
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger__System_Collections_Generic_IEqualityComparer_TResult_)_source'></a>
`source` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TResult](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger__System_Collections_Generic_IEqualityComparer_TResult_)_TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;, System.Collections.Generic.IEqualityComparer&lt;TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
The source [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').
  
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger__System_Collections_Generic_IEqualityComparer_TResult_)_trigger'></a>
`trigger` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TTrigger](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger__System_Collections_Generic_IEqualityComparer_TResult_)_TTrigger 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;, System.Collections.Generic.IEqualityComparer&lt;TResult&gt;).TTrigger')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
The trigger [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').
  
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger__System_Collections_Generic_IEqualityComparer_TResult_)_comparer'></a>
`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TResult](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger__System_Collections_Generic_IEqualityComparer_TResult_)_TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;, System.Collections.Generic.IEqualityComparer&lt;TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')  
The [System.Collections.Generic.IEqualityComparer&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1') used to compare source values.
  
#### Returns
[System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TResult](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger__System_Collections_Generic_IEqualityComparer_TResult_)_TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;, System.Collections.Generic.IEqualityComparer&lt;TResult&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
[System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').
  
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey_)'></a>
## Extensions.FirstSampleTrigger&lt;TResult,TTrigger,TKey&gt;(IObservable&lt;TResult&gt;, IObservable&lt;TTrigger&gt;, Func&lt;TResult,TKey&gt;) Method
[FirstSampleTrigger&lt;TResult,TTrigger&gt;(IObservable&lt;TResult&gt;, IObservable&lt;TTrigger&gt;)](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger_) 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;)') overload.  
              
             Accepts an [source key selector](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2') allowing for comparison of source key values to determine distinctness.  
             
```csharp
public static System.IObservable<TResult> FirstSampleTrigger<TResult,TTrigger,TKey>(this System.IObservable<TResult> source, System.IObservable<TTrigger> trigger, System.Func<TResult,TKey> key_selector);
```
#### Type parameters
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey_)_TResult'></a>
`TResult`  
The type of the result.
  
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey_)_TTrigger'></a>
`TTrigger`  
The type of the trigger.
  
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey_)_TKey'></a>
`TKey`  
The type of the source key.
  
#### Parameters
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey_)_source'></a>
`source` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TResult](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey_)_TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger,TKey&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;, System.Func&lt;TResult,TKey&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
The source [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').
  
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey_)_trigger'></a>
`trigger` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TTrigger](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey_)_TTrigger 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger,TKey&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;, System.Func&lt;TResult,TKey&gt;).TTrigger')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
The trigger [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').
  
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey_)_key_selector'></a>
`key_selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey_)_TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger,TKey&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;, System.Func&lt;TResult,TKey&gt;).TResult')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TKey](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey_)_TKey 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger,TKey&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;, System.Func&lt;TResult,TKey&gt;).TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The [source key selector](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2') used to select source keys.
  
#### Returns
[System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TResult](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey_)_TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger,TKey&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;, System.Func&lt;TResult,TKey&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
[System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').
  
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey__System_Collections_Generic_IEqualityComparer_TKey_)'></a>
## Extensions.FirstSampleTrigger&lt;TResult,TTrigger,TKey&gt;(IObservable&lt;TResult&gt;, IObservable&lt;TTrigger&gt;, Func&lt;TResult,TKey&gt;, IEqualityComparer&lt;TKey&gt;) Method
[FirstSampleTrigger&lt;TResult,TTrigger,TKey&gt;(IObservable&lt;TResult&gt;, IObservable&lt;TTrigger&gt;, Func&lt;TResult,TKey&gt;)](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey_) 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger,TKey&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;, System.Func&lt;TResult,TKey&gt;)') overload.  
              
             Accepts an [System.Collections.Generic.IEqualityComparer&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1') allowing for custom comparison of source key values to determine distinctness.  
             
```csharp
public static System.IObservable<TResult> FirstSampleTrigger<TResult,TTrigger,TKey>(this System.IObservable<TResult> source, System.IObservable<TTrigger> trigger, System.Func<TResult,TKey> key_selector, System.Collections.Generic.IEqualityComparer<TKey> comparer);
```
#### Type parameters
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey__System_Collections_Generic_IEqualityComparer_TKey_)_TResult'></a>
`TResult`  
The type of the t result.
  
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey__System_Collections_Generic_IEqualityComparer_TKey_)_TTrigger'></a>
`TTrigger`  
The type of the t trigger.
  
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey__System_Collections_Generic_IEqualityComparer_TKey_)_TKey'></a>
`TKey`  
The type of the source key.
  
#### Parameters
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey__System_Collections_Generic_IEqualityComparer_TKey_)_source'></a>
`source` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TResult](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey__System_Collections_Generic_IEqualityComparer_TKey_)_TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger,TKey&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;, System.Func&lt;TResult,TKey&gt;, System.Collections.Generic.IEqualityComparer&lt;TKey&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
The source [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').
  
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey__System_Collections_Generic_IEqualityComparer_TKey_)_trigger'></a>
`trigger` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TTrigger](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey__System_Collections_Generic_IEqualityComparer_TKey_)_TTrigger 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger,TKey&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;, System.Func&lt;TResult,TKey&gt;, System.Collections.Generic.IEqualityComparer&lt;TKey&gt;).TTrigger')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
The trigger [System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').
  
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey__System_Collections_Generic_IEqualityComparer_TKey_)_key_selector'></a>
`key_selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey__System_Collections_Generic_IEqualityComparer_TKey_)_TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger,TKey&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;, System.Func&lt;TResult,TKey&gt;, System.Collections.Generic.IEqualityComparer&lt;TKey&gt;).TResult')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TKey](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey__System_Collections_Generic_IEqualityComparer_TKey_)_TKey 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger,TKey&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;, System.Func&lt;TResult,TKey&gt;, System.Collections.Generic.IEqualityComparer&lt;TKey&gt;).TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The [source key selector](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2') used to select source keys.
  
<a name='TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey__System_Collections_Generic_IEqualityComparer_TKey_)_comparer'></a>
`comparer` [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TKey](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey__System_Collections_Generic_IEqualityComparer_TKey_)_TKey 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger,TKey&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;, System.Func&lt;TResult,TKey&gt;, System.Collections.Generic.IEqualityComparer&lt;TKey&gt;).TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')  
The [System.Collections.Generic.IEqualityComparer&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1') used to compare source key values.
  
#### Returns
[System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TResult](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_FirstSampleTrigger_TResult_TTrigger_TKey_(System_IObservable_TResult__System_IObservable_TTrigger__System_Func_TResult_TKey__System_Collections_Generic_IEqualityComparer_TKey_)_TResult 'TechNoir.Reactive.Extensions.FirstSampleTrigger&lt;TResult,TTrigger,TKey&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;, System.Func&lt;TResult,TKey&gt;, System.Collections.Generic.IEqualityComparer&lt;TKey&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
[System.IObservable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1').
  
<a name='TechNoir_Reactive_Extensions_Trigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger_)'></a>
## Extensions.Trigger&lt;TResult,TTrigger&gt;(IObservable&lt;TResult&gt;, IObservable&lt;TTrigger&gt;) Method
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
<a name='TechNoir_Reactive_Extensions_Trigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger_)_TResult'></a>
`TResult`  
The type of the source observable.
  
<a name='TechNoir_Reactive_Extensions_Trigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger_)_TTrigger'></a>
`TTrigger`  
The type of the trigger observable.
  
#### Parameters
<a name='TechNoir_Reactive_Extensions_Trigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger_)_source'></a>
`source` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TResult](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_Trigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger_)_TResult 'TechNoir.Reactive.Extensions.Trigger&lt;TResult,TTrigger&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
The source observable.
  
<a name='TechNoir_Reactive_Extensions_Trigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger_)_trigger'></a>
`trigger` [System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TTrigger](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_Trigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger_)_TTrigger 'TechNoir.Reactive.Extensions.Trigger&lt;TResult,TTrigger&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;).TTrigger')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
The trigger observable.
  
#### Returns
[System.IObservable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')[TResult](TechNoir_Reactive.md#TechNoir_Reactive_Extensions_Trigger_TResult_TTrigger_(System_IObservable_TResult__System_IObservable_TTrigger_)_TResult 'TechNoir.Reactive.Extensions.Trigger&lt;TResult,TTrigger&gt;(System.IObservable&lt;TResult&gt;, System.IObservable&lt;TTrigger&gt;).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IObservable-1 'System.IObservable`1')  
IObservable<TResult>.
  
  
<a name='TechNoir_Reactive_RefCountSetResetDisposable'></a>
## RefCountSetResetDisposable Class
Class RefCountSetResetDisposable.  
  
Implements a reference count which manages a disposable. The first time the reference count is incremented by calling [Set()](TechNoir_Reactive.md#TechNoir_Reactive_RefCountSetResetDisposable_Set() 'TechNoir.Reactive.RefCountSetResetDisposable.Set()')  
a <em>Set</em> action is invoked if not null.  
  
Each time the [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') returned from [Set()](TechNoir_Reactive.md#TechNoir_Reactive_RefCountSetResetDisposable_Set() 'TechNoir.Reactive.RefCountSetResetDisposable.Set()') is disposed the reference count is decremented. Once decremented  
to zero the <em>Reset</em> action is invoked if not null.  
```csharp
public class RefCountSetResetDisposable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; RefCountSetResetDisposable  
### Constructors
<a name='TechNoir_Reactive_RefCountSetResetDisposable_RefCountSetResetDisposable(System_Action_System_Action)'></a>
## RefCountSetResetDisposable.RefCountSetResetDisposable(Action, Action) Constructor
Initializes a new instance of the [RefCountSetResetDisposable](TechNoir_Reactive.md#TechNoir_Reactive_RefCountSetResetDisposable 'TechNoir.Reactive.RefCountSetResetDisposable') class.  
```csharp
public RefCountSetResetDisposable(System.Action set, System.Action reset);
```
#### Parameters
<a name='TechNoir_Reactive_RefCountSetResetDisposable_RefCountSetResetDisposable(System_Action_System_Action)_set'></a>
`set` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Action to be performed when this is set the first time.
  
<a name='TechNoir_Reactive_RefCountSetResetDisposable_RefCountSetResetDisposable(System_Action_System_Action)_reset'></a>
`reset` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
Action to be performed when this is disposed the last time (when reference count == 0).
  
  
### Methods
<a name='TechNoir_Reactive_RefCountSetResetDisposable_Set()'></a>
## RefCountSetResetDisposable.Set() Method
Increments reference count. If reference count == 0 the <em>Set</em> action is invoked if not null.  
```csharp
public System.IDisposable Set();
```
#### Returns
[System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  
[System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') which should be disposed to decrement reference count.
  
  
