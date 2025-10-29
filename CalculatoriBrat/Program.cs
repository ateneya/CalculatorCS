// See https://aka.ms/new-console-template for more information
using CalculatoriBrat.Advanced_Calculator;
using CalculatoriBrat.Advanced_Calculator.Interface;
using CalculatoriBrat.AdvencedCalculators.Interface;
using CalculatoriBrat.BasicCalculators;
using CalculatoriBrat.BasicCalculators.Interface;

//while (true) {
//    ICalculatorBasic _calc = new Calcutaorcs();

//    Console.Write("Did u want use app? Yes/No");
//    var answer = Console.ReadLine().Trim().ToLower();

//    if (answer == "yes")
//    {

//        Console.WriteLine(_calc.Addition(5, 5));

//    }
//    else
//    {
//        Console.WriteLine("Goodbye");
//        break;
//    }

//}
using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("калькулятор:");
            Console.WriteLine("1 - Базовый");
            Console.WriteLine("2 - Расширенный");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                ICalculatorBasic calculator = new Calcutaorcs();

                bool continueCalculation = true;

                while (continueCalculation)
                {
                    Console.WriteLine("\nпервое число:");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(" (+, -, *, /):");
                    char operation = Console.ReadLine()[0];

                    Console.WriteLine("второе число:");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    if (operation == '+')
                    {
                        try
                        {
                            double result = calculator.Calculate(num1, num2, operation);
                            Console.WriteLine($"Результат: {result}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"ошибка: {ex.Message}");
                        }
                    }
                    if (operation == '/')
                    {
                        try
                        {
                            double result = calculator.Division(num1, num2, operation);
                            Console.WriteLine($"Результат: {result}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"ошибка: {ex.Message}");
                        }
                    }
                    if (operation == '-')
                    {
                        try
                        {
                            double result = calculator.Substraction(num1, num2, operation);
                            Console.WriteLine($"Результат: {result}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"ошибка: {ex.Message}");
                        }
                    }
                    if (operation == '*')
                    {
                        try
                        {
                            double result = calculator.Multiplication(num1, num2, operation);
                            Console.WriteLine($"Результат: {result}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"ошибка: {ex.Message}");
                        }
                    }

                    Console.WriteLine("продолжить хочешь? (y/n):");
                    if (Console.ReadLine().ToLower() != "y")
                        continueCalculation = false;
                }
            }
            else if (choice == "2")
            {
                ICalculatorAdvanced advancedCalculator = new Calculator();

                bool continueCalculation = true;

                while (continueCalculation)
                {
                    Console.WriteLine("\nвыберите операцию:");
                    Console.WriteLine("1 - возведение в степень");
                    Console.WriteLine("2 - корень n-й степени");
                    Console.WriteLine("3 - синус");
                    Console.WriteLine("4 - косинус");
                    Console.WriteLine("5 - тангенс");
                    Console.WriteLine("6 - ну нажми нажми");

                    string operation = Console.ReadLine();

                    try
                    {
                        switch (operation)
                        {
                            case "1":
                                Console.WriteLine("введите основание:");
                                double baseNumber = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("введите показатель степени:");
                                double exponent = Convert.ToDouble(Console.ReadLine());
                                double powerResult = advancedCalculator.Power(baseNumber, exponent);
                                Console.WriteLine($"{baseNumber} ^ {exponent} = {powerResult}");
                                break;

                            case "2":
                                Console.WriteLine("введи число:");
                                double valueForRoot = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("введи степень корня:");
                                double degree = Convert.ToDouble(Console.ReadLine());
                                double rootResult = advancedCalculator.Root(valueForRoot, degree);
                                Console.WriteLine($"корень {degree}-й степени из {valueForRoot} = {rootResult}");
                                break;

                            case "3":
                                Console.WriteLine("введите угол:");
                                double sinValue = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"Sin({sinValue}) = {advancedCalculator.Sin(sinValue)}");
                                break;

                            case "4":
                                Console.WriteLine("введите угол:");
                                double cosValue = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"Cos({cosValue}) = {advancedCalculator.Cos(cosValue)}");
                                break;

                            case "5":
                                Console.WriteLine("введите угол:");
                                double tanValue = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"Tan({tanValue}) = {advancedCalculator.Tan(tanValue)}");
                                break;

                            case "6":
                                continueCalculation = false;
                                Console.WriteLine("пака пака");
                                break;

                            default:
                                Console.WriteLine("повтори да");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"еррор братишка: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("ЙАХААААААААА");
            }
        }
    }
}