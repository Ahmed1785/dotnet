﻿using System;
using static inheirtance.Vehicle;

namespace inheirtance
{
    public class Program
{
    public static void Main(string[] args)
    {
        Car oldCar = new Car(167263);
        Console.WriteLine($"Car Condition: {oldCar.Condition}");
        Console.WriteLine($"Max occupancy: {oldCar.NumPassengers}");
        oldCar.Move(6);
        Console.WriteLine($"Current Milage: {oldCar.Distance} miles");
        Car myCar = new Car();
        //Remember there are different forms of string construction
        //but they all accomplish the same goal so it is simply preference
        Console.WriteLine($"Car Condition: {myCar.Condition}");
        Console.WriteLine("Max occupancy: {0}", myCar.NumPassengers);
        myCar.Move(26.6);
        Console.WriteLine("Current Milage: " + myCar.Distance + " miles");
    }
}
}

