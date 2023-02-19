// Задача №9
// Напишите программу, которая выводит случайное
// число из отрезка [10, 99] и показывает наибольшую
// цифру числа. 

System.Random numSintezator = new System.Random();

// Выреант 1
int rndNumber = numSintezator.Next(10, 100);
Console.WriteLine(rndNumber);
int firstNum = rndNumber / 10;
int secondNum = rndNumber % 10;

if  (firstNum > secondNum)
{
    Console.WriteLine("Первое чесло больше " + firstNum + " второго " + secondNum);
}
else
{
    Console.WriteLine(secondNum);
}




