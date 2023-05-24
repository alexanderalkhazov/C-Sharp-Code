// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Pattern Matching : 

// Pattern matching is a technique where
// you test an expression to determine if it has certain characteristics.

// C# pattern matching provides more concise syntax for
// testing expressions and taking action when an expression matches.

// The "is expression" supports pattern matching to test an expression
// and conditionally declare a new variable to the result of that expression.

// The "switch expression" enables you to perform actions based on the first matching pattern for an expression.
// These two expressions support a rich vocabulary of patterns.




                        // NULL checks  .
int? maybe = 12;

                      // we check and assign here.!!!.
if (maybe is int number)
{
	Console.WriteLine($"The nullable int 'maybe' has the value {number}");
}
else
{
	Console.WriteLine("The nullable int 'maybe' doesn't hold a value");
}

Console.ReadLine();



                       // check if string is null 
string? message = "This is not the null string";

if (message is not null)
{
	Console.WriteLine(message);
}

Console.ReadLine();



                         // Type tests
List<int> aa = new List<int>() {1,2,3,4,5,67,8,9 };

MidPoint<int>(aa);

 static T MidPoint<T>(IEnumerable<T> sequence)
 {
	if (sequence is IList<T> list)
	{
		return list[list.Count / 2];
	}
	else if (sequence is null)
	{
		throw new ArgumentNullException(nameof(sequence), "Sequence can't be null.");
	}
	else
	{
		int halfLength = sequence.Count() / 2 - 1;
		if (halfLength < 0) halfLength = 0;
		return sequence.Skip(halfLength).First();
	}
 }


