using System;
using System.Collections.Generic;
namespace CSharp.InterfaceAndAbstractClass
{
    //  the IMovable interface 
    public interface IMovable
    {
        void Move();
        public void move2()
        {
            Console.WriteLine("Abc");
        }
    }

    // Abstract class Vehicle with a Name property
    public abstract class Vehicle
    {
        public string Name { get; }
        public Vehicle(string name)
        {
            Name = name;
        }
       
    }

    // Car class that inherits from Vehicle and implements IMovable
    public class Car : Vehicle, IMovable
    {
        public Car(string name) : base(name) { }

       
        public void Move()
        {
            Console.WriteLine($"The car is moving, and the name of the car is {Name}.");
        }
    }

    // Bicycle class that inherits from Vehicle and implements IMovable
    public class Bicycle : Vehicle, IMovable
    {
        public Bicycle(string name) : base(name) { }
        public void Move()
        {
            Console.WriteLine($"The bicycle is moving, and the name of the bicycle is {Name}.");
        }
    }

    class Program
    {
        public static void Run(string[] args)
        {

            Car car = new Car("BMW");
            car.Move();

            Bicycle bicycle = new Bicycle("Mountain Bike");
            bicycle.Move();
        }
    }
}
