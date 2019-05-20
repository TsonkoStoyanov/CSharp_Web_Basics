using Chronometer.Contracts;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Chronometer
{
    public class Chronometer : IChronometer
    {
        private long milliseconds;
        private bool isRunning;

        public Chronometer()
        {
            this.Reset();
        }


        public List<string> Laps { get; private set; }

        public string GetTime => $"{milliseconds / 60000:D2}:{milliseconds / 1000:D2}:{milliseconds % 1000:D4}";

        public string Lap()
        {

            string currentLap = GetTime;
            this.Laps.Add(currentLap);

            return currentLap;
        }

        public void Reset()
        {
            this.Stop();
            this.milliseconds = 0;
            this.Laps = new List<string>();
            
        }

        public void Start()
        {
            this.isRunning = true;

            Task.Run(() =>
            {
                while (this.isRunning)
                {
                    Thread.Sleep(1);
                    this.milliseconds++;
                }
            });

        }

        public void Stop()
        {
            isRunning = false;
        }


        public override string ToString()
        {
            return GetTime;
        }
    }
}
