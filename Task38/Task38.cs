// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите левую границу массива: ");
int leftRange = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите правую границу массива");
int rightRange = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];
FillArray(numbers);
PrintArray(numbers);

int max = numbers[0];
int min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine($"Минимальное число в массиве: {min}");
Console.WriteLine($"Максимальное число в массиве: {max}");
Console.WriteLine($"Разница между максимальным и минимальным числами массива: {max - min}");