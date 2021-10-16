//Methods are used to perform certain actions, and they are also known as functions.
//Create a Method
class Program
{
  static void MyMethod() 
  {
    // code to be executed
  }
}
//static means that the method belongs to the Program class and not an object of the Program class. You will learn more about objects and how to access methods through objects later in this tutorial.
//void means that this method does not have a return value. You will learn more about return values later in this chapter


//Call a Method
static void MyMethod() 
{
  Console.WriteLine("I just got executed!");
}

static void Main(string[] args)
{
  MyMethod();
}

// Outputs "I just got executed!"

