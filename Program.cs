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

