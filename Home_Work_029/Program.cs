// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = FillRandomBiteArray(8);
PrintArray(array);

int[] FillRandomBiteArray(int array_size) 
{ 
    int[] result = new int[array_size]; 
    for (int i = 0; i < array_size; i++) result[i] = new Random().Next(0, 100); 
    return result; 
} 
 
void PrintArray(int[] array) 
{ 
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} "); 
    Console.WriteLine(); 
} 
 
