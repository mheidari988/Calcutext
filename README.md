# Calcutext

Calcutext is a robust calculator that not only performs basic mathematical operations, but also generates simple mathematical formulas and natural language expressions. As an example, let's consider the Summation operation.

```csharp
var sum = new Sum(5.2, 1.5);
Console.WriteLine(sum.ToResult()); // Output: 6.7
Console.WriteLine(sum.Print()); // Output: (5.2 + 1.5) = 6.7
Console.WriteLine(sum.PrintSentence()); // Output: sum of 5.2 and 1.5 is 6.7
```

Currently, Calcutext offers six distinct mathematical operations, including Summation, Multiplication, Division, Subtraction, Faculty, and Fractions. However, the capabilities of the calculator can be expanded by incorporating additional operations as needed.

## Features

One of the key features of Calcutext is the ability to use each class in combination with other operations to generate a wide range of formulas. For example, the Summation operation can be utilized in conjunction with Multiplication, Division, Subtraction, Faculty, and Fractions to create a variety of complex mathematical expressions.

```csharp
var sum = new Sum(new Multiplication(2, 2), new Subtraction(5, new Faculty(2)));

Console.WriteLine(sum.ToResult()); 
// Output: 7

Console.WriteLine(sum.Print()); 
// Output: ((2 * 2) + (5 - (2!)) = 7

Console.WriteLine(sum.PrintSentence()); 
// Output: sum of multiplication of 2 and 2 and subtraction of 5 and faculty of 2 is 7
```

## Implementation

In order to maintain a high degree of simplicity, Calcutext has been implemented using two levels of abstraction. The primary abstraction is the IOperation interface, which is implemented by the Operation abstract class. All other classes related to specific mathematical operations inherit from the Operation class, thus adhering to the IOperation interface. This implementation approach enables a clear separation of concerns, while still allowing for flexibility in extending the calculator's functionality through the implementation of additional operation classes.


```csharp
public interface IOperation
{
    Func<string> Printable { get; set; }
    Func<string> PrintableSentence { get; set; }
    double ToResult();
}
```
```csharp
public abstract class Operation : IOperation
{
    public Func<string> Printable { get; set; } = () => string.Empty;
    public Func<string> PrintableSentence { get; set; } = () => string.Empty;
    protected double LeftValue { get; set; }
    protected double RightValue { get; set; }
    public abstract double ToResult();
    public virtual string Print() => $"{Printable.Invoke()} = {ToResult()}";
    public virtual string PrintSentence() => PrintableSentence.Invoke() + " is " + ToResult();
}
```


## Tests

The following is a unit test that verifies the logic of the PrintSentence() method based on the implementation of different classes in Calcutext:

```csharp
[Fact]
public void Should_Return_Correct_PrintSentence_For_Complex_Inputs()
{
    // Arrange
    var sum = new Sum(new Multiplication(2, 3), new Division(4, 5));
    var divition = new Division(30, new Sum(2, 3));
    var multiplication = new Multiplication(new Fraction(9, 4), new Fraction(2, 3));

    // Act
    var sumResult = sum.PrintSentence();
    var divitionResult = divition.PrintSentence();
    var multiplicationResult = multiplication.PrintSentence();

    // Assert
    sumResult.Should().Be($"{Sum.OperationName} {Multiplication.OperationName} 2 and 3 and {Division.OperationName} 4 by 5 is 6.8");
    divitionResult.Should().Be($"{Division.OperationName} 30 by {Sum.OperationName} 2 and 3 is 6");
    multiplicationResult.Should().Be($"{Multiplication.OperationName} 9/4 and 2/3 is 1.5");
}
```

This test creates three different mathematical expressions using a combination of different classes such as Sum, Multiplication, Division, Fraction , which implement the IOperation interface. The test then invokes the PrintSentence() method on each of these expressions and verifies that the returned string is as expected by comparing it to a hardcoded string. This test thus ensures that the logic of the PrintSentence() method is correctly implemented for complex inputs.

## How to run

To run the Calcutext application, you will need to first download or clone the solution from the source repository. Once you have obtained the source code, you will need to build it using your preferred development environment.

Once the solution is built, you can select the Calcutext.UI project as the startup project and run the application. This will launch a simple console application, where you can see the results in both numerical form as well as natural language expressions.
