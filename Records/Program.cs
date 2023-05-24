
Person person = new Person("Alex");

Pointy pointy = new Pointy(2);

Console.WriteLine(person);
Console.WriteLine(pointy);

Console.ReadLine();

public record Person (string s);
public record struct Pointy (int point);

// A record in C# is a class or struct that provides special
// syntax and behavior for working with data models.

// When to use records

// You want to define a data model that depends on value equality.
// You want to define a type for which objects are immutable.

