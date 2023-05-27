// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите левую границу массива: ");
int leftRange = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите правую границу массива");
int rightRange = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];
int count = 0;
FillArray(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
        count++;
}

// Console.WriteLine($"Количество чётных чисел в массиве -> {count} ");

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
Console.WriteLine($"Количество чётных чисел в массиве -> {count} ");
