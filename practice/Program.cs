using System.ComponentModel;

Console.Write("Enter Your Name : ");
string a = Console.ReadLine()!;

Console.Write("Enter Your Age : ");
int b = Convert.ToInt32(Console.ReadLine());

int c = b + 10;
Console.WriteLine("After 10 years your age will be : "+ c);

Console.Write("Pick a number from 1-10 : ");
int d = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Power : ");
int e = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The power of the base given is : " + Math.Pow(d,e));
Console.WriteLine("The number bigger between the two is : " + Math.Max(d,e));
Console.WriteLine("The number smaller between the two is : " + Math.Min(d,e));

Console.Write("Enter any decimal number : ");
double f = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("If we round up then the answer is : " + Math.Round(f));


