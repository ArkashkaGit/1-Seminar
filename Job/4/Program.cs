/* Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите любое число больше 1... \n");
int N = int.Parse(Console.ReadLine());
int count = 0;

while ( N<=1 )
{
    if (N <=1)
    {
    Console.WriteLine("это число не подходит, введите другое число");
    N = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("\Ниже представлен список чётных чисел \nот 1 до указанного вами числа!!!\n");

while (count < N)
{
    
    Console.Write(count + ", ");
    if (count < N)
    {
        count += 2;
    }
}