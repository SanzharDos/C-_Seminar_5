// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(0, 10);
    return array;
}

void PrintArray(int[] size)
{
    Console.Write("{ ");
    foreach (int el in size)
    {
        Console.Write($"{el} ");
    }
    Console.Write("}");
    Console.WriteLine();
}

void Check(int[] size, int find)
{
    int count = 0;
    for (int i = 0; i < size.Length; i++)
    {
        if (size[i] == find) count++;
    }
    if (count > 0) Console.WriteLine($"В массиве число {find} есть");
    else Console.WriteLine($"В массиве числа {find} нет");
}

try
{
    Console.WriteLine("Введите размерность массива");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число, которое надо найти");
    int find = Convert.ToInt32(Console.ReadLine());
    int[] array = CreateArray(size);
    Console.WriteLine($"Сгенерирован массив из {size} элементов:");
    PrintArray(array);
    Check(array, find);
}

catch
{
    Console.WriteLine("Надо ввести целое число!!!");
}
