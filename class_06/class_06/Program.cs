// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

Console.WriteLine("Hello, World!");
Console.WriteLine("Methods in C#");
static void first()
{
    Console.WriteLine("Methods are there");
}

static void second(string name , int age)
{
    Console.WriteLine($" name :{name}, age{age} ");
}
static void third(string std="not found", string Batch="not found")
{
    Console.WriteLine($"std name:{std}, Batch name :{Batch}");
}
static void forth(string std1 , string std2 , string std3 , string std4)
{
    Console.WriteLine($"the std is dismissed:{std2}");
}
static void fifth(int a , int b)
{
    int c = a + b;
    Console.WriteLine($"the sum is:{c}");
}
first();
second("Manahil",12);
third("Alen" , "0ahjdh");
third();
forth(std1:"sybil", std2:"manahil",std3:"anna",std4:"eden");
fifth(12 ,2);
fifth(21, 2);














Console.ReadKey();
