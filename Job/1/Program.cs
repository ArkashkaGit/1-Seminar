/*Задача 2: Напишите программу, которая на вход принимает 
два числа и выдаёт максимальное из этих чисел.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.Write("Enter first number = ");
int first = int.Parse(Console.ReadLine());

Console.Write("Enter second number = ");
int second = int.Parse(Console.ReadLine());

if (first > second)
{
    Console.Write("max number first");
    Console.Write(" " + first);
}

if (second > first)
{
    Console.Write("max number second");
    Console.Write(" " + second);
}

if(first == second)
{
    Console.Write("fitst = second");
}