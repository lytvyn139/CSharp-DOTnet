<img src="https://upload.wikimedia.org/wikipedia/commons/thumb/7/7a/C_Sharp_logo.svg/800px-C_Sharp_logo.svg.png" alt="c#" width="200px" />

# C#
This is a headache! Why is C# strongly typed? One word: Performance Although loosely typed languages may be easier for the developer initially, it reduces performance because the computer has to worry about remembering types and how to store different values of different types. In addition, the computer now has to allocate extra space for each variable and it has to store them in such a way that the variable can hold any type of information. Because C# is strongly typed, it forces the developer to be more conscious about types and allows the computer to run more efficiently by allocating just enough space for each variable.

## Install MySQL Server on Manjaro 16.10
https://manjaro-tutorial.blogspot.com/2016/11/install-mysql-server-on-manjaro-1610.html

## Install MySQL Workbench on Manjaro 16.10
https://manjaro-tutorial.blogspot.com/2016/12/install-mysql-workbench-on-manjaro-1610.html

## Problem connecting to DB fix
```
sudo mysql -u root -p
CREATE USER 'admin'@'localhost' IDENTIFIED BY 'password';
GRANT ALL PRIVILEGES ON *.* TO 'admin'@'localhost' WITH GRANT OPTION;

```
now open MySQL Workbench edit the connection and change the root name to admin, and the password is will be: password

## VS Code extensions
C# ext by OmniSharp, C# extensions by jchannon

## Create first appp
```cs

dotnet new console -o CSharp-sandbox
dotnet new //to see all the variants
dotnet run //run the program

```

## Error fix
Process terminated. Couldn't find a valid ICU package installed on the system. Set the configuration flag System.Globalization.Invariant to true if you want to run with no globalization support.
```
dotnet run
#it will create bin/Debug folder
```
```cs
# /home/coding/dojo/09-c#/C_GIT/FirstCSharp/bin/Debug/CSharp-sandbox.template.json
{
  "runtimeOptions": {
    "tfm": "netcoreapp3.1",
    "framework": {
      "name": "Microsoft.NETCore.App",
      "version": "3.1.0"
    },
    "configProperties": {
      "System.Globalization.Invariant": true
    }
  }
}
```

## Declaring variables
All variables are objects in C#!!!
```cs
int FavoriteNumber = 3;
//int	Int32	An integer value between -2,147,483,648 and 2,147,483,647,	32-bits	

long ReallyLong = -9223372036854775;
//long	Int64	An integer between -9,223,372,036,854,775,808 and 9,223,372,036,854,775,807	64-bits	

short ReallyShort = 31323;
//short	Int16	An integer between -32,768 and 32,767	16-bits

float Flotty = 3.12;
//float	Single	A floating point number between -3.402823e38 and 3.402823e38	32-bits	3.14159f

double Average = 15.2;
//double	Double	A floating point number between -1.79769313486232e308 and 1.79769313486232e308. Allows more precision than a float.	64-bits

char Letter = 'x'; //one quoute '
//char	Char	One unicode character	16-bits

string Message = "Hello World!"; //double quoutes

bool LikesCSharp = true;
//bool	Boolean	A true or false value,8-bit
```

```cs
string place = "Coding Dojo";       //Interpolated string, note the $
string message = $"Hello {place}";  // Displaying final message
Console.WriteLine(message);
```

However we still won't be able to change a variable from one type to another...
```cs
SomeNumber = false;
SomeString = -33.33;
```

### Var
C# is also capable of inferring what type our variables are if we use the keyword var...
```cs
var SomeNumber = 5;
var SomeString = "Howdy Planet?";
```

## Conditionals `if / else if / else` as we've been used to in other languages.

```cs
int NumberOfLights = 4;
Console.WriteLine($"There are {NumberOfLights} lights!");
NumberOfLights = 1;
Console.WriteLine($"There are {NumberOfLights} lights!");
```

