// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Enter the number continuously. negative numbers are skip");

while (true)
{
    Console.Write("Enter are number");
    int number = Convert.ToInt32( Console.ReadLine());
    if (number <1)
    {
        Console.WriteLine("Nagivate number");
        break;
    }
    if (number < 0)
    {
        continue;
    }
    if (number>100)
    {
        Console.WriteLine("Number is greater then 100. exiting");
        break;
    }
    if(number % 2 == 0)
    {
        Console.WriteLine("You have entered the Even number");
    }
    else
    {
        Console.WriteLine("You have entered the Odd number");
    }
}
