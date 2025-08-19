// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//nested loop 
for (int i=1;i<=5;i++)
{

    for (int j=1; j<=i; j++)  
    {
        Console.Write("*");
    }
    Console.WriteLine(" ");
}


//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine("");
//}

for (int k = 5; k >=1; k--)
{
    Console.Write("\n");
    for(int l = k; l >= 1; l--)
    {
        Console.Write(l);
    }
}
for (int i = 1; i <= 5; i++)
{
    for (int k = 1;k>=5;k--)
    {
        Console.Write(" ");
    }
    Console.WriteLine("\t");
    for (int j = 1; j <= i; j++)
    {
        Console.Write("a");
    }
    Console.WriteLine(" ");
}

Console.ReadKey();