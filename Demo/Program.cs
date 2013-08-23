using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PulseCheck.Performance;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new HashSet<int>();
            for (int i=0; i<50; i++)
                test.Add(i);

            Action intassign = () =>
            {
                var x = 55;
                x++;
            };

            Action floatassign = () =>
            {
                var x = 55.55;
                x += 1.0;
            };

            Console.WriteLine(intassign.GetAverageExecutionTime(10000));
            Console.WriteLine(floatassign.GetAverageExecutionTime(10000));
            Console.WriteLine(floatassign.GetAverageExecutionTime(10000));
            Console.WriteLine(intassign.GetAverageExecutionTime(10000));

            Console.Read();

        }
    }
}
