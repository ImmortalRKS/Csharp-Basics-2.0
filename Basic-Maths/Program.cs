using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

double a = 5;
double b = 10;
double c = 15;
double d = -21;

Console.WriteLine(Math.Pow(a,2)); //a is the base here and 2 is the power above it
Console.WriteLine(Math.Sqrt(b)); //this one takes square root of b

Console.WriteLine(Math.Abs(c));
Console.WriteLine(Math.Abs(d)); //Math.Abs() actually tells the position of the number from zero
// it basically tells how much far are you from zero and always giving postive output

double e = -12.69;
Console.WriteLine(Math.Abs(e));//it shows decimal values as well
Console.WriteLine(Math.Abs(0)); //for zero its just zero 


double f = 3.14;
double g = 3.67;
Console.WriteLine(Math.Round(f)); //this is just rounding up and will go toward that number which is closer
Console.WriteLine(Math.Round(g));

double h = 3.12;
Console.WriteLine(Math.Ceiling(h));// this will make the number to go only towards the above number

double i = 3.99;
Console.WriteLine(Math.Floor(i));// this will make the number to only go towards down


double j = 6;
double k = 7;
Console.WriteLine(Math.Max(j,k)); // do i even need to say something about this??
Console.WriteLine(Math.Min(j,k));

//my english is sooo bad