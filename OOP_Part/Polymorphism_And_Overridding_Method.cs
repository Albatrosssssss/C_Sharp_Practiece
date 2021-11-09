//Polymorphism means "many forms", 
and it occurs when we have many classes that are related to each other by inheritance.//

//Same method uses many class 
class Animal  // Base class (parent) 
{
  public void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myPig = new Pig();  // Create a Pig object
    Animal myDog = new Dog();  // Create a Dog object

    myAnimal.animalSound();
    myPig.animalSound();
    myDog.animalSound();
  }
}
//OUTPUT//
/*The animal makes a sound
The animal makes a sound
The animal makes a soundZ*/

//But we need//
/*The animal makes a sound
The pig says: wee wee
The dog says: bow wow */

//SOLUTION//
/*
The output from the example above was probably not what you expected. 
That is because the base class method overrides the derived class method, 
when they share the same name.
However, C# provides an option to override the base class method, 
by adding the virtual keyword to the method inside the base class, 
and by using the override keyword for each derived class methods
*/
class Animal  // Base class (parent) 
{
  public virtual void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myPig = new Pig();  // Create a Pig object
    Animal myDog = new Dog();  // Create a Dog object

    myAnimal.animalSound();
    myPig.animalSound();
    myDog.animalSound();
  }
}
//OUTPUT//
/*The animal makes a sound
The pig says: wee wee
The dog says: bow wow*/

