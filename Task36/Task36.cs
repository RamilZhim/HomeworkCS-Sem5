// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите левую границу массива: ");
int leftRange = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите правую границу массива");
int rightRange = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];
FillArray(numbers);
PrintArray(numbers);

int sumNum = 0;

for (int i = 1; i < numbers.Length; i += 2)
{
    sumNum += numbers[i];
}
Console.Write(sumNum);

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
