namespace Calcutext;
public class Faculty : Operation
{
    public const string OperationName = "faculty of";
    
    public Faculty(double Value)
    {
        LeftValue = Value;
        Printable = () => $"({Value}";
        PrintableSentence = () => $"{OperationName} {Value}";
    }

    public Faculty(IOperation Value)
    {
        LeftValue = Value.ToResult();
        Printable = () => $"({Value.Printable.Invoke()}";
        PrintableSentence = () => $"{OperationName} {Value.PrintableSentence.Invoke()}";
    }

    public override double ToResult()
    {
        double result = 1;
        for (int i = 1; i <= LeftValue; i++)
        {
            result *= i;
        }
        return result;
    }

    public override string Print()
    {
        return $"{Printable.Invoke()}!) = " + ToResult();
    }
}