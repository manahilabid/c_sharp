// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
for (int i =1; i<=8;i++)
{
    for (int s = 8; s >= i; s--)
    {
        Console.Write(" ");
    }
    for (int j =1; j<=i;j++)
    {
        Console.Write("* ");
    }
    for (int k = 1; k > i; k--)
    {
        Console.Write("* ");
    }

    Console.WriteLine("");
}
for (int i = 7; i >= 1; i--)
{
    for (int s = 7; s >= i; s--)
    {
        Console.Write(" ");
    }
    for (int j = i; j >= 1; j--)
    {
        Console.Write("* ");
    }
    Console.WriteLine("");
}



Console.ReadKey();