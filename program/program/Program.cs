﻿Console.WriteLine("Введите A");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите B");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Выберите тип операции -\n'+' - Сложение\n'-' - Вычитание\n'*' - Умножение\n'/' - Деление");
string choice = Console.ReadLine();

switch (choice)
{
    case "+":
        {
            addition(a, b);
        }
        break;
    case "-":
        {
            subtraction(a, b);
        }
        break;
    case "*":
        {
            multipication(a, b);
        }
        break;
    case "/":
        {
            division(a, b);
        }
        break;
    default:
        break;
}
