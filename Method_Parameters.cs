//Parameters and Arguments
static void MyMethod(string fname) 
{
  Console.WriteLine(fname + " Refsnes");
}
static void Main(string[] args)
{
  MyMethod("Liam");
  MyMethod("Jenny");
  MyMethod("Anja");
}
// Liam Refsnes
// Jenny Refsnes
// Anja Refsnes


//Default Parameter Value
static void MyMethod(string country = "Norway") 
{
  Console.WriteLine(country);
}
static void Main(string[] args)
{
  MyMethod("Sweden");
  MyMethod("India");
  MyMethod();
  MyMethod("USA");
}
// Sweden
// India
// Norway
// USA


//Multiple Parameters
static void MyMethod(string fname, int age) 
{
  Console.WriteLine(fname + " is " + age);
}
static void Main(string[] args)
{
  MyMethod("Liam", 5);
  MyMethod("Jenny", 8);
  MyMethod("Anja", 31);
}
// Liam is 5
// Jenny is 8
// Anja is 31


//Return Values
//The void keyword, used in the examples above, indicates that the method should not return a value. If you want the method to return a value, you can use a primitive data type (such as int or double) instead of void, and use the return keyword inside the method:
static int MyMethod(int x) 
{
  return 5 + x;
}
static void Main(string[] args)
{
  Console.WriteLine(MyMethod(3));
}
// Outputs 8 (5 + 3)



//Named Arguments
static void MyMethod(string child1, string child2, string child3) 
{
  Console.WriteLine("The youngest child is: " + child3);
}
static void Main(string[] args)
{
  MyMethod(child3: "John", child1: "Liam", child2: "Liam");
}
// The youngest child is: John

