using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Exercise2
{
    internal class Display
    {
        public void ShowTemprature(object? obj , TempArgs args)
        {
            Console.WriteLine($"The temprature is {args.Temperature} from display");
        }
    }
}
