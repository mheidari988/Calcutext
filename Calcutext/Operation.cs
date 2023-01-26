namespace Calcutext;
public abstract class Operation : IOperation
{
    public Func<string> Printable { get; set; } = () => string.Empty;
    public Func<string> PrintableSentence { get; set; } = () => string.Empty;
    protected double LeftValue { get; set; }
    protected double RightValue { get; set; }
    public abstract double ToResult();
    public abstract string Print();
    public abstract string PrintSentence();
}