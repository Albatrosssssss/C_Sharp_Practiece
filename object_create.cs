//OOP is faster and easier to execute
//OOP provides a clear structure for the programs
//OOP helps to keep the C# code DRY "Don't Repeat Yourself", and makes the code easier to maintain, modify and debug
//OOP makes it possible to create full reusable applications with less code and shorter development time


//creating Multiple Object
class Car
{
  string color = "red";
  static void Main(string[] args)
  {
    Car myObj1 = new Car();
    Car myObj2 = new Car();
    Console.WriteLine(myObj1.color);
    Console.WriteLine(myObj2.color);
  }
}

