using System;
using System.Collections.Generic;
using System.Text;

namespace GymBokingSys
{
    class Schedule
    {
        public int _timeBooked { get; private set; }
        public int _duration { get; private set; }
        public string _bookedBy { get;  private set; }
        public string employeename { get; private set; }
        public static List<Schedule> ScheduleList = new List<Schedule>();
        public Schedule(int timeBooked,int duration, string bookedby, string enploynam)
        {
            this._timeBooked = timeBooked;
            this._duration = duration;
            this._bookedBy = bookedby;
            this.employeename = enploynam;
        }
    }
}
