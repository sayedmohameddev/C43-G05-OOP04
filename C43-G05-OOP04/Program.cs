using System;

namespace C43_G05_OOP04
{
    internal class Program
    {

        class Duration
        {
            public int Hours { get; set; }
            public int Minutes { get; set; }
            public int Seconds { get; set; }

            public Duration(int hours, int minutes, int seconds)
            {
                Hours = hours;
                Minutes = minutes;
                Seconds = seconds;
            }

            public Duration(int totalSeconds)
            {
                Hours = totalSeconds / 3600; 
                totalSeconds %= 3600; 
                Minutes = totalSeconds / 60; 
                Seconds = totalSeconds % 60; 
            }

            public Duration(double minutes)
            {
                int totalSeconds = (int)(minutes * 60); 
                Hours = totalSeconds / 3600; 
                totalSeconds %= 3600; 
                Minutes = totalSeconds / 60; 
                Seconds = totalSeconds % 60; 
            }

            public override string ToString()
            {
                if (Hours > 0)
                {
                    return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
                }
                else
                {
                    return $"Minutes :{Minutes}, Seconds :{Seconds}";
                }
            }
        }

        static void Main(string[] args)
        {
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString()); 
            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());  

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());  
            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());
        }
    }
}
