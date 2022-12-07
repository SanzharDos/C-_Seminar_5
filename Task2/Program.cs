// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-100, 101);
    return array;
}

int[] ChangeArray(int[] array) // void ChangeArrat(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= -1;
        return array; // return array убрать
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

try
{
    Console.WriteLine("Введите размерность массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = CreateArray(size);
    Console.WriteLine($"Сгенерирован массив из {size} элементов:");
    PrintArray(array);
    Console.WriteLine($"Измененный массив:");
    // ChangeArray(array);
    // PrintArray(array);
    PrintArray(ChangeArray(array));
}

catch
{
    Console.WriteLine("Надо ввести целое число!!!");
}

