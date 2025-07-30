// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//creating the marksheet
Console.WriteLine("\"MARKSHEET\"");
Console.WriteLine("Enter Name");
Console.ReadLine();
Console.WriteLine("Enter std id");
int std = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter eng marks");
int eng = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter math marks");
int math = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter sci marks");
int sci = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter art marks");
int art = Convert.ToInt32(Console.ReadLine());
int total = eng+math+sci+art;
Console.WriteLine($"optain marks: {total}");
int opt = 200;
int result = opt/total*100;
Console.WriteLine($"Percentage: {result}%");
Console.ReadKey();
