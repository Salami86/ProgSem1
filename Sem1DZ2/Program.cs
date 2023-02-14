// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
int num_A = Convert.ToInt32(Console.ReadLine());

if (num_A % 2 == 0)
{
    Console.WriteLine("Число " + num_A + " является: нечётным");
}
else
{
    Console.WriteLine("Число " + num_A + "является: чётным");
}
