using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double first, second;
            string action;

            Console.WriteLine("Введите первое число:");
            first = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            second = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию: '+','-','*','/'");
            action = Console.ReadLine();

            switch (action)
            {
                case "+":
                    Console.WriteLine(first + second);
                    break;
                case "-":
                    Console.WriteLine(first - second);
                    break;

                case "*":
                    Console.WriteLine(first * second);
                    break;

                case "/":
                    if (second == 0)
                    {
                        Console.WriteLine("Внимание! Деение на ноль запрещено!");
                    }

                    else
                    {
                        Console.WriteLine(first / second);
                    }

                    break;

                default:
                    Console.WriteLine("Неизвестна операция");
                    break;

            }

        }
    }
}
