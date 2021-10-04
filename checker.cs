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
        Battery btr = new Battery(25, 70, 0.7f);
        ExpectTrue(btr.BatteryIsOk());
        Battery btr1 = new Battery(50, 85, 0.0f);
        ExpectFalse(btr1.BatteryIsOk());
        Console.WriteLine("All ok");
        return 0;
    }
}