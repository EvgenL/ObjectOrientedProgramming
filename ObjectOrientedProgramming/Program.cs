using ObjectOrientedProgramming;
using ObjectOrientedProgramming.DzExample;


// ClassExample.Test();
// GettersExample.Test();
// PropertyExample.Test();
// InheritanceExample.Test();
// UpCastEncapsulationExample.Test();



// var cd = new ConsoleDrawer();
// ConsoleDrawer.Number = 10;
//
// SettersExample.Test();
//
// ConsoleDrawer.DrawNumber();


// var car = new Car();
// // var plane = new Airplane();
// var ship = new Ship();
// ship.Move();

// car.Move();
// plane.Move();
// ship.Move();


// Transport controlledTransport = null;
//
// controlledTransport = car;
// controlledTransport.Move();
//
// controlledTransport = plane;
// controlledTransport.Move();
//
// controlledTransport = ship;
// controlledTransport.Move();

// Это нельзя делать в статически типизированном языке.
// int a = 42;
// a = "Hello";




// var ship = new Ship
// {
//     Size = 1,
//     Color = "Red",
//     Weight = 999
// };

// Data Transfer Object

var ship = new Ship();
ship.Size = 1;
ship.Color = "Red";
ship.Weight = 999;

// var ship = new Ship(1, 999, "Red");


const int Radiant = 0;
const int Dire = 1;
const int Netural = 2;


// Team t = Team.Radiant;
int t = 1;

if (t == Radiant)
{
    Console.WriteLine("Radiant victory");
}
else if (t == Dire)
{
    Console.WriteLine("Dire victory");
}

public enum Team
{
    Radiant, // 0
    Dire,   // 1
    Netural  // 2
}