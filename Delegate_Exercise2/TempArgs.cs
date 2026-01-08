using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Exercise2
{
    internal class TempArgs :EventArgs
    { 
        public int Temperature {  get; set; }

        public TempArgs(int Temp)
        {
            Temperature = Temp;
        }

    }
}
