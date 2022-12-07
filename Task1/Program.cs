// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int size = 12;
int[] array = new int[size];
int sumPlus = 0;
int sumMinus = 0;
Console.WriteLine("Сгенерирован массив из 12 элементов:");
Console.Write("{ ");
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-9, 10);
    if (i < size - 1) Console.Write($"{array[i]}, ");
    else Console.Write($"{array[i]} ");

if (array[i] < 0 )
{
sumMinus = sumMinus + array[i];
}
else sumPlus = sumPlus + array[i];
}
Console.WriteLine("}");
Console.WriteLine($"Сумма положительных значений массива равна = {sumPlus}, сумма отрицательных значений массива равна = {sumMinus}");


