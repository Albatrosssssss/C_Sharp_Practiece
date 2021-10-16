//The Math.Max(x,y) method can be used to find the highest value of x and y:
Math.Max(5, 10);
Math.Min(5, 10);
Math.Sqrt(64);
Math.Abs(-4.7);
Math.Round(9.99);

//Strings
//A string in C# is actually an object, which contain properties and methods that can perform certain operations on strings.
string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine("The length of the txt string is: " + txt.Length);

//UPPER LOWER method
string txt = "Hello World";
Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
Console.WriteLine(txt.ToLower());   // Outputs "hello world"

//String Concatenation
string firstName = "John ";
string lastName = "Doe";
string name = firstName + lastName;
Console.WriteLine(name);

//String Interpolation
string firstName = "John";
string lastName = "Doe";
string name = $"My full name is: {firstName} {lastName}";
Console.WriteLine(name);

//Access Strings
string myString = "Hello";
Console.WriteLine(myString[0]);  // Outputs "H"

string myString = "Hello";
Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"

//Adding Number
string x = "10";
string y = "20";
string z = x + y;  // z will be 1020 (a string)

