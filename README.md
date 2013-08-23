http://tech.pro/blog/1293/c-performance-benchmark-mistakes-part-one
http://tech.pro/tutorial/1295/c-performance-benchmark-mistakes-part-two
http://tech.pro/tutorial/1317/c-performance-benchmark-mistakes-part-three
http://tech.pro/tutorial/1433/performance-benchmark-mistakes-part-four

"Mistake #1: Choosing a bad metric."
His Answer: "Average Execution Time"

"Mistake #2: Over-focusing on subsystem performance at the expense of end-to-end performance."
Usually we are optimizing subsystems because we need to maximize performance in a bottleneck area. This one is hard to enforce at a code level.

"Mistake #3: Running your benchmark in the debugger."
"Mistake #4: Benchmarking the debug build instead of the release build."

"Mistake #5: Using a clock instead of a stopwatch."

"Mistake #6: Treat the first run as nothing special when measuring average performance."

"Mistake #7: Assuming that runtime characteristics in one environment tell you what behavior will be in a different environment."

"Mistake #8: Forget to take garbage collection effects into account."