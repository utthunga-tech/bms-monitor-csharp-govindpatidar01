using System;
using System.Diagnostics;
using BMS;
public class Checker
{
    static void ExpectTrue(bool expression) 
    {
        if(!expression) 
        {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression)
    {
        if(expression)
        {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }

    static int Main() 
    {
        var btr =InitalizeBattery(25,0,45,70, 20,80,0.07f, 0.8f);
        ExpectTrue(btr.BatteryIsOk());

        var btr1 = InitalizeBattery(50, 0, 45, 85, 20, 80, 0.07f, 0.0f);
        ExpectFalse(btr1.BatteryIsOk());
        
        Console.WriteLine("All ok");
        return 0;
    }

    static Battery InitalizeBattery(float temp, float tempMin, float tempMax, float soc,  float socMin, float socMax,float cr,  float crMax) 
    {
        Battery btr = new Battery(temp, soc, cr);
        btr.TemperatureMin = tempMin;
        btr.TemperatureMax = tempMax;
        btr.SocMin = socMin;
        btr.SocMax = socMax;
        btr.ChargeRateMax = crMax;
        return btr;
    }
}