namespace Calcutext;
public class Sum : Operation
{
    public Sum(double Left, double Right)
    {
        LeftValue = Left;
        RightValue = Right;
        Printable = () => $"({Left} + {Right})";
        PrintableSentence = () => $"Sum of {Left} and {Right}";
    }

    public Sum(double Left, IOperation Right)
    {
        LeftValue = Left;
        RightValue = Right.ToResult();
        Printable = () => $"({Left} + {Right.Printable.Invoke()})";
        PrintableSentence = () => $"Sum of {Left} and {Right.PrintableSentence.Invoke()}";
    }

    public Sum(IOperation Left, double Right)
    {
        LeftValue = Left.ToResult();
        RightValue = Right;
        Printable = () => $"({Left.Printable.Invoke()} + {Right})";
        PrintableSentence = () => $"Sum of {Left.PrintableSentence.Invoke()} and {Right}";
    }

    public Sum(IOperation Left, IOperation Right)
    {
        LeftValue = Left.ToResult();
        RightValue = Right.ToResult();
        Printable = () => $"({Left.Printable.Invoke()} + {Right.Printable.Invoke()})";
        PrintableSentence = () => $"Sum of {Left.PrintableSentence.Invoke()} and {Right.PrintableSentence.Invoke()}";
    }

    public override double ToResult() => LeftValue + RightValue;
}
