using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulseCheck.Performance
{
    public static class Extensions
    {
        public static double GetExecutionTime(this Action action)
        {
            var stopwatch = new System.Diagnostics.Stopwatch();

            GC.Collect();
            GC.WaitForPendingFinalizers();

            stopwatch.Start();
            action();
            stopwatch.Stop();

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public static double GetAverageExecutionTime(this Action action, int iterations)
        {
            action.GetExecutionTime(); //ignore the first run execution time

            double total = 0.0;
            for (int i = 0; i < iterations; i++)
            {
                total += action.GetExecutionTime(); 
            }

            return total / iterations;
        }
    }
}
