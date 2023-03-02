
/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/



int a = TakeConsoleInt("Число: "); // Ввод числа в консоль

int TakeConsoleInt(string str = "Введите число: ")
{
    int num;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out num);
    return num;
}
int[] array = CreateArray(a); // Массив с рондомом 

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine();

int[] CreateArray(int a)
{
    int[] numbers = new int[a];
    for (int i = 0; i < a; i++)
        numbers[i] = new Random().Next(-10, 10);
    return numbers;

}
int max = array[0];
int min = array[0];
 // функция 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {max - min}");