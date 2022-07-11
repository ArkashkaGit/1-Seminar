Console.Write("Enter first number = ");
int first = int.Parse(Console.ReadLine());

Console.Write("Enter second number = ");
int second = int.Parse(Console.ReadLine());

Console.Write("Enter three number = ");
int three = int.Parse(Console.ReadLine());

if (first > second)
{
    if (first > three)
    {
        Console.Write("max number first");
        Console.Write(" " + first);
    }
}

if (second > first)
{
    if (second > three)
    {
        Console.Write("max number second");
        Console.Write(" " + second);
    }
}    

if (three > first)
{
    if (three > second)
    {
        Console.Write("max number three");
        Console.Write(" " + three);
    }
}