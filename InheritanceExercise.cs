using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalTest
{
    //TODO: Inheritance Exercise: Add inheritance hierarchy here


    public class InheritanceExercise
    {
        public void Execute()
        {
            Console.WriteLine("\nInheritance Exercise:");

            //----------------------------------------------------------------------------------------------------------
            // Exercise: This exercise has 3 parts:
            //              1. Create a class hierarchy with 1 base class and 2 derived classes.
            //                  1 Base class: Vehicle
            //                      The base class has 2 members, Name (string) and Cost (decimal).
            //                      The base class also has one abstract member, NumWheels (int).
            //                      The base class also has one calculated member, CostPerWheel (decimal).
            //                      CostPerWheel = Cost / NumWheels
            //                      Finally, the base class has a contstructor that takes name and cost.
            //                  2 Derived classes: Car and Bike.  
            //                      Each should have a constructor and an override of the abstract member, assigning
            //                      the appropriate number of wheels (Car = 4, Bike = 2).
            //
            //              2. Create and initialize a list of type Vehicle that contains the following 4 vehicles with
            //                  the given names and costs:
            //
            //                  Car:  Buick   $35000
            //                  Car:  Audi    $55000
            //                  Bike: Schwinn $75
            //                  Bike: Trek    $550
            //
            //              3. Loop through the list of vehicles in Name order and print out the following information
            //                  for each vehicle.  Be sure to format cost as currency.
            //                      <Name>:<CostPerWheel>
            //                  Example:
            //                      Buick:$8,750.00
            //

            Vehicle[] vehicles = {new Car("Buick", 35000), new Car("Audi", 55000), new Bike("Scwinn", 75), new Bike("Trek", 550)};

            foreach(Vehicle veh in vehicles)
            {
                Console.WriteLine("{0}:{1:C}", veh.Name, veh.CostPerWheel);
            }

        }
    }
}

public abstract class Vehicle
{
    private string name;
    public string Name
    {
        set{name = value;} 
        get{return name;}
    }
    private decimal cost;
    public decimal Cost
    {   
        set{cost = value;} 
        get{return cost;}
    }
    public abstract int NumWheels{get;}
    public decimal CostPerWheel{get => Cost / NumWheels;}

    public Vehicle(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
    }

}

public class Car : Vehicle
{
    private string name;

    private decimal cost;
    public override int NumWheels 
    {
        get {return 4;}
    }

    public Car(string name, decimal cost) : base(name, cost)
    {
        this.name = name;
        this.cost = cost;
    }
}

public class Bike : Vehicle
{
private string name;

    private decimal cost;
    public override int NumWheels 
    {
        get {return 2;}
    }

    public Bike(string name, decimal cost) : base(name, cost)
    {
        this.name = name;
        this.cost = cost;
    }
}