/*
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным.
*/                              // 1 - понедельник
                                // 2 - вторник
                                // 3 - среда
                                // 4 - четверг
                                // 5 - пятница
                                // 6 - суббота
                                // 7 - воскресенье



Console.Write("Введи день недели: ");
int daynum = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int daynum) 
{
  if (daynum == 6 || daynum == 7) 
  {
  Console.WriteLine("Выходной день");
  }
  else if (daynum < 1 || daynum > 7) 
  {
    Console.WriteLine("Нет в списке!");
  }
  else Console.WriteLine("Рабочий день");
}

CheckingTheDayOfTheWeek(daynum);