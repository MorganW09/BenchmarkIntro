``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
  DefaultJob : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT


```
|        Method |    N |       Mean |     Error |    StdDev |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------- |----- |-----------:|----------:|----------:|---------:|------:|------:|----------:|
| **RegularString** |  **100** |   **6.331 us** | **0.1222 us** | **0.1589 us** |   **5.6686** |     **-** |     **-** |   **23736 B** |
| StringBuilder |  100 |   2.981 us | 0.0700 us | 0.0719 us |   0.2365 |     - |     - |    1000 B |
| **RegularString** | **1000** | **292.629 us** | **4.2114 us** | **3.5167 us** | **680.6641** |     **-** |     **-** | **2849740 B** |
| StringBuilder | 1000 |  28.689 us | 0.5611 us | 0.5248 us |   2.1362 |     - |     - |    9096 B |
