// Задача №3
// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.

Console.Write("Введите число:" );
var day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day < 8)
{
    string[] dayWeek = {"Понидельник", "Вторник", "Среда", "Четверг", "Пятница", "суббота", "воскресенье", };
    Console.WriteLine(dayWeek[day - 1]);
}
else
{
  Console.WriteLine("Вы ввели не день недели!");  
}