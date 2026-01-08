using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Exercise2
{
    internal class Alarm
    {
        private int AlarmValue { get; set; }
        public Alarm(int alarmvalue)
        {
            AlarmValue = alarmvalue;
        }

        public void SetAlarmValue(int alarm)
        {
            AlarmValue = alarm;
        }

        public void FireAlarm(object? obj , TempArgs args)
        {
            if (args.Temperature>AlarmValue)
            {
                Console.WriteLine($"Take care, The temperature value {args.Temperature} is grater than {AlarmValue} ");
            }
        }
    }
}
