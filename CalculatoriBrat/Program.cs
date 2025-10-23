// See https://aka.ms/new-console-template for more information

using CalculatoriBrat.Class;
using CalculatoriBrat.Class.Interface;



while (true) {
    ICalculatorBasic _calc = new Calcutaorcs();

    Console.Write("Did u want use app? Yes/No");
    var answer = Console.ReadLine().Trim().ToLower();

    if (answer == "yes")
    {

        Console.WriteLine(_calc.Addition(5, 5));

    }
    else
    {
        Console.WriteLine("Goodbye");
        break;
    }

}