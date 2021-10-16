//Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
int[] myNum = {10, 20, 30, 40};


//Access the Elements of an Array
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars[0]);
// Outputs Volvo


//Change an Array Element
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
cars[0] = "Opel";
Console.WriteLine(cars[0]);
// Now outputs Opel instead of Volvo


//Array Length
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars.Length);
// Outputs 4


//The foreach Loop
//There is also a foreach loop, which is used exclusively to loop through elements in an array
foreach (type variableName in arrayName) 
{
  // code block to be executed
}

//Exm:
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars) 
{
  Console.WriteLine(i);
}


//Sort Arrays
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Array.Sort(cars);
foreach (string i in cars)
{
  Console.WriteLine(i);
}


