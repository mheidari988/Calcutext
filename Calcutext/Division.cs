namespace Calcutext;
public class Division : Operation
{
    public Division(double Left, double Right)
    {
        LeftValue = Left;
        RightValue = Right;
        Printable = () => $"({Left} / {Right})";
        PrintableSentence = () => $"Division of {Left} by {Right}";
    }

    public Division(double Left, IOperation Right)
    {
        LeftValue = Left;
        RightValue = Right.ToResult();
        Printable = () => $"({Left} / {Right.Printable.Invoke()})";
        PrintableSentence = () => $"Division of {Left} by {Right.PrintableSentence.Invoke()}";
    }

    public Division(IOperation Left, double Right)
    {
        LeftValue = Left.ToResult();
        RightValue = Right;
        Printable = () => $"({Left.Printable.Invoke()} / {Right})";
        PrintableSentence = () => $"Division of {Left.PrintableSentence.Invoke()} by {Right}";
    }

    public Division(IOperation Left, IOperation Right)
    {
        LeftValue = Left.ToResult();
        RightValue = Right.ToResult();
        Printable = () => $"({Left.Printable.Invoke()} / {Right.Printable.Invoke()})";
        PrintableSentence = () => $"Division of {Left.PrintableSentence.Invoke()} by {Right.PrintableSentence.Invoke()}";
    }

    public override double ToResult() => LeftValue / RightValue;
}