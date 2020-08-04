# OOP

### The four principles of object-oriented programming are:
* encapsulation 
* abstraction
* inheritance
* polymorphism

### What are the benefits of OOP?
* Resuability
* Simplicity
* Easily Maintainable
* Security for Class Variables

Classes define 
* what objects we can build,
* how we can interact with them, 
* and how they themselves interact with our program. 
A simple way to look at classes is as a blueprint of functions and properties that we want as an instance of this class, AKA an Object, to hold. It may be easier to see as we begin working with them, so let's jump right into basic object creation.

```cs
//Program.cs
using System;
namespace OOP
{
    public class Vehicle
    {
        public int NumPassengers;
        //Notice the Constructor function doesn't need
        //a return type or the static keyword
        public Vehicle(int val)
        {
            NumPassengers = val;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            // Notice the type for the new object reference
            //Adding a value to the object; then passes it to the constructor
            Vehicle myVehicle = new Vehicle(7);
            Console.WriteLine($"My vehicle is holding {myVehicle.NumPassengers} people");
        }
    }
}

```
## Fields
Fields are variables that are declared within a class.  They may be of any type, for example, a Vehicle class may have MaxNumPassengers, Color, and MaxSpeed, each represented by a int, string, and double, respectively.
```cs
class Vehicle
{
    public int MaxNumPassengers;
    public string Color;
    public double MaxSpeed;
}
```

### Methods
Methods are functions that are declared within a class.  You must declare their return type, as well as the types of any input arguments.  Methods may be overloaded, meaning you may provide more than one method of the same name - provided each has different input arguments.  Invocation of an overloaded method is determined by the argument(s) you pass to the method call.
```cs
class Vehicle
{
    // vehicleObject.MakeNoise("HOOONK!") will invoke this one
    public void MakeNoise(string noise)
    {
    	Console.WriteLine(noise);
    }
    // vehicleObject.MakeNoise() will invoke this one
    public void MakeNoise()
    {
    	Console.WriteLine("BEEP!");
    }
}
```

### Properties
Properties allows you, to control how fields are retrieved and updated.
They appear as if they are a field, but behave more like a method.  They work by using two keywords, known as property accessors: get and set - each with separate code blocks that will either return or assign a value.  Typically properties are used to provide safety controls over your fields.  get  accessors (commonly referred to as getters) must return a value of the type declared by the property.  set accessors (or setters) make use of the value keyword which is determined by the right-hand value of a property assignment.  You may provide logic within your property's code blocks to control how values are returned/assigned.
```cs
class Vehicle
{
    public string ColorProp
    {
        get
        {
    	    // Simply referencing the property will invoke the "getter", such as:
    	    // Console.WriteLine(vehicleObject.ColorProp);
    	    // and will return the following:
    
            return $"This thing is {Color}";
        }
        set
        {
    	    // Assigning a value to a property, such as:
    	    // vehicleObject.ColorProp = "Blue";
    	    // will invoke the "setter", and the "value" keyword will become the assigned value
    	    // ("Blue" in this example)
    
            Color = value;
        }
    }
}
```