using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Project_3
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Duration()
        {

        }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration( int seconds)
        {
            Hours = seconds / 3600;
            seconds = seconds % 3600;
            Minutes = seconds / 60;
            Seconds = seconds % 60;
        }
        public override string ToString()
        {
            return $"Duration: {Hours} Hours : {Minutes} Minutes : {Seconds} Seconds";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            Duration duration = (Duration) obj;
            return this.Hours == duration.Hours &&
                   this.Minutes == duration.Minutes &&
                   this.Seconds == duration.Seconds;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours,Minutes,Seconds);
        }
        public static Duration operator +(Duration d1,Duration d2)
        {
            return new Duration()
            {
                Hours = d1.Hours + d2.Hours,
                Minutes = d1.Minutes + d2.Minutes,
                Seconds = d1.Seconds + d2.Seconds
            };
        }
        public static Duration operator +(Duration d1, int second)
        {
            Duration d = new Duration(second);
            return new Duration()
            {
                Hours = d1.Hours +d.Hours,
                Minutes = d1.Minutes + d.Minutes,
                Seconds = d1.Seconds + d.Seconds
            };
        }
        

    }
}
