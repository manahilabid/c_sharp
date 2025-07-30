// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");
////if elseif else
//Console.WriteLine("Enter Name");
//string username = Console.ReadLine();
//Console.WriteLine("Enter password");
//string pass = Console.ReadLine();

//if (username == "manahil" && pass == "123abc")
//{
//    Console.WriteLine($"welcome user{username}");

//}
//else
//{
//    Console.WriteLine("invalid username & password");
//}
//shorthand If Else

string username = Console.ReadLine();
string pass = Console.ReadLine();
string output = username == "Alen" && pass == "manahil" ? " Login Successfully " : "invalid username&password";
Console.WriteLine(output);
Console.ReadKey();

//switch case
Console.WriteLine("-------------\'calculator\'-----------------");
Console.WriteLine("Enter num 1 :");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter num 2 :");
int num2 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the operator(+ , - , * , /):");
string opt = Console.ReadLine();
string result = "";
switch (opt)
{
    case "+":
        result = $"Result:{num1+num2}";
    break;
    case "-":
        result = $"Result:{num1-num2}";
    break;
    case "*":
        result = $"Result:{num1*num2}";
    break;
    case "/":
        result = $"Result:{num1/num2}";
    break;
    default:
        result = $"result invalid operator";
    break;
}
Console.WriteLine(result);
Console.ReadKey();