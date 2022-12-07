// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(0, 21);
    return array;
}

int[] ChangeArray(int[] array)
{
    int[] array_new = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
    {
        array_new[i] = array[i] * array[array.Length - i - 1];
    }
    array_new[array_new.Length - 1] = array[array.Length / 2];
    return array_new;
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
    Console.WriteLine($"Измененный массив из произведений пар в изначальном массиве:");
    PrintArray(ChangeArray(array));
    PrintArray(array);
}

catch
{
    Console.WriteLine("Надо ввести целое число!!!");
}