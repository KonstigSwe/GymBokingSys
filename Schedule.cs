using System;
using System.Collections.Generic;
using System.Text;

namespace GymBokingSys
{
    class Schedule
    {
        public Activity _activity;
        public List<TimeSlot> _slots = new List<TimeSlot>();
    }
    class TimeSlot
    {
        public bool _available;
        public DateTime _startTime;
        public int[] _duration = new int[2];
        public TimeSlot(bool available, DateTime startTime, int[] duration)
        {
            this._available = available;
            this._startTime = startTime;
            this._duration  = duration;
        }
        public TimeSlot()
        {
            this._available = true;
            this._startTime = DateTime.Now;
            this._duration  = new int[]{ 0, 0 };
        }
    }
}
