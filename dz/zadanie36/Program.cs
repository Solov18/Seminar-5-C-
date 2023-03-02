/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/


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
int result = 0; // функция 
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        result += array[i];
    }
}
Console.WriteLine($"Сумма элементов нечетных позиций = {result}");