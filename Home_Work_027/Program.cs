// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

int Sum(int n)
{ 
    int sum = 0; 
    while (Math.Abs(n) > 0) 
    { 
      
        sum = sum + n % 10; 
        n = n /10;

    } 

   return(sum);
} 

Console.WriteLine($"Cумма цифр в числе {n} равно {Sum(n)}");