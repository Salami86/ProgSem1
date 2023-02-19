// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

Console.Write("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine("Кратно одновременно 7 и 23");
}
else
{
    Console.WriteLine("Не кратно одновременно 7 и 23");
}

