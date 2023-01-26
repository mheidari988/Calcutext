namespace Calcutext;
public class Multiplication : Operation
{
    public Multiplication(double Left, double Right)
    {
        LeftValue = Left;
        RightValue = Right;
        Printable = () => $"({Left} * {Right})";
        PrintableSentence = () => $"Multiplication of {Left} and {Right}";
    }

    public Multiplication(double Left, IOperation Right)
    {
        LeftValue = Left;
        RightValue = Right.ToResult();
        Printable = () => $"({Left} * {Right.Printable.Invoke()})";
        PrintableSentence = () => $"Multiplication of {Left} and {Right.PrintableSentence.Invoke()}";
    }

    public Multiplication(IOperation Left, double Right)
    {
        LeftValue = Left.ToResult();
        RightValue = Right;
        Printable = () => $"({Left.Printable.Invoke()} * {Right})";
        PrintableSentence = () => $"Multiplication of {Left.PrintableSentence.Invoke()} and {Right}";
    }

    public Multiplication(IOperation Left, IOperation Right)
    {
        LeftValue = Left.ToResult();
        RightValue = Right.ToResult();
        Printable = () => $"({Left.Printable.Invoke()} * {Right.Printable.Invoke()})";
        PrintableSentence = () => $"Multiplication of {Left.PrintableSentence.Invoke()} and {Right.PrintableSentence.Invoke()}";
    }

    public override double ToResult() => LeftValue * RightValue;
}
