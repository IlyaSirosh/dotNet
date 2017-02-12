using System;
using ClimateCtrl;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ClimateControl cc = new ClimateControl();
            Thermometer t = new Thermometer();

            cc.connect(t);

            cc.on();
            Console.WriteLine(cc);
            t.setTemperature(22);
            t.setTemperature(25);
            t.setTemperature(26);

            cc.setTemperature(21);
            Console.WriteLine(cc);

            t.setTemperature(22);
            t.setTemperature(25);
            t.setTemperature(26);

            cc.off();
            Console.WriteLine(cc);
        }
    }
}
