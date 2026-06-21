Console.Write("Enter Your Name : ");
string a = Console.ReadLine()!;
Console.WriteLine("Your name in all capital is : " + a.ToUpper());
Console.WriteLine("Your name in all small is :" + a.ToLower());
// this are only some of the basic string methods only, they are a lot of them

Console.Write("Enter your phonenumber : ");
string b = Console.ReadLine()!;
Console.Write("Choose the number you want to replace : ");
string? cInput = Console.ReadLine();
char c = !string.IsNullOrEmpty(cInput) ? cInput[0] : '\0';
Console.Write("Enter the number you want to be in the place of replaced number : ");
string? dInput = Console.ReadLine();
char d = !string.IsNullOrEmpty(dInput) ? dInput[0] : '\0';
Console.WriteLine(b.Replace(c, d));


// In here we get phone number from the user and then ask him which number does he wish to change with what number and both of this is also given by him

// man wtf did copilot changed here, it made me freaking confused lol

Console.WriteLine(a.Insert(0, "Hello, ")); // This line inserts "Hello, " at the beginning of the name

//help me copilot is writing code for me ahhhhhhhhh

Console.WriteLine("The lenth of the name given in the very first is : " + a.Length);

Console.WriteLine("The first 3 words in your name is : " + a.Substring(0 ,3));

