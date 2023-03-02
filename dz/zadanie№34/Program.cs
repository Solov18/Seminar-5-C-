
/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int a = TakeConsoleInt("Число: ");

int TakeConsoleInt(string str = "Введите число: ")
{
    int num;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out num);
    return num;
}
int[] array = CreateArray(a);

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
    Console.WriteLine();

int[] CreateArray(int a)
{
    int[] numbers = new int[a];
    for (int i = 0; i < a; i++)
        numbers[i] = new Random().Next(100, 999);
    return numbers;

}
int result = 0;
for (int i = 0; i < array.Length; i++)

    if (array[i] % 2 == 0)
    {
        result++;
    }
Console.Write($"Четные числа = {result} ");