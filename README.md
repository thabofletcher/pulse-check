Pulse Check
================

Unit Performance Benchmarking for .NET - simple extension methods based on Eric Lippert's best practices for benchmarking.

[Eric's Part 1](http://tech.pro/blog/1293/c-performance-benchmark-mistakes-part-one)

[Eric's Part 2](http://tech.pro/tutorial/1295/c-performance-benchmark-mistakes-part-two)

[Eric's Part 3](http://tech.pro/tutorial/1317/c-performance-benchmark-mistakes-part-three)

[Eric's Part 4](http://tech.pro/tutorial/1433/performance-benchmark-mistakes-part-four)


##Summary of article:

"Mistake #1: Choosing a bad metric." === Use Average Execution Time

"Mistake #2: Over-focusing on subsystem performance at the expense of end-to-end performance." 
This library doesn't really do end to end. Sorry. Usually I am optimizing subsystems because I need to maximize performance in a bottleneck area.

"Mistake #3: Running your benchmark in the debugger."

"Mistake #4: Benchmarking the debug build instead of the release build."

"Mistake #5: Using a clock instead of a stopwatch."

"Mistake #6: Treat the first run as nothing special when measuring average performance."
Use GetAverageExecutionTime(), which ignores first run performance. GetExectionTime() wil get first run performance if you want it.

"Mistake #7: Assuming that runtime characteristics in one environment tell you what behavior will be in a different environment."

"Mistake #8: Forget to take garbage collection effects into account."

##Nuget Package

    Install-Package PulseCheck

##Usage

    using PulseCheck.Performance;

    new Action(() => { }).GetAverageExecutionTime(1000);

See Program.cs in Demo for more.

##License

The MIT License (MIT)

Copyright (c) 2013 Thabo Fletcher

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
