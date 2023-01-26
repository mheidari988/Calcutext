using Calcutext;

ToResults();
Prints();
PrintSentences();

void ToResults()
{
    LineBreak(40, ".ToResult()");

    // Should return 6.7
    Console.WriteLine(new Sum(5.2, 1.5).ToResult());

    // Should return 6
    Console.WriteLine(new Division(30, new Sum(2, 3)).ToResult());

    // Should return 24
    Console.WriteLine(new Faculty(4).ToResult());

    // Should return 1.5
    Console.WriteLine(new Multiplication(new Fraction(9, 4), new Fraction(2, 3)).ToResult());

}

void Prints()
{
    LineBreak(40, ".Print()");

    // Should return (5.2 + 1.5) = 6.7
    Console.WriteLine(new Sum(5.2, 1.5).Print());

    // Should return (30 / (2 + 3)) = 6
    Console.WriteLine(new Division(30, new Sum(2, 3)).Print());

    // Should return (4!) = 24
    Console.WriteLine(new Faculty(4).Print());

    // Should return ((9/4) * (2/3)) = 1.5
    Console.WriteLine(new Multiplication(new Fraction(9, 4), new Fraction(2, 3)).Print());

}

void PrintSentences()
{
    LineBreak(40, ".PrintSentence()");

    // Should return sum of 5.2 and 1.5 is 6.7
    Console.WriteLine(new Sum(5.2, 1.5).PrintSentence());

    // Should return division of 30 by sum of 2 and 3 is 6
    Console.WriteLine(new Division(30, new Sum(2, 3)).PrintSentence());

    // Should return faculty of 4 is 24
    Console.WriteLine(new Faculty(4).PrintSentence());

    // Should return multiplication of 9 / 4 and 2 / 3 is 1.5
    Console.WriteLine(new Multiplication(new Fraction(9, 4), new Fraction(2, 3)).PrintSentence());
}

void LineBreak(int count, string header) => Console.WriteLine($"{new string('=', count / 2)} {header} {new string('=', count / 2)}");
