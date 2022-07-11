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
    Console.Write("max number first");
    Console.Write(" " + first);
}