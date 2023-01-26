namespace Calcutext;
public interface IOperation
{
    Func<string> Printable { get; set; }

    Func<string> PrintableSentence { get; set; }

    double ToResult();
}