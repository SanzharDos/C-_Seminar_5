// Задача 35: Задайте одномерный массив из 15 случайных чисел от -100 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-100, 101);
    return array;
}

void Check(int[] size)
{
    int count = 0;
    for (int i = 0; i < size.Length; i++)
    {
        if (size[i] < 100 && size[i] > 9) count++;
    }
    Console.WriteLine($"Количество значений в массиве, принадлежащих промежутку от 10 до 99 составляет = {count}");
}

int Elements(int[] size)
{
    int count =  0;
    foreach (int el in size)
    {
        if (el >= 10 && el <= 99) count++;
    }
    return count;
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
    Check(array);
    Console.WriteLine($"Количество значений в массиве, принадлежащих промежутку от 10 до 99 составляет = {Elements(array)}");
}

catch
{
    Console.WriteLine("Надо ввести целое число!!!");
}