using Chronometer.Contracts;
using System;

namespace Chronometer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            IChronometer chronometer = new Chronometer();

            while ((input = Console.ReadLine()) != "exit")
            {
                switch (input)
                {
                    case "start":
                        chronometer.Start();
                        break;

                    case "stop":
                        chronometer.Stop();
                        break;

                    case "reset":
                        chronometer.Reset();
                        break;

                    case "lap":
                        chronometer.Lap();
                        Console.WriteLine(chronometer);
                        break;

                    case "time":
                        Console.WriteLine(chronometer);
                        break;

                    case "laps":
                        if (chronometer.Laps.Count < 1)
                        {
                            Console.WriteLine($"Laps: no laps");
                        }
                        else
                        {
                            int count = 0;

                            foreach (var lap in chronometer.Laps)
                            {
                                Console.WriteLine($"{count++}.{lap}");
                            }
                        }

                        break;
                }

            }
        }
    }
}
