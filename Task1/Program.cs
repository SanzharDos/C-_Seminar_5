// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int size = 12;
// int[] array = new int[size];
// int sumPlus = 0;
// int sumMinus = 0;
// Console.WriteLine("Сгенерирован массив из 12 элементов:");
// Console.Write("{ ");
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(-9, 10);
//     if (i < size - 1) Console.Write($"{array[i]}, ");
//     else Console.Write($"{array[i]} ");

// if (array[i] < 0 )
// {
// sumMinus = sumMinus + array[i];
// }
// else sumPlus = sumPlus + array[i];
// }
// Console.WriteLine("}");
// Console.WriteLine($"Сумма положительных значений массива равна = {sumPlus}, сумма отрицательных значений массива равна = {sumMinus}");

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-9, 10);
    return array;
}

void PrintArray(int[] array)
{
    // цикл проходящийся по всем значениям array, т.е. el принимает по очереди все значения массива
    // цикл только для просмотра массива, не даст вносить изменения в сам массив
    // здесь нет индекса вообще
    Console.Write("{ ");
    foreach (int el in array)
    {
        Console.Write($"{el} ");
    }
    Console.Write("}");
    Console.WriteLine();
}

void FindSums(int[] array)
{
    int sum_p = 0;
    int sum_n = 0;
    // цикл проходящийся по всем значениям array, т.е. el принимает по очереди все значения массива
    // цикл только для просмотра массива, не даст вносить изменения в сам массив
    // здесь нет индекса вообще
    foreach (int el in array)
    {
        if (el > 0) sum_p += el;
        else sum_n += el;
    }
    Console.WriteLine($"Сумма положительных значений массива равна = {sum_p}, сумма отрицательных значений массива равна = {sum_n}");
}

int[] FindSums2(int[] array)
{
    int[] results = new int[2];
    foreach (int el in array)
    {
        if (el > 0) results[0] += el;
        else results[1] += el;
    }
    return results;
}

try
{
    Console.WriteLine("Введите размерность массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = CreateArray(size);
    PrintArray(array);
    FindSums(array);
    int[] results = FindSums2(array);
    Console.WriteLine($"Сумма положительных значений массива равна = {results[0]}, сумма отрицательных значений массива равна = {results[1]}");
}

catch
{
    Console.WriteLine("Надо ввести целое число!!!");
}

