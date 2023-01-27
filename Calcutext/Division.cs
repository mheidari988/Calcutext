namespace Calcutext;
public class Division : Operation
{
    public const string OperationName = "division of";
    public const string OperationSymbol = "/";
    public const string OperationConnector = "by";
    
    public Division(double Left, double Right)
    {
        LeftValue = Left;
        RightValue = Right;
        Printable = () => $"({Left} {OperationSymbol} {Right})";
        PrintableSentence = () => $"{OperationName} {Left} {OperationConnector} {Right}";
    }

    public Division(double Left, IOperation Right)
    {
        LeftValue = Left;
        RightValue = Right.ToResult();
        Printable = () => $"({Left} {OperationSymbol} {Right.Printable.Invoke()})";
        PrintableSentence = () => $"{OperationName} {Left} {OperationConnector} {Right.PrintableSentence.Invoke()}";
    }

    public Division(IOperation Left, double Right)
    {
        LeftValue = Left.ToResult();
        RightValue = Right;
        Printable = () => $"({Left.Printable.Invoke()} {OperationSymbol} {Right})";
        PrintableSentence = () => $"{OperationName} {Left.PrintableSentence.Invoke()} {OperationConnector} {Right}";
    }

    public Division(IOperation Left, IOperation Right)
    {
        LeftValue = Left.ToResult();
        RightValue = Right.ToResult();
        Printable = () => $"({Left.Printable.Invoke()} {OperationSymbol} {Right.Printable.Invoke()})";
        PrintableSentence = () => $"{OperationName} {Left.PrintableSentence.Invoke()} {OperationConnector} {Right.PrintableSentence.Invoke()}";
    }

    public override double ToResult() => LeftValue / RightValue;
}