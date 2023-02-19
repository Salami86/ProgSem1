// Задача №20
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
// Метод выводит данные пользователю
void PrintData(string msg, double val)
{
    Console.WriteLine(msg+val);
}
// Метод находит растояние между точками на плоскости
double CalcLen2D(int x1, int x2, int y1, int y2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
}

int x1 = ReadData("Выводит координату х точки А: ");
int y1 = ReadData("Выводит координату y точки А: ");
int x2 = ReadData("Выводит координату х точки В: ");
int y2 = ReadData("Выводит координату y точки В: ");

double res = CalcLen2D(x1,x2,y1,y2);

PrintData("Растояние между точками А и В: ", res);
