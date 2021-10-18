//PRIVET MODIFIER
//within the same class:
class Car 
{
  private string model = "Mustang";

  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.model);
  }
}
//output"Mustang"



//outside the class, error will occur:
//car class
class Car
{
  private string model = "Mustang";
}

//program class
class Program
{
  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.model);
  }
}
//output"Mustang"




//PUBLIC MODIFIER
class Car
{
  public string model = "Mustang";
}

class Program
{
  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.model);
  }
}
//output"Mustang"

