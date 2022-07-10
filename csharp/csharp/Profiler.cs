using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace csharp
{
    internal class Profiler
    {
        /// <summary>
        /// Profiles how long it takes for a function to run and prints the elapsed milliseconds.
        /// You can choose to run the profiler twice against the function to see the speed once the jit compiler is taken out of the profile.
        /// </summary>
        /// <param name="f">function to profile</param>
        /// <param name="fDescription">description of the function to profile (used during results printing)</param>
        /// <param name="runTwice">whether to run the profiler twice against the function</param>
        public static void ProfileFunction(Action f, string fDescription = "", bool runTwice = false)
        {
            if (runTwice) ProfileFunction(f, fDescription, false);

            var sw = new Stopwatch();
            sw.Start();
            f();
            sw.Stop();

            Console.WriteLine($"Function call ({fDescription}) took - {sw.Elapsed.TotalMilliseconds} ms - to complete " 
                + (runTwice ? "after jit compilation" : "with jit compilation"));
        }


        /// <summary>
        /// Dummy function to demo the profiler.
        /// Loops n number of times and increments a counter.
        /// </summary>
        /// <param name="n">number of times to loop the incrementer</param>
        public static void LoopIncrementerDemo(int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                count++;
            }
        }
    }
}
