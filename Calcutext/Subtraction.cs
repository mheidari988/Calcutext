namespace Calcutext;
public class Subtraction : Operation
{
    public const string OperationName = "subtraction of";
    public const string OperationSymbol = "-";
    public const string OperationConnector = "and";
    public Subtraction(double Left, double Right)
    {
        LeftValue = Left;
        RightValue = Right;
        Printable = () => $"({Left} {OperationSymbol} {Right})";
        PrintableSentence = () => $"{OperationName} {Left} {OperationConnector} {Right}";
    }

    public Subtraction(double Left, IOperation Right)
    {
        LeftValue = Left;
        RightValue = Right.ToResult();
        Printable = () => $"({Left} {OperationSymbol} {Right.Printable.Invoke()})";
        PrintableSentence = () => $"{OperationName} {Left} {OperationConnector} {Right.PrintableSentence.Invoke()}";
    }

    public Subtraction(IOperation Left, double Right)
    {
        LeftValue = Left.ToResult();
        RightValue = Right;
        Printable = () => $"({Left.Printable.Invoke()} {OperationSymbol} {Right})";
        PrintableSentence = () => $"{OperationName} {Left.PrintableSentence.Invoke()} {OperationConnector} {Right}";
    }

    public Subtraction(IOperation Left, IOperation Right)
    {
        LeftValue = Left.ToResult();
        RightValue = Right.ToResult();
        Printable = () => $"({Left.Printable.Invoke()} {OperationSymbol} {Right.Printable.Invoke()})";
        PrintableSentence = () => $"{OperationName} {Left.PrintableSentence.Invoke()} {OperationConnector} {Right.PrintableSentence.Invoke()}";
    }

    public override double ToResult() => LeftValue - RightValue;
}