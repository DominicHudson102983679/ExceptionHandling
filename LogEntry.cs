using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    class LogEntry
    {
        public string room;
        public string name;
        public int duration;
        public DateTime time;
        public DateTime date;

        public LogEntry()
        {
            this.room = "AAA111";
            this.name = "Dominic";
            this.date = new DateTime();
            this.time = new DateTime();       
            this.duration = 300;
        }
    }
}
