using System;
using System.Collections.Generic;
using System.Text;

namespace GymBokingSys
{
    class TimeSlot
    {
        public bool _available;
        public DateTime _startTime;
        public int[] _duration = new int[2];
        public Activity _activity;
        public TimeSlot(bool available, DateTime startTime, int[] duration, Activity activity)
        {
            this._available = available;
            this._startTime = startTime;
            this._duration  = duration;
            this._activity  = activity;
        }
    }
}
