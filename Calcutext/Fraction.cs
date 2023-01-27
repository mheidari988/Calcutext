namespace Calcutext;
public class Fraction : Operation
{
    public const string OperationSymbol = "/";
    
    public Fraction(double Numerator, double Denominator)
    {
        LeftValue = Numerator;
        RightValue = Denominator;
        Printable = () => $"({Numerator}{OperationSymbol}{Denominator})";
        PrintableSentence = () => $"{Numerator}{OperationSymbol}{Denominator}";
    }
    public Fraction(double Numerator, IOperation Denominator)
    {
        LeftValue = Numerator;
        RightValue = Denominator.ToResult();
        Printable = () => $"({Numerator}{OperationSymbol}{Denominator.Printable.Invoke()})";
        PrintableSentence = () => $"{Numerator}{OperationSymbol}{Denominator.PrintableSentence.Invoke()}";
    }

    public Fraction(IOperation Numerator, double Denominator)
    {
        LeftValue = Numerator.ToResult();
        RightValue = Denominator;
        Printable = () => $"({Numerator.Printable.Invoke()}{OperationSymbol}{Denominator})";
        PrintableSentence = () => $"{Numerator.PrintableSentence.Invoke()}{OperationSymbol}{Denominator}";
    }

    public Fraction(IOperation Numerator, IOperation Denominator)
    {
        LeftValue = Numerator.ToResult();
        RightValue = Denominator.ToResult();
        Printable = () => $"({Numerator.Printable.Invoke()}{OperationSymbol}{Denominator.Printable.Invoke()})";
        PrintableSentence = () => $"{Numerator.PrintableSentence.Invoke()}{OperationSymbol}{Denominator.PrintableSentence.Invoke()}";
    }

    public override double ToResult() => LeftValue / RightValue;
}