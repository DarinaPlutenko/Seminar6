// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
int size = (int)Math.Log2(number) + 1;
int[] array = new int[size];


for (int i = 0; i < array.Length; i++)
{
    array[i] = number % 2;
    number = number / 2;
}

Array.Reverse(array);

Console.WriteLine(size);
Console.WriteLine(string.Join(", ", array));