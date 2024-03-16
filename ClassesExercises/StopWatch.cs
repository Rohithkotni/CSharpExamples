using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.ClassesExercises
{
        public class StopWatch
        {
            private  DateTime _startTime;
            private  DateTime _stopTime;
            private  TimeSpan _duration;
            int counter = 0;
            public DateTime StartTime()

            {
                _startTime = DateTime.Now;
                return _startTime;
            }

            public DateTime Stoptime()

            {
                _stopTime = DateTime.Now;
                return _stopTime;
            }

            public void Run()
            {
                while (true)

                {
                    Console.Write("Enter 1-Start Timer and 2-Stop Timer\n");
                    var input1 = Convert.ToInt32(Console.ReadLine());
                    if (input1 == 1)
                    {
                        _startTime = StartTime();
                        counter = 1;
                    }
                    else
                    {
                        throw (new InvalidOperationException("Please Start the timer with 1"));
                    }

                    Console.WriteLine("Please enter '2' to stop the timer whenever you want");
                    input1 = Convert.ToInt32(Console.ReadLine());
                    if (input1 == 2)
                    {
                    _stopTime = Stoptime();
                        counter = 0;

                    }

                    else
                    {
                        throw (new InvalidOperationException("Please end the timer with 2"));
                    }
                    if (counter == 1)
                    {
                        throw (new InvalidOperationException("Timer is already running."));
                    }
                   var duration = (_stopTime - _startTime).TotalSeconds;

                    if (duration > 60.0)
                    {
                        duration = (_stopTime - _startTime).TotalMinutes;
                        Console.WriteLine(duration + "m");
                    }
                    else
                    {

                        Console.WriteLine(duration + "s");
                    }

                }
            }
        }
    }
