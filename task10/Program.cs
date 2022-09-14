// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456-> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите 3-х значное число: ");
// string? number = Console.ReadLine();

// Console.WriteLine($"Вторая цифра числа {number} это - {number[1]}");

Console.Write("Введите 3-х значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = number / 10;
int secondDigit = firstDigit % 10;
Console.WriteLine($"Вторая цифра числа {number} - это {secondDigit} ");
