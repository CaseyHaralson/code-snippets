using System;

namespace csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# snippets!\n\n");

            Console.WriteLine("Console arguments example:");
            Console.WriteLine(args.Length + " console arguments");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(i + ": " + args[i]);
            }
            Console.WriteLine("\n\n");


            Console.WriteLine("Profiler example:");
            Profiler.ProfileFunction(() => Profiler.LoopIncrementerDemo(10000), "Loop Incrementer Demo", true);



            Console.WriteLine("\n\n");
        }
    }
}
