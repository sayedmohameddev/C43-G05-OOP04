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

            public static Duration operator +(Duration d1, Duration d2)
            {
                int totalSeconds = d1.ToSeconds() + d2.ToSeconds();
                return new Duration(totalSeconds);
            }

            public static Duration operator +(int seconds, Duration d1)
            {
                int totalSeconds = d1.ToSeconds() + seconds;
                return new Duration(totalSeconds);
            }

            public static Duration operator -(Duration d1, Duration d2)
            {
                int totalSeconds = d1.ToSeconds() - d2.ToSeconds();
                return new Duration(totalSeconds);
            }

            public static Duration operator ++(Duration d)
            {
                int totalSeconds = d.ToSeconds() + 60;
                return new Duration(totalSeconds);
            }

            public static Duration operator --(Duration d)
            {
                int totalSeconds = d.ToSeconds() - 60;
                return new Duration(totalSeconds);
            }

            public static bool operator >(Duration d1, Duration d2)
            {
                return d1.ToSeconds() > d2.ToSeconds();
            }

            public static bool operator <(Duration d1, Duration d2)
            {
                return d1.ToSeconds() < d2.ToSeconds();
            }

            public static bool operator >=(Duration d1, Duration d2)
            {
                return d1.ToSeconds() >= d2.ToSeconds();
            }

            public static bool operator <=(Duration d1, Duration d2)
            {
                return d1.ToSeconds() <= d2.ToSeconds();
            }

            public static explicit operator DateTime(Duration d)
            {
                return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
            }

            private int ToSeconds()
            {
                return (Hours * 3600) + (Minutes * 60) + Seconds;
            }
        }

        static void Main(string[] args)
        {
            Duration D1 = new Duration(1, 10, 15);
            Duration D2 = new Duration(3600);
            Duration D3 = D1 + D2;
            Console.WriteLine(D3);

            D3 = D1 + 7800;
            Console.WriteLine(D3);

            D3 = 666 + D1;
            Console.WriteLine(D3);

            D3 = ++D1;
            Console.WriteLine(D3);

            D3 = --D2;
            Console.WriteLine(D3);

            D1 = D1 - D2;
            Console.WriteLine(D1);

            if (D1 > D2)
                Console.WriteLine("D1 is greater than D2");

            if (D1 <= D2)
                Console.WriteLine("D1 is less than or equal to D2");

            DateTime dateTime = (DateTime)D1;
            Console.WriteLine(dateTime);
        
    }
    }
}
