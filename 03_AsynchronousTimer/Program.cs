using System;


namespace _03_AsynchronousTimer
{
    class Program
    {
        static void Main()
        {
            Action<string> onTickAction =
                (message) =>
                {
                    Console.WriteLine(message);
                };

            int numTicks = 30;
            int interval = 1500;

            Timer timer = new Timer(onTickAction, numTicks, interval);
            timer.Run(); 
        }
    }
}