```cs
int numRings = 5;
if (numRings >= 5)
{
    Console.WriteLine("You are welcome to join the party");
}
else if (numRings > 2)
{
    Console.WriteLine($"Decent...but {numRings} rings aren't enough");
}
else
{
    Console.WriteLine("Go win some more rings");
}
```

```cs
int numRings = 5;
int numOfAllStarAppearances = 17;
if (numRings >= 5 || numOfAllStarAppearances > 3)
{
  Console.WriteLine("Welcome, you are truly a legend");
}
```
### Comparison Operators
pretty much the same syntax as in JS, but C# doesn't have === 

## Arrays
In C# we have to tell our arrays what type of data to expect...

```cs
// Declaring an array of length 5, initialized by default to all zeroes
int[] numArray = new int[5];

// For Arrays initialized this way, the length is determined by the size of the given data
int[] numArray2 = {1,2,3,4,6};

string[] foods = new string[4];
foods[0] = "bagels";
foods[1] = "cream cheese";
foods[4] = "smoked salmon";
foods[3] = "capers";
```
### Accessing Arrays

```cs
int[] arrayOfInts = {1, 2, 3, 4, 5};
Console.WriteLine(arrayOfInts[0]);    // The first number lives at index 0.
Console.WriteLine(arrayOfInts[1]);    // The second number lives at index 1.
Console.WriteLine(arrayOfInts[2]);    // The third number lives at index 2.
Console.WriteLine(arrayOfInts[3]);    // The fourth number lives at index 3.
Console.WriteLine(arrayOfInts[4]);    // The fifth and final number lives at index 4.
```

```cs
int[] arr = {1, 2, 3, 4};
Console.WriteLine($"The first number of the arr is {arr[0]}"); 
arr[0] = 8;
Console.WriteLine($"The first number of the arr is now {arr[0]}");
// The array has now changed!
```

```cs
static void Main(string[] args)
{
    Console.WriteLine("Hello World!");
    string[] Foods = new string[]{
            "bagels",
            "cream cheese",
            "smoked salmon",
            "capers"
            };
    Console.WriteLine(Foods);                    //System.String[]
    Console.WriteLine(String.Join(", ", Foods)); //bagels, cream cheese, smoked
                                                 //Console.WriteLine(String.Join(", ", Foods)); 
                                                 //first arg is separator 
}
```

### Iteration thru array

```cs
string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"};
for (int idx = 0; idx < myCars.Length; idx++)
{
    Console.WriteLine($"I own a {myCars[idx]}");
    /* 
    I own a Mazda Miata
    I own a Ford Model T
    I own a Dodge Challenger
    I own a Nissan 300zx
     */
}
```

## Multidimensional Arrays
```cs
// Multidimensional array declaration
// This example contains 3 arrays -- each of these is length 2 -- all initialized to zeroes.
int [,] array2D = new int[3,2];
// This is equivalent to:
//  int [,] array2D = new int[3,2]  {  { 0,0 }, { 0,0 }, { 0,0 } }; 
// This example has 2 large rows that each contain 3 arrays -- and each of those arrays is length 4.
int[,,] array3D = new int[2,3,4] 
    {
        {  { 45,1,16,17 }, { 4,47,21,68 }, { 21,28,32,76 }  },
        {  { 11,0,85,42 }, { 9,10,14,96 }, { 66,99,33,12 }  }
    };
// Directly accessing a multidimensional array
Console.WriteLine(array2D[0,1]);   // prints 0
Console.WriteLine(array3D[1,0,3]); // prints 42

```


## Lists
C# fortunately has a List we can store things in much like the array, and it is a good bit more flexible for us to use. In order to make use of this though, we will be needing to import something...

```cs
using System.Collections.Generic;
```
The syntax might look a bit strange at first, but we still need to let the List know what type of data it will hold...

```cs
using System.Collections.Generic;
 static void Main(string[] args)
        {
            List<int> Numbers = new List<int>() {
                1, 2, 3
            };
            Numbers.Add(4);
            Numbers.Add(5);
            Console.WriteLine(Numbers.Count); //5
            Console.WriteLine(String.Join(", ", Numbers)); //1,2,3,4,5
        }
```

