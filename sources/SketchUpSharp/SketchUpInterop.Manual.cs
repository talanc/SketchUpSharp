using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SketchUpSharp
{
    // adapted from corecrt_wtime.h
    public struct tm
    {
        public int tm_sec;   // seconds after the minute - [0, 60] including leap second
        public int tm_min;   // minutes after the hour - [0, 59]
        public int tm_hour;  // hours since midnight - [0, 23]
        public int tm_mday;  // day of the month - [1, 31]
        public int tm_mon;   // months since January - [0, 11]
        public int tm_year;  // years since 1900
        public int tm_wday;  // days since Sunday - [0, 6]
        public int tm_yday;  // days since January 1 - [0, 365]
        public int tm_isdst; // daylight savings time flag
    }
}
