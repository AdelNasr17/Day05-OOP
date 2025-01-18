using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02_OOP
{
    internal class Duration
    {


        #region Properties
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        #endregion

        #region Constructors 
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;

        }


        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }
        #endregion


        // Overriding 
        public override string ToString()
        {
            return $" Hours : {Hours} ,Minutes : {Minutes} ,  Seconds : {Seconds}";
        }

        #region  Operators overloading :
        // D3 = D1 + D2
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration((d1.Hours * 3600) + (d1.Minutes * 60) + (d1.Seconds) + (d2.Hours * 3600) + (d2.Minutes * 60) + (d2.Seconds));
        }

        // D3 = D1 + 7800
        public static Duration operator +(Duration d1, int seconds)
        {
            return new Duration((d1.Hours * 3600) + (d1.Minutes * 60) + (d1.Seconds) + (seconds));
        }


        //D3 = 666 + D1
        public static Duration operator +(int seconds, Duration d1)
        {
            return new Duration((d1.Hours * 3600) + (d1.Minutes * 60) + (d1.Seconds) + (seconds));
        }


        // D3 = ++D1 (Increase One Minute)
        public static Duration operator ++(Duration m)
        {
            return new Duration(m.Hours, m.Minutes + 1, m.Seconds);
        }


        //D3 = --D2 (Decrease One Minute)
        public static Duration operator --(Duration m)
        {
            return new Duration(m.Hours, m.Minutes - 1, m.Seconds);
        }


        //D1= D1 -D2
        public static Duration operator -(Duration d1, Duration d2)
        {
            int TotalSecondOfd1 = (d1.Hours * 3600) + (d1.Minutes * 60) + (d1.Seconds);
            int TotalSecondOfd2 = (d2.Hours * 3600) + (d2.Minutes * 60) + (d2.Seconds);
            return new Duration(TotalSecondOfd1 - TotalSecondOfd2);
        }



        //If (D1>D2)
        public static bool operator >(Duration d1, Duration d2)
        {
            return ((d1.Hours * 3600) + (d1.Minutes * 60) + (d1.Seconds)) > ((d2.Hours * 3600) + (d2.Minutes * 60) + (d2.Seconds));
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return ((d1.Hours * 3600) + (d1.Minutes * 60) + (d1.Seconds)) < ((d2.Hours * 3600) + (d2.Minutes * 60) + (d2.Seconds));
        }



        //If (D1<=D2)
        public static bool operator <=(Duration d1, Duration d2)
        {
            return ((d1.Hours * 3600) + (d1.Minutes * 60) + (d1.Seconds)) <= ((d2.Hours * 3600) + (d2.Minutes * 60) + (d2.Seconds));
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return ((d1.Hours * 3600) + (d1.Minutes * 60) + (d1.Seconds)) >= ((d2.Hours * 3600) + (d2.Minutes * 60) + (d2.Seconds));
        }


        //DateTime Obj = (DateTime) D1
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(d.Hours, d.Minutes, d.Seconds);
        }

        #endregion



    }
}
