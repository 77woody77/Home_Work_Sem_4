// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число X и число Y");
int X = int.Parse(Console.ReadLine()!);
int Y = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{Degree(X, Y)}");

int Degree(int X, int Y)
{
    int result = 1;
    for (int i = 1; i <= Y; i++)
    {
        result = result * X;
    }
    return result;
}