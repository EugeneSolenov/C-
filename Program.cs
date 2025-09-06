using System;
double memory = 0;
while (true)
{
    Console.WriteLine("Первое число введи: ");
    double first = double.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Операцию тоже введи: ");
    string op = Console.ReadLine() ?? "";
    switch (op)
    {
        case ("+"):
            Console.WriteLine("Второе число введи: ");
            double second = double.Parse(Console.ReadLine() ?? "");
            Console.WriteLine($"{first + second}");
            break;
        case ("-"):
            Console.WriteLine("Второе число введи: ");
            second = double.Parse(Console.ReadLine() ?? "");
            Console.WriteLine($"{first - second}");
            break;
        case ("*"):
            Console.WriteLine("Второе число введи: ");
            second = double.Parse(Console.ReadLine() ?? "");
            Console.WriteLine($"{first * second}");
            break;
        case ("/"):
            Console.WriteLine("Второе число введи: ");
            second = double.Parse(Console.ReadLine() ?? "");
            if (second == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
                break;
            }
            Console.WriteLine($"{first / second}");
            break;
        case ("%"):
            Console.WriteLine("Второе число введи: ");
            second = double.Parse(Console.ReadLine() ?? "");
            Console.WriteLine($"{first % second}");
            break;
        case ("1/x"):
            if (first == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
                break;
            }
            Console.WriteLine($"{1/first}");
            break;
        case ("x^2"):
            Console.WriteLine($"{first*first}");
            break;
        case ("sqrt"):
            Console.WriteLine($"{Math.Sqrt(first)}");
            break;
        case ("M+"):
            memory += first;
            Console.WriteLine($"Память обновлена");
            break;
        case ("M-"):
            memory -= first;
            Console.WriteLine($"Память обновлена");
            break;
        case ("MR"):
            Console.WriteLine($"{memory}");
            break;
        case ("esc"):
            return;

    }
}


