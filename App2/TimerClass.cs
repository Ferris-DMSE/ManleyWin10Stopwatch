using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace App2
{
    static class TimerClass
    {


        public static bool isRunning = false;
        public static Stopwatch MyStopwatch { get; set; }

        public static void Start()
        {
            if (!isRunning)
            {
                isRunning = true;
                MyStopwatch = new Stopwatch();
                MyStopwatch.Start();

            }
            else if (isRunning)
            {
                if (MyStopwatch != null && !MyStopwatch.IsRunning)
                {
                    MyStopwatch.Start();
                }
            }

        }

        public static void Pause()
        {
            if (isRunning)
            {
                MyStopwatch.Stop();
            }
        }

        public static void Stop()
        {
            isRunning = false;
            MyStopwatch.Reset();
        }



        public static string UpdateTimeLabel()
        {

            return MyStopwatch.Elapsed.ToString("hh\\:mm\\:ss\\:fff");
        }

    }
}
