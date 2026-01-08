using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Exercise2
{
    internal class Sensor
    {
        public event EventHandler<TempArgs> SensorChanged;
        private int CurrentTemperature { get; set; }

        public void ChangeTemperature(int NewTempratue)
        {
            CurrentTemperature = NewTempratue;
            SensorChanged.Invoke(this,new TempArgs (NewTempratue));
        }
    }
}
