namespace Calcutext;
public class Sum : Operation
{
    public const string OperationName = "sum of";
    public const string OperationSymbol = "+";
    public const string OperationConnector = "and";
    
    public Sum(double Left, double Right)
    {
        LeftValue = Left;
        RightValue = Right;
        Printable = () => $"({Left} {OperationSymbol} {Right})";
        PrintableSentence = () => $"{OperationName} {Left} {OperationConnector} {Right}";
    }

    public Sum(double Left, IOperation Right)
    {
        LeftValue = Left;
        RightValue = Right.ToResult();
        Printable = () => $"({Left} {OperationSymbol} {Right.Printable.Invoke()})";
        PrintableSentence = () => $"{OperationName} {Left} {OperationConnector} {Right.PrintableSentence.Invoke()}";
    }

    public Sum(IOperation Left, double Right)
    {
        LeftValue = Left.ToResult();
        RightValue = Right;
        Printable = () => $"({Left.Printable.Invoke()} {OperationSymbol} {Right})";
        PrintableSentence = () => $"{OperationName} {Left.PrintableSentence.Invoke()} {OperationConnector} {Right}";
    }

    public Sum(IOperation Left, IOperation Right)
    {
        LeftValue = Left.ToResult();
        RightValue = Right.ToResult();
        Printable = () => $"({Left.Printable.Invoke()} {OperationSymbol} {Right.Printable.Invoke()})";
        PrintableSentence = () => $"{OperationName} {Left.PrintableSentence.Invoke()} {OperationConnector} {Right.PrintableSentence.Invoke()}";
    }

    public override double ToResult() => LeftValue + RightValue;
}
