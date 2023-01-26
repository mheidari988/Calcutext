namespace Calcutext.Tests;

public class CalcutextTests
{
    [Fact]
    public void Should_Return_Correct_ToResult_For_double_Inputs()
    {
        // Arrange
        var left = 4;
        var right = 3.5;
        var sum = new Sum(left, right);
        var multiplication = new Multiplication(left, right);
        var division = new Division(left, right);
        var subtraction = new Subtraction(left, right);
        var faculty = new Faculty(left);
        var fraction = new Fraction(left, right);


        // Act
        var sumResult = sum.ToResult();
        var multiplicationResult = multiplication.ToResult();
        var divisionResult = division.ToResult();
        var subtractionResult = subtraction.ToResult();
        var facultyResult = faculty.ToResult();
        var fractionResult = fraction.ToResult();

        // Assert
        sumResult.Should().Be(left + right);
        multiplicationResult.Should().Be(left * right);
        divisionResult.Should().Be(left / right);
        subtractionResult.Should().Be(left - right);
        facultyResult.Should().Be(24);
        fractionResult.Should().Be(left / right);
    }
}