/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int[] RandomArray (int length, int minValue, int maxValue){
    int[] array = new int[length];
    for(int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(minValue,maxValue + 1);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}
void CountEvenElements (int[] array){
    int count = 0;
    foreach(int element in array){
        if(element % 2 == 0){
            count++;
        }
    }
    Console.WriteLine($"Количество четных элементов в массиве: {count}");
}
Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение элементов массива: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элементов массива: ");
int maxValue = int.Parse(Console.ReadLine()!);
int[] array = RandomArray(length, minValue, maxValue);
CountEvenElements(array);

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void SumOfOddElements (int[] array){
    int sum = 0;
    for(int i = 0; i < array.Length; i++){
        if(i % 2 == 1){
            sum += array[i];
        }
    }
    Console.WriteLine($"Сумма элементов массива с нечетным индексом: {sum}");
}
Console.Write("Введите длину массива: ");
length = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение элементов массива: ");
minValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элементов массива: ");
maxValue = int.Parse(Console.ReadLine()!);
int[] array2 = RandomArray(length, minValue, maxValue);
SumOfOddElements(array2);

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
double[] DoubleRandomArray (int length, int minValue, int maxValue){
    double[] array = new double[length];
    for(int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(minValue,maxValue + 1);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

void DifferenceBetweenMaxAndMin (double[] array){
    double max = array[0];
    for(int i = 0; i < array.Length; i++){
        if(max < array[i]){
            max = array[i];
        }
    }
    Console.WriteLine($"Максимальный элемент массива: {max}");
    double min = array[0];
    for(int i = 0; i < array.Length; i++){
        if(min > array[i]){
            min = array[i];
        }
    }
    Console.WriteLine($"Минимальный элемент массива: {min}");
    Console.WriteLine($"Разница между максимальным и минимальным элементами: {max - min}");
}

Console.Write("Введите длину массива: ");
length = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение элементов массива: ");
minValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элементов массива: ");
maxValue = int.Parse(Console.ReadLine()!);
double[] array3 = DoubleRandomArray(length, minValue, maxValue);
DifferenceBetweenMaxAndMin(array3);