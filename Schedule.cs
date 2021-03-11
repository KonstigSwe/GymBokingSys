using System;
using System.Collections.Generic;
using System.Text;

namespace GymBokingSys
{
    class Schedule
    {
        public Activity Activity;
        public List<TimeSlot> slots = new List<TimeSlot>();

        private int[] ts1 = { 8, 0 };
        private int[] ts2 = { 9, 0 };
        private int[] ts3 = { 10, 0 };
        private int[] ts4 = { 11, 0 };
        private int[] ts5 = { 12, 0 };
        private int[] ts6 = { 13, 0 };
        private int[] ts7 = { 14, 0 };
        private int[] ts8 = { 15, 0 };
        private int[] ts9 = { 16, 0 };
        private int[] dur = { 1, 0 };

        public Schedule(Activity activity)
        {
            this.Activity = activity;
            this.slots = new List<TimeSlot>();
        }

        public void NewScheduleDefault(Activity activity)
        {
            this.slots.Clear();
            this.Activity = activity;
            this.slots.Add(new TimeSlot(true, this.ts1, this.dur));
            this.slots.Add(new TimeSlot(true, this.ts2, this.dur));
            this.slots.Add(new TimeSlot(true, this.ts3, this.dur));
            this.slots.Add(new TimeSlot(true, this.ts4, this.dur));
            this.slots.Add(new TimeSlot(true, this.ts5, this.dur));
            this.slots.Add(new TimeSlot(true, this.ts6, this.dur));
            this.slots.Add(new TimeSlot(true, this.ts7, this.dur));
            this.slots.Add(new TimeSlot(true, this.ts8, this.dur));
            this.slots.Add(new TimeSlot(true, this.ts9, this.dur));
        }
        public void AddSlot(bool availability, int[] startTime, int[] duration)
        {
            this.slots.Add(new TimeSlot(availability, startTime, duration));
        }
        public void RemoveSlot(int index) 
        {
            this.slots.RemoveAt(index - 1);
        }
        public void SaveSchedule()
        {

        }
        public void ReadSchedule()
        {

        }
    }
    class TimeSlot
    {
        public bool _available;
        public int[] _startTime = new int[2];
        public int[] _duration = new int[2];
        public TimeSlot(bool available, int[] startTime, int[] duration)
        {
            this._available = available;
            this._startTime = startTime;
            this._duration  = duration;
        }
        public TimeSlot()
        {
            this._available = true;
            this._startTime = new int[] { 8, 0}; // Hours, minutes
            this._duration  = new int[]{ 0, 0 }; // Hours, minutes
        }
    }
}
