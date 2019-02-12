``` ini

BenchmarkDotNet=v0.11.3, OS=Windows 8.1 (6.3.9600.0)
Intel Core i5-4460 CPU 3.20GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
Frequency=3117784 Hz, Resolution=320.7406 ns, Timer=TSC
.NET Core SDK=2.1.401
  [Host]     : .NET Core 2.1.4 (CoreCLR 4.6.26814.03, CoreFX 4.6.26814.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.4 (CoreCLR 4.6.26814.03, CoreFX 4.6.26814.02), 64bit RyuJIT


```
|                     Method |          array |       Mean |      Error |     StdDev |
|--------------------------- |--------------- |-----------:|-----------:|-----------:|
|                &#39;Linq Sort&#39; | System.Int32[] |   148.6 us |  0.4246 us |  0.3972 us |
| &#39;Quicksort_rec on List&lt;T&gt;&#39; | System.Int32[] | 4,752.6 us | 18.5936 us | 17.3924 us |
| &#39;Mergesort_rec on List&lt;T&gt;&#39; | System.Int32[] |   138.9 us |  0.5978 us |  0.5592 us |
