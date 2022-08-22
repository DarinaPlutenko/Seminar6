// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число C");
int C = int.Parse(Console.ReadLine()!);

if (A < B + C && B < A + C && C < A + B)
{
    Console.WriteLine("Такой треугольник может существовать");
}
else
{
    Console.WriteLine("Такой треугольник невозможен");
}