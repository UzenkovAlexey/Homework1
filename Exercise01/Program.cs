/*Задача 1-2: 
  Напишите программу, которая принимает на вход трёхзначное число и на выходе 
  показывает вторую цифру этого числа.
         456 -> 5
         782 -> 8
         918 -> 1
*/


Console.Write("Введите трёхзначное число: ");
 int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10 && number <=100) 
{
  Console.WriteLine($"{number} Третьей цифры нет");
}
if   (number >= 100 && number <=1000) 
{
  string Num = Convert.ToString(number);
  Console.WriteLine($" {number} -- "+ Num[1]);
}
else 
{
  Console.WriteLine($"{number} Число не трёхзначное");
}



