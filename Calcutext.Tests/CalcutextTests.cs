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

    [Fact]
    public void Should_Return_Correct_ToResult_For_IOperation_Inputs()
    {
        // Arrange
        var leftMock = new Mock<IOperation>();
        var rightMock = new Mock<IOperation>();

        leftMock.Setup(x => x.ToResult()).Returns(4);
        rightMock.Setup(x => x.ToResult()).Returns(3.5);

        var sum = new Sum(leftMock.Object, rightMock.Object);
        var multiplication = new Multiplication(leftMock.Object, rightMock.Object);
        var division = new Division(leftMock.Object, rightMock.Object);
        var subtraction = new Subtraction(leftMock.Object, rightMock.Object);
        var faculty = new Faculty(leftMock.Object);
        var fraction = new Fraction(leftMock.Object, rightMock.Object);

        // Act
        var sumResult = sum.ToResult();
        var multiplicationResult = multiplication.ToResult();
        var divisionResult = division.ToResult();
        var subtractionResult = subtraction.ToResult();
        var facultyResult = faculty.ToResult();
        var fractionResult = fraction.ToResult();

        // Assert
        sumResult.Should().Be(4 + 3.5);
        multiplicationResult.Should().Be(4 * 3.5);
        divisionResult.Should().Be(4 / 3.5);
        subtractionResult.Should().Be(4 - 3.5);
        facultyResult.Should().Be(24);
        fractionResult.Should().Be(4 / 3.5);
    }

    [Fact]
    public void Should_Return_Correct_ToResult_For_double_And_IOperation_Inputs()
    {
        // Arrange
        var left = 4;
        var rightMock = new Mock<IOperation>();
        rightMock.Setup(x => x.ToResult()).Returns(3.5);

        var sum = new Sum(left, rightMock.Object);
        var multiplication = new Multiplication(left, rightMock.Object);
        var division = new Division(left, rightMock.Object);
        var subtraction = new Subtraction(left, rightMock.Object);
        var faculty = new Faculty(left);
        var fraction = new Fraction(left, rightMock.Object);


        // Act
        var sumResult = sum.ToResult();
        var multiplicationResult = multiplication.ToResult();
        var divisionResult = division.ToResult();
        var subtractionResult = subtraction.ToResult();
        var facultyResult = faculty.ToResult();
        var fractionResult = fraction.ToResult();

        // Assert
        sumResult.Should().Be(left + 3.5);
        multiplicationResult.Should().Be(left * 3.5);
        divisionResult.Should().Be(left / 3.5);
        subtractionResult.Should().Be(left - 3.5);
        facultyResult.Should().Be(24);
        fractionResult.Should().Be(left / 3.5);
    }

    [Fact]
    public void Should_Return_Correct_ToResult_For_IOperation_And_double_Inputs()
    {
        // Arrange
        var leftMock = new Mock<IOperation>();
        leftMock.Setup(x => x.ToResult()).Returns(4);
        var right = 3.5;
        var sum = new Sum(leftMock.Object, right);
        var multiplication = new Multiplication(leftMock.Object, right);
        var division = new Division(leftMock.Object, right);
        var subtraction = new Subtraction(leftMock.Object, right);
        var faculty = new Faculty(leftMock.Object);
        var fraction = new Fraction(leftMock.Object, right);


        // Act
        var sumResult = sum.ToResult();
        var multiplicationResult = multiplication.ToResult();
        var divisionResult = division.ToResult();
        var subtractionResult = subtraction.ToResult();
        var facultyResult = faculty.ToResult();
        var fractionResult = fraction.ToResult();

        // Assert
        sumResult.Should().Be(4 + right);
        multiplicationResult.Should().Be(4 * right);
        divisionResult.Should().Be(4 / right);
        subtractionResult.Should().Be(4 - right);
        facultyResult.Should().Be(24);
        fractionResult.Should().Be(4 / right);
    }

    [Fact]
    public void Should_Return_Correct_Print_For_double_Inputs()
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
        var sumResult = sum.Print();
        var multiplicationResult = multiplication.Print();
        var divisionResult = division.Print();
        var subtractionResult = subtraction.Print();
        var facultyResult = faculty.Print();
        var fractionResult = fraction.Print();

        // Assert
        sumResult.Should().Be("(4 + 3.5) = 7.5");
        multiplicationResult.Should().Be("(4 * 3.5) = 14");
        divisionResult.Should().Be("(4 / 3.5) = 1.1428571428571428");
        subtractionResult.Should().Be("(4 - 3.5) = 0.5");
        facultyResult.Should().Be("(4!) = 24");
        fractionResult.Should().Be("(4/3.5) = 1.1428571428571428");
    }

    [Fact]
    public void Should_Return_Correct_Print_For_IOperation_Inputs()
    {
        // Arrange
        var leftMock = new Mock<IOperation>();
        var rightMock = new Mock<IOperation>();
        leftMock.Setup(x => x.ToResult()).Returns(4);
        rightMock.Setup(x => x.ToResult()).Returns(3.5);
        leftMock.Setup(x => x.Printable).Returns(() => "4");
        rightMock.Setup(x => x.Printable).Returns(() => "3.5");
        var sum = new Sum(leftMock.Object, rightMock.Object);
        var multiplication = new Multiplication(leftMock.Object, rightMock.Object);
        var division = new Division(leftMock.Object, rightMock.Object);
        var subtraction = new Subtraction(leftMock.Object, rightMock.Object);
        var faculty = new Faculty(leftMock.Object);
        var fraction = new Fraction(leftMock.Object, rightMock.Object);


        // Act
        var sumResult = sum.Print();
        var multiplicationResult = multiplication.Print();
        var divisionResult = division.Print();
        var subtractionResult = subtraction.Print();
        var facultyResult = faculty.Print();
        var fractionResult = fraction.Print();

        // Assert
        sumResult.Should().Be("(4 + 3.5) = 7.5");
        multiplicationResult.Should().Be("(4 * 3.5) = 14");
        divisionResult.Should().Be("(4 / 3.5) = 1.1428571428571428");
        subtractionResult.Should().Be("(4 - 3.5) = 0.5");
        facultyResult.Should().Be("(4!) = 24");
        fractionResult.Should().Be("(4/3.5) = 1.1428571428571428");
    }

    [Fact]
    public void Should_Return_Correct_Print_For_Complex_Inputs()
    {
        // Arrange
        var sum = new Sum(new Multiplication(2, 3), new Division(4, 5));
        var divition = new Division(30, new Sum(2, 3));
        var multiplication = new Multiplication(new Fraction(9, 4), new Fraction(2, 3));

        // Act
        var sumResult = sum.Print();
        var divitionResult = divition.Print();
        var multiplicationResult = multiplication.Print();

        // Assert
        sumResult.Should().Be("((2 * 3) + (4 / 5)) = 6.8");
        divitionResult.Should().Be("(30 / (2 + 3)) = 6");
        multiplicationResult.Should().Be("((9/4) * (2/3)) = 1.5");
    }

    [Fact]
    public void Should_Return_Correct_PrintSentence_For_double_Inputs()
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
        var sumResult = sum.PrintSentence();
        var multiplicationResult = multiplication.PrintSentence();
        var divisionResult = division.PrintSentence();
        var subtractionResult = subtraction.PrintSentence();
        var facultyResult = faculty.PrintSentence();
        var fractionResult = fraction.PrintSentence();

        // Assert
        sumResult.Should().Be($"Sum of 4 and 3.5 is 7.5");
        multiplicationResult.Should().Be($"{Multiplication.OperationName} 4 and 3.5 is 14");
        divisionResult.Should().Be($"{Division.OperationName} 4 by 3.5 is 1.1428571428571428");
        subtractionResult.Should().Be($"{Subtraction.OperationName} 4 and 3.5 is 0.5");
        facultyResult.Should().Be($"{Faculty.OperationName} 4 is 24");
        fractionResult.Should().Be($"4/3.5 is 1.1428571428571428");
    }

    [Fact]
    public void Should_Return_Correct_PrintSentence_For_IOperation_Inputs()
    {
        // Arrange
        var mockLeftOp = new Mock<IOperation>();
        mockLeftOp.Setup(x => x.PrintableSentence).Returns(() => "LEFT_VALUE");
        mockLeftOp.Setup(x => x.ToResult()).Returns(10);

        var mockRightOp = new Mock<IOperation>();
        mockRightOp.Setup(x => x.PrintableSentence).Returns(() => "RIGHT_VALUE");
        mockRightOp.Setup(x => x.ToResult()).Returns(20);

        var sum = new Sum(mockLeftOp.Object, mockRightOp.Object);
        var multiplication = new Multiplication(mockLeftOp.Object, mockRightOp.Object);
        var division = new Division(mockLeftOp.Object, mockRightOp.Object);
        var subtraction = new Subtraction(mockLeftOp.Object, mockRightOp.Object);
        var faculty = new Faculty(mockLeftOp.Object);
        var fraction = new Fraction(mockLeftOp.Object, mockRightOp.Object);

        // Act
        var sumResult = sum.PrintSentence();
        var multiplicationResult = multiplication.PrintSentence();
        var divisionResult = division.PrintSentence();
        var subtractionResult = subtraction.PrintSentence();
        var facultyResult = faculty.PrintSentence();
        var fractionResult = fraction.PrintSentence();

        // Assert
        sumResult.Should().Be("Sum of LEFT_VALUE and RIGHT_VALUE is 30");
        multiplicationResult.Should().Be($"{Multiplication.OperationName} LEFT_VALUE and RIGHT_VALUE is 200");
        divisionResult.Should().Be($"{Division.OperationName} LEFT_VALUE by RIGHT_VALUE is 0.5");
        subtractionResult.Should().Be($"{Subtraction.OperationName} LEFT_VALUE and RIGHT_VALUE is -10");
        facultyResult.Should().Be($"{Faculty.OperationName} LEFT_VALUE is 3628800");
        fractionResult.Should().Be("LEFT_VALUE/RIGHT_VALUE is 0.5");
    }

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
        sumResult.Should().Be($"Sum of {Multiplication.OperationName} 2 and 3 and {Division.OperationName} 4 by 5 is 6.8");
        divitionResult.Should().Be($"{Division.OperationName} 30 by Sum of 2 and 3 is 6");
        multiplicationResult.Should().Be($"{Multiplication.OperationName} 9/4 and 2/3 is 1.5");
    }
}