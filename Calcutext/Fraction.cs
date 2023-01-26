namespace Calcutext;
public class Fraction : Operation
{
    public Fraction(double Numerator, double Denominator)
    {
        LeftValue = Numerator;
        RightValue = Denominator;
        Printable = () => $"({Numerator}/{Denominator})";
        PrintableSentence = () => $"{Numerator}/{Denominator}";
    }
    public Fraction(double Numerator, IOperation Denominator)
    {
        LeftValue = Numerator;
        RightValue = Denominator.ToResult();
        Printable = () => $"({Numerator}/{Denominator.Printable.Invoke()})";
        PrintableSentence = () => $"{Numerator}/{Denominator.PrintableSentence.Invoke()}";
    }

    public Fraction(IOperation Numerator, double Denominator)
    {
        LeftValue = Numerator.ToResult();
        RightValue = Denominator;
        Printable = () => $"({Numerator.Printable.Invoke()}/{Denominator})";
        PrintableSentence = () => $"{Numerator.PrintableSentence.Invoke()}/{Denominator}";
    }

    public Fraction(IOperation Numerator, IOperation Denominator)
    {
        LeftValue = Numerator.ToResult();
        RightValue = Denominator.ToResult();
        Printable = () => $"({Numerator.Printable.Invoke()}/{Denominator.Printable.Invoke()})";
        PrintableSentence = () => $"{Numerator.PrintableSentence.Invoke()}/{Denominator.PrintableSentence.Invoke()}";
    }

    public override double ToResult()
    {
        return LeftValue / RightValue;
    }
    public override string Print()
    {
        return $"{Printable.Invoke()} = {ToResult()}";
    }

    public override string PrintSentence()
    {
        return PrintableSentence.Invoke() + " is " + ToResult();
    }
}