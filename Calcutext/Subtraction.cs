namespace Calcutext;
public class Subtraction : Operation
{
    public Subtraction(double Left, double Right)
    {
        LeftValue = Left;
        RightValue = Right;
        Printable = () => $"({Left} - {Right})";
        PrintableSentence = () => $"Subtraction of {Left} and {Right}";
    }

    public Subtraction(double Left, IOperation Right)
    {
        LeftValue = Left;
        RightValue = Right.ToResult();
        Printable = () => $"({Left} - {Right.Printable.Invoke()})";
        PrintableSentence = () => $"Subtraction of {Left} and {Right.PrintableSentence.Invoke()}";
    }

    public Subtraction(IOperation Left, double Right)
    {
        LeftValue = Left.ToResult();
        RightValue = Right;
        Printable = () => $"({Left.Printable.Invoke()} - {Right})";
        PrintableSentence = () => $"Subtraction of {Left.PrintableSentence.Invoke()} and {Right}";
    }

    public Subtraction(IOperation Left, IOperation Right)
    {
        LeftValue = Left.ToResult();
        RightValue = Right.ToResult();
        Printable = () => $"({Left.Printable.Invoke()} - {Right.Printable.Invoke()})";
        PrintableSentence = () => $"Subtraction of {Left.PrintableSentence.Invoke()} and {Right.PrintableSentence.Invoke()}";
    }

    public override double ToResult() => LeftValue - RightValue;
}