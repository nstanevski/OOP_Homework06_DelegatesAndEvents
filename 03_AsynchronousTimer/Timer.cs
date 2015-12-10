using System;
using System.Threading;

namespace _03_AsynchronousTimer
{
    class Timer
    {
        private readonly int totalTicks;

        public Action<string> OnTickAction { get; private set; }
        public int NumTicks { get; private set; }
        public int Interval { get; private set; } //in milliseconds
        

        public Timer(Action<string> onTickAction, int numTicks, int interval)
        {
            this.NumTicks = numTicks;
            this.totalTicks = numTicks;
            this.Interval = interval;
            this.OnTickAction = onTickAction;
        }

        public void Run()
        {
            //async. execution
            var backgroundThread = new Thread(this.ExecuteBackgroundThread);
            backgroundThread.Start();
        }

        private void ExecuteBackgroundThread()
        {
            while (this.NumTicks > 0)
            {
                Thread.Sleep(this.Interval);
                String message = String.Format("Timer performed {0} of {1} ticks. Interval {2} milliseconds",
                    this.totalTicks - this.NumTicks + 1, this.totalTicks, this.Interval);
                this.OnTickAction(message);
                this.NumTicks--;
            }
        }
    }
}
