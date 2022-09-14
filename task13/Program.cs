// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78->третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
  string str = number.ToString();
  Console.WriteLine($"Вторая цифра числа {number} это - {str[1]}");
}
else
{
  Console.WriteLine("Нет третьей цифры");
}