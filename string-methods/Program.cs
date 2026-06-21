Console.Write("Enter Your Name : ");
string a = Console.ReadLine()!;
Console.WriteLine("Your name in all capital is : " + a.ToUpper());
Console.WriteLine("Your name in all small is :" + a.ToLower());
// this are only some of the basic string methods only, they are a lot of them

Console.Write("Enter your phonenumber : ");
string b = Console.ReadLine()!;
Console.Write("Choose the number you want to replace : ");
char c = Convert.ToChar(Console.ReadLine())!;
Console.Write("Enter the number you want to be in the place of replaced number : ");
char d = Convert.ToChar(Console.ReadLine())!;
Console.WriteLine(b.Replace(c ,d));