### Iteration thru list

```cs
//Initializing an empty list of Motorcycle Manufacturers
List<string> bikes = new List<string>();
//Use the Add function in a similar fashion to push
bikes.Add("Kawasaki");
bikes.Add("Triumph");
bikes.Add("BMW");
bikes.Add("Moto Guzzi");
bikes.Add("Harley Davidson");
bikes.Add("Suzuki");
//Accessing a generic list value is the same as you would an array
Console.WriteLine(bikes[2]); //Prints "BMW"
Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");
```


```cs
//Using our array of motorcycle manufacturers from before
//we can easily loop through the list of them with a C-style for loop
//this time, however, Count is the attribute for a number of items.
Console.    WriteLine("The current manufacturers we have seen are:");
for (var idx = 0; idx < bikes.Count; idx++)
{
 Console.WriteLine("-" + bikes[idx]);
}
// Insert a new item between a specific index
bikes.Insert(2, "Yamaha");
//Removal from Generic List
//Remove is a lot like Javascript array pop, but searches for a specified value
//In this case we are removing all manufacturers located in Japan
bikes.Remove("Suzuki");
bikes.Remove("Yamaha");
bikes.RemoveAt(0); //RemoveAt has no return value however
//The updated list can then be iterated through using a foreach loop
Console.WriteLine("List of Non-Japanese Manufacturers:");
foreach (string manu in bikes)
{
 Console.WriteLine("-" + manu);
}

```
## Dictionaries
Once again, we'll need to make sure we've imported System.Collections.Generic but this time we also need to specify what the type of our key and value will be...
```cs
using System.Collections.Generic;
Dictionary<string, string> User = new Dictionary<string, string>();
User["name"] = "Example McExampleface";
User["email"] = "example@example.com";
```
```cs
        //<key, value>
Dictionary<string,string> profile = new Dictionary<string,string>();
//Almost all the methods that exists with Lists are the same with Dictionaries
profile.Add("Name", "Speros");
profile.Add("Language", "PHP");
profile.Add("Location", "Greece");
Console.WriteLine("Instructor Profile");
Console.WriteLine("Name - " + profile["Name"]);
Console.WriteLine("From - " + profile["Location"]);
Console.WriteLine("Favorite Language - " + profile["Language"]);
```

```cs
//The var keyword takes the place of a type in type-inference
foreach (var entry in profile)
{
    Console.WriteLine(entry.Key + " - " + entry.Value);
}
```


## Loops

### for
We can write loops just about how we might be used to from other languages...

```cs
for(int i=0; i<3; i++)
{
    Console.WriteLine(i); //0,1,2
}
```

```cs
foreach(string n in Name) 
{
  Console.WriteLine('This is from for each loop);
  Console.WriteLine(n);
}
```

If we want to loop over an Array or a List we can reference their sizes like so...

```cs
// array
for(int i=0; i<MyArray.Length; i++)
{
    Console.WriteLine(MyArray[i]);
}
// list
for(int i=0; i<MyList.Count; i++)
{
    Console.WriteLine(MyList[i]);
}
```

The thing to remember is that arrays have `Length` and that lists have `Count`. 
If we don't need to know about the index we could use the more convenient method called `foreach()`.

```cs 
foreach(int value in MyArray){
    Console.writeLine(value);
}
foreach(int value in MyList){
    Console.writeLine(value);
}
```

`foreach` will work just fine with both Arrays and Lists, in fact it'll work with any `IEnumerable` (we'll be discussing these later). 

### while
We can still write `while` loops too!

```cs
string input = "";
while(!input.Equals("uncle"))
{
    Console.WriteLine("Say uncle!");
    input = Console.ReadLine();
}
```
```cs
int i = 0; // initialization
while (i < 10) // condition
{
    Console.WriteLine("i = {0}", i);

    i++; // increment
}

```







### Equality vs. Identity
There is a difference between equality and identity. For example == checks whether the instances on the left and the right are equal. Two instances can be equal, but they don't need to have the same location in memory. You can check if two instances are one and the same and share the same memory location by using identity operators. The identity operator in C# is actually a method rather than a keyword and can be performed by invoking A.Equals(B) with A and B being the respective variables.

## Random
First off, to begin we need to create a random object.
```
Random rand = new Random();
```
### Next
The .Next method performs a mathematical operation on a seed value (the timestamp taken on construction affects the seed value) and producing a new pseudo-random value. The best way to produce consecutive random values is to continue to call the .Next method on the same Random instance. There are actually 3 versions of the .Next method (remember overloading?) and a .NextDouble method, explained below.

Method	Description
.Next()	Will return a 32-bit signed integer that is greater than or equal to 0 and less than MaxValue (a C# constant)
.Next(Int32)	Will return a 32-bit signed integer that is greater than or equal to 0 and less than the provided parameter
.Next(Int32, Int32)	Will return a 32-bit signed integer that is greater than or equal to the first parameter and less than the second parameter
.NextDouble()	Returns a random floating-point number that is greater than or equal to 0.0, and less than 1.0.

To generate 10 random values between 2 and 8 (2 inclusive, 8 exclusive), we can call .Next(2,8) in a for loop:
```cs
Random rand = new Random();
for(int val = 0; val < 10; val++)
{
    //Prints the next random value between 2 and 8
    Console.WriteLine(rand.Next(2,8));
}
```

## Type Casting

### Implicit Casting
Implicit casting allows us to directly convert a variable from one type to another as long as the conversion doesn't include any loss of information. This implicit casting therefore is valid when casting numerical values, specifically values of lower precision to higher precision. As you can see in the example, an int can be implicitly cast to a double, but the reverse would throw an error.
```cs
int IntegerValue = 65;
double DoubleValue = IntegerValue;
```

### Explicit Casting
If we want to cast from higher precision to lower, there would be a loss of information, so this type of conversion must be done explicitly.
```cs
double DoubleValue = 3.14159265358;
int IntegerValue = (int)DoubleValue;
// IntegerValue == 3
```
Explicit casting is used when we are absolutely certain that the cast is appropriate. If we were to cast using this method and it failed, our code would throw an error and break execution. This implementation of casting is interesting in that it can be used with any datatype as long as the cast is valid. Note however, that the majority of data types are not able to be converted with a simple type cast! For example a String cannot be changed into an Integer even if its value is "123" and a String of "true" cannot be converted to a Boolean.
```cs
double floatNum = 7.76; 
int num = floatNum;
//This will cause a compiler type-mismatch error!!
int num = (int)floatNum;
//Floating point to integer conversion truncates all numbers after the decimal
//As such num now evaluated to 7
 
int num = (int)"24";
// This, however, will not work as strings can not be type cast to int
```
If you wanted to do this, a method would be needed to remove the data stored in the type's memory space and reformat it for storage as the new type. Strings, luckily, are so common that a pre-defined method called ToString() already exists for all variables to convert them into strings. Strings themselves also have many predefined methods for returning different data-types.
```
//Converting an integer to a string
int num = 7;
string numAsString = num.ToString(); //Evaluates as "7"
```


## static

Any method that has the `static` keyword belongs to the class. What this means is that we won't have to make an instance of the class `Program` to be able to run a given method.

```cs
using System;

namespace HelloWorld 
{
    class Program 
    {
    
        static void Print1To255()
        {
            for(int i=0; i<256; i++)
            {
                Console.WriteLine(i);
            }
        }
  
        static void Main(string[] args)
        {
            Print1To255();
        }
    
    }
}
```

For now this will be a good way for us to structure our code. If we didn't include `static`, we would have to make an instance of `HelloWorld` in order to run `Print1To255()`.

```cs
HelloWorld hello1 = new HelloWorld();
hello1.Print1To255();
```
## Author
IURII LYTVYN
